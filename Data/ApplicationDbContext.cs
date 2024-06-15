using Microsoft.EntityFrameworkCore;
using NguyenThiKhanhLy_424;

namespace NguyenThiKhanhLy_424.Data{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<Lophoc>Lophoc {get;set;}
    }
}