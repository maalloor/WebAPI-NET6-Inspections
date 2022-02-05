using Microsoft.EntityFrameworkCore;

namespace InspectionAPI
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<InspectionType> InspectionType { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
