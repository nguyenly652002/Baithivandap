using Microsoft.EntityFrameworkCore;
using NguyenThiKhanhLy_424;
using NguyenThiKhanhLy_424.Models;

namespace NguyenThiKhanhLy_424.Data{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

         public DbSet<Person> Person { get; set;}
         public DbSet<NguyenThiKhanhLy_424.Models.Employee> Employee { get; set; } = default!;
       
    }
}