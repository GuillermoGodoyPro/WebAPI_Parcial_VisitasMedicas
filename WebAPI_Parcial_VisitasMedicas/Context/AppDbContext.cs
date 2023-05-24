using Microsoft.EntityFrameworkCore;
using WebAPI_Parcial_VisitasMedicas.Models;

namespace WebAPI_Parcial_VisitasMedicas.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ambulancia> Ambulancias { get; set; }
        //public DbSet<>
        
    }
}
