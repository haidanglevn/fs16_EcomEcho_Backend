using System.Reflection;
using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;
using EcommerceAPI.WebAPI.src.Database;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.WebAPI.src.Repository
{
    public class ProductRepo : IProductRepo
    {
        private DbSet<Product> _products;
        private DbSet<Variant> _variants;
        private DbSet<Image> _images;
        private DatabaseContext _database;
        public ProductRepo(DatabaseContext database)
        {
            _products = database.Products;
            _variants = database.Variants;
            _images = database.Images;
            _database = database;
        }

        public Product CreateNewProduct(Product product)
        {
            try
            {
                var category = _database.Categories.FirstOrDefault(c => c.Id == product.CategoryId) ?? throw new Exception("Category not found");

                product.Category = category;

                _products.Add(product);
                foreach (Variant variant in product.Variants)
                {
                    _variants.Add(variant);
                }
                foreach (Image image in product.Images)
                {
                    _images.Add(image);
                }
                _database.SaveChanges();
                return product;
            }
            catch (Exception e)
            {
                throw new Exception("Error creating new product in Product table: " + e.Message.ToString());
            }
        }


        public bool DeleteProduct(Guid productId)
        {
            var product = _products.Find(productId);
            if (product != null)
            {
                product.IsDeleted = true;
                _database.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Product> GetAllProducts(GetAllParams options)
        {
            return _products.AsNoTracking()
            .Include(p => p.Category)
            .Include(p => p.Variants)
            .Include(p => p.Images)
            .Include(p => p.Reviews)
            .Where(u => u.Title.Contains(options.Search))
            .Skip(options.Offset)
            .Take(options.Limit);
        }

        public Product? GetOneProduct(Guid productId)
        {
            return _products
                    .Include(p => p.Category)
                    .Include(p => p.Variants)
                    .Include(p => p.Images)
                    .Include(p => p.Reviews)
                    .FirstOrDefault(p => p.Id == productId);
        }

        public bool UpdateProduct(Guid productId, Product product)
        {
            var existingProduct = _products.Find(productId);
            if (existingProduct != null)
            {
                UpdateEntityFields(existingProduct, product);
                // Image, Review or Variant has to be updated seperately.
                existingProduct.UpdatedAt = DateTime.Now;
                _database.SaveChanges();
                return true;
            }
            return false;
        }

        private static void UpdateEntityFields(Product existingProduct, Product product)
        {
            var dtoProperties = product.GetType().GetProperties();
            foreach (var dtoProp in dtoProperties)
            {
                if (dtoProp.Name == "Id" || dtoProp.Name == "CategoryId")
                {
                    continue;
                }

                var value = dtoProp.GetValue(product);
                var entityProp = existingProduct.GetType().GetProperty(dtoProp.Name);
                if (entityProp != null && entityProp.CanWrite)
                {
                    if (value != null && !IsDefaultValue(dtoProp, value))
                    {
                        entityProp.SetValue(existingProduct, value);
                    }
                }
            }
        }

        private static bool IsDefaultValue(PropertyInfo property, object value)
        {
            if (property.PropertyType.IsValueType)
                return value.Equals(Activator.CreateInstance(property.PropertyType));
            return false;
        }

        public bool CheckProductExist(Guid productId)
        {
            return _products.Any(c => c.Id == productId);
        }
    }
}