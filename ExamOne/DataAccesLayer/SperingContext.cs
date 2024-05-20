using ExamOne.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace ExamOne.DataAccesLayer
{
    public class SperingContext:DbContext
    {
        private readonly DbContextOptions<SperingContext> _options;

        public SperingContext(DbContextOptions<SperingContext>options)
        {
            _options = options;
        }
        public DbSet<Category> Categories { get; set; }

    }
}
