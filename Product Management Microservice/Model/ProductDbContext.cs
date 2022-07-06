using Microsoft.EntityFrameworkCore;
namespace Product_Management_Microservice.Model
{
    public class ProductDbContext : DbContext

    {
        public ProductDbContex(DbContextOptions options) : base(options)
        {



        }



        public DbSet<AppUser> AppUsers { get; set; }
    }

}
}
