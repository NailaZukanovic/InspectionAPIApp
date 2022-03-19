using Microsoft.EntityFrameworkCore;

namespace InspectionAPI.Controllers.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Inpection> Inspections { get; set; }

        public DbSet<InspectionType> InspectionTypes { get; set; }

        public DbSet<Status> Statuses { get; set; }


    }
}
