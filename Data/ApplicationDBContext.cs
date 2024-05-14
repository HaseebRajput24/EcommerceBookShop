using EcommerceBookShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceBookShop.Data
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
        { 

        }
    }
}
