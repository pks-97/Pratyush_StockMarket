using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StockMarket.AccountAPI.Models;
namespace StockMarket.AccountAPI.DBAccess
{
    public class StockDBContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<StockPrice> StockPrices { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<IPO> IPO { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-429IF4JL\MSSQLSERVER03;Initial Catalog=tempdb;Integrated Security=True");
        }
    }
}
