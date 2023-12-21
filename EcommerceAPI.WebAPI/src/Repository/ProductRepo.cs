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
        private DatabaseContext _database;
        public ProductRepo(DatabaseContext database)
        {
            _products = database.Products;
            _variants = database.Variants;
            _database = database;
        }
        // public Product CreateNewProduct(Product product)
        // {
        //     try
        //     {
        //         _products.Add(product);
        //     }
        //     catch (Exception e)
        //     {
        //         throw new Exception("Error creating new product in Product table: " + e.Message.ToString());
        //     }
        //     foreach (Variant variant in product.Variants)
        //     {
        //         _variants.Add(variant);
        //     }
        //     _database.SaveChanges();
        //     return product;
        // }
        public Product CreateNewProduct(Product product)
        {
            try
            {
                // Retrieve the category using the CategoryId from the product
                var category = _database.Categories.FirstOrDefault(c => c.Id == product.CategoryId);
                if (category == null)
                {
                    throw new Exception("Category not found");
                }

                // Associate the product with the retrieved category
                product.Category = category;

                _products.Add(product);
                foreach (Variant variant in product.Variants)
                {
                    _variants.Add(variant);
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
            .Where(u => u.Title.Contains(options.Search))
            .Skip(options.Offset)
            .Take(options.Limit);
        }

        public Product? GetOneProduct(Guid productId)
        {
            return _products.Include(p => p.Variants).FirstOrDefault(p => p.Id == productId);
        }

        public bool UpdateProduct(Guid productId, Product product)
        {
            var existingProduct = _products.Find(productId);
            if (existingProduct != null)
            {
                existingProduct.Title = product.Title;
                existingProduct.Price = product.Price;
                existingProduct.Description = product.Description;
                // Image, Review or Variant has to be updated seperately.
                existingProduct.UpdatedAt = DateTime.Now;
                _database.SaveChanges();
                return true;
            }
            return false;
        }
    }
}