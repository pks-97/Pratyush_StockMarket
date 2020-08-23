using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StockMarket.AdminAPI.Models;
namespace StockMarket.AdminAPI.DBAccess
{
    
    public class AdminDBContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<StockPrice> StockPrices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=LAPTOP-429IF4JL\MSSQLSERVER03;Initial Catalog=tempdb;Integrated Security=True");
        }
    }
}
