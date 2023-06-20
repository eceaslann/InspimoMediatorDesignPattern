using Microsoft.EntityFrameworkCore;

namespace InspimoMediatorDesignPattern.DAL
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-RCI54VP; initial catalog=DbInspimoMediatorPattern;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
