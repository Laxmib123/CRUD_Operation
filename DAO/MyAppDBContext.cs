using ASP.NETCoreMVCByLaxmiBhattarai.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCoreMVCByLaxmiBhattarai.DAO
{
    public class MyAppDBContext : DbContext
    {
        public MyAppDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
