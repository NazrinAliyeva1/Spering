using ExamOne.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace ExamOne.DataAccesLayer
{
    public class SperingContext:DbContext
    {
        public SperingContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    

        //public override Task<int>SaveChangeAsync(CancellationToken cancellationToken = default)
        //{
        //    foreach(var entry in ChangeTracker.Entries())
        //    {
        //        if(entry.Entity is BaseEntity entity)
        //        {
        //            switch(entry.State)
        //            {
        //                case EntityState.Added:
        //                    entity.CreatedTime = DateTime.Now;
        //                    entity.IsDeleted = false;
        //                    break;
        //                case EntityState.Modified:
        //                    entity.UpdatedTime = DateTime.Now;
        //                    break;
        //            }
        //        }
        //    }
        //    return base.SaveChangesAsync(cancellationToken);
        //}

    }
}
