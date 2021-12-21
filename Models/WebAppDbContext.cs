using Microsoft.EntityFrameworkCore;

namespace WebAppDBList.Models
{
    public class WebAppDbContext:DbContext
    {
        public WebAppDbContext(DbContextOptions<WebAppDbContext>options):base(options)
        {

        }
        public DbSet<Customer> Customers{ get; set; }
    }
}
