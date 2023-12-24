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
                // Retrieve the category using the CategoryId from the product
                var category = _database.Categories.FirstOrDefault(c => c.Id == product.CategoryId) ?? throw new Exception("Category not found");

                // Associate the product with the retrieved category
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
            }
            catch (Exception e)
            {
                throw new Exception("Error creating new product in Product table: " + e.Message.ToString());
            }
            return product;
        }


        public bool DeleteProduct(Guid productId)
        {
            var product = _products.Find(productId);
            if (product != null)
            {
                _products.Remove(product);
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

        private void UpdateEntityFields(Product existingProduct, Product product)
        {
            var dtoProperties = product.GetType().GetProperties();
            foreach (var dtoProp in dtoProperties)
            {
                if (dtoProp.Name == "Id" || (dtoProp.Name == "CategoryId"))
                {
                    continue;
                }
                var value = dtoProp.GetValue(product);
                if (value != null)
                {
                    var entityProp = existingProduct.GetType().GetProperty(dtoProp.Name);
                    if (entityProp != null && entityProp.CanWrite)
                    {
                        entityProp.SetValue(existingProduct, value);
                    }
                }
            }
        }

        public bool CheckProductExist(Guid productId)
        {
            return _products.Any(c => c.Id == productId);
        }
    }
}