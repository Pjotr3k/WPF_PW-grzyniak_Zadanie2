using Microsoft.EntityFrameworkCore;
using PWęgrzyniak_Zadanie2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWęgrzyniak_Zadanie2.Data
{
    internal class AppDbContext : DbContext
    {
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
            //optionsBuilder.UseSqlServer(@"Data Source=WYMIATACZ\SQLEXPRESS;Initial Catalog=Zadanie1DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            //optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }
    }
}
