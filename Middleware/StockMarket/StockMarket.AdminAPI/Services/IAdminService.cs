using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Models;
namespace StockMarket.AdminAPI.Services
{
    public interface IAdminService
    {
        public void Add(Company c);
        public void Delete(Company c);
        public void Edit(Company c);
        public Company GetCompanyById(string code);
        public bool Validate(string uname, string pwd);
    }
}
