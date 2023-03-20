using Microsoft.EntityFrameworkCore;
using PWęgrzyniak_Zadanie2.Models;

namespace PWęgrzyniak_Zadanie2.Data
{
    internal class AppDbContext : DbContext
    {
        private const string CONNECTION_STRING = @"Data Source=WYMIATACZ\SQLEXPRESS;Initial Catalog=Zadanie2DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        
        public DbSet<Pracownik> Pracowniks { get; set; }
        public DbSet<Zadanie> Zadanies { get; set; }

        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }                

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }
    }
}
