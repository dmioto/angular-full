using Microsoft.EntityFrameworkCore;

namespace CadastroAPI.Models
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }
    }
}