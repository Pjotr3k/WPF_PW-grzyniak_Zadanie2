using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PWęgrzyniak_Zadanie2.Models;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string jsonDir = Directory.GetCurrentDirectory();
            int ileDoMainFolder = 3;


            for(int i = 0; i < ileDoMainFolder; i++)
            {
                jsonDir = Directory.GetParent(jsonDir).FullName;
            }

            /*var configuration = new ConfigurationBuilder()                
                .SetBasePath(jsonDir)
                .AddJsonFile("appsettings.json")
                .Build();*/

            //'D:\Users\Admin\source\repos\PWęgrzyniak_Zadanie2\PWęgrzyniak_Zadanie2\bin\Debug\net6.0-windows\appsettings.json'.”
            
            //var connectionString = configuration.GetConnectionString("DefaultConnection");
            //optionsBuilder.UseSqlServer(connectionString);

            //optionsBuilder.UseSqlServer(@"Data Source=WYMIATACZ\SQLEXPRESS;Initial Catalog=Zadanie2DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }
    }
}
