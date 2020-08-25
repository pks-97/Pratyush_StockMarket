using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StockMarket.ExcelAPI.Models;
namespace StockMarket.ExcelAPI.DBAccess
{
    
    public class ExcelDBContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<StockPrice> StockPrices { get; set; }
        public DbSet<IPO> IPO { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=LAPTOP-429IF4JL\MSSQLSERVER03;Initial Catalog=tempdb;Integrated Security=True");
           
        }
    }
}
