using EcommerceAPI.Core.src.Abstraction;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.WebAPI.src.Database;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.WebAPI.src.Repository
{
    public class ImageRepo : IImageRepo
    {
        private DbSet<Image> _images;
        private DatabaseContext _database;
        public ImageRepo(DatabaseContext database)
        {
            _database = database;
            _images = database.Images;
        }
        public Image AddNewImageToProduct(Image image)
        {
            _images.Add(image);
            _database.SaveChanges();
            return image;
        }

        public bool DeleteImage(Guid imageId)
        {
            var image = _images.Find(imageId);
            if (image != null)
            {
                _images.Remove(image);
                _database.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Image> GetImagesByProductId(Guid productId)
        {
            return _images.AsNoTracking().Where(i => i.ProductId == productId);
        }

        public bool UpdateImage(Guid imageId, Image image)
        {
            var existingImage = _images.Find(imageId);
            if (existingImage != null)
            {
                UpdateEntityFields(existingImage, image);
                existingImage.UpdatedAt = DateTime.Now;
                _database.SaveChanges();
                return true;
            }
            return false;
        }

        private void UpdateEntityFields(Image existingImage, Image image)
        {
            var dtoProperties = image.GetType().GetProperties();
            foreach (var dtoProp in dtoProperties)
            {
                if ((dtoProp.Name == "ProductId") || (dtoProp.Name == "Id") || (dtoProp.Name == "CreatedAt"))
                {
                    continue;
                }
                var value = dtoProp.GetValue(image);
                if (value != null)
                {
                    var entityProp = existingImage.GetType().GetProperty(dtoProp.Name);
                    if (entityProp != null && entityProp.CanWrite)
                    {
                        entityProp.SetValue(existingImage, value);
                    }
                }
            }
        }
    }
}