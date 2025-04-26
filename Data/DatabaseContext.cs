using CRUDBasicsAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUDBasicsAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<Patient> Patients { get; set; }
    }
}
