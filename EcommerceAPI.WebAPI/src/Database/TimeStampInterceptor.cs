using EcommerceAPI.Core.src.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace EcommerceAPI.WebAPI.src.Database
{
    public class TimeStampInterceptor : SaveChangesInterceptor
    {
        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            var changedData = eventData.Context.ChangeTracker.Entries();
            var updatedEntries = changedData.Where(entity => entity.State == EntityState.Modified);
            var addedEntries = changedData.Where(entity => entity.State == EntityState.Added);

            foreach (var e in updatedEntries)
            {
                if (e.Entity is BaseEntity entity)
                {
                    entity.UpdatedAt = DateTime.Now;
                }
            }
            foreach (var e in addedEntries)
            {
                if (e.Entity is BaseEntity entity)
                {
                    entity.UpdatedAt = DateTime.Now;
                    entity.CreatedAt = DateTime.Now;
                }
            }

            return base.SavingChanges(eventData, result);
        }
    }
}