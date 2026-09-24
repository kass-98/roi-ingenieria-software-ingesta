using Microsoft.EntityFrameworkCore;
using RoiSoftware.IngestaApi.Models;

namespace RoiSoftware.IngestaApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Vacante> Vacantes { get; set; }
    }
}
