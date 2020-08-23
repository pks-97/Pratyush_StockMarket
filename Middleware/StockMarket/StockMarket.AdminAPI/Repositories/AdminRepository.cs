using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Models;
using StockMarket.AdminAPI.DBAccess;


namespace StockMarket.AdminAPI.Repositories
{
    //AdminDBContext context = new AdminDBContext();
    public class AdminRepository : IAdminRepository
    {
        private AdminDBContext context;

        public AdminRepository(AdminDBContext context)
        {
            this.context = context;
        }
        public void Add(Company c)
        {
            context.Add(c);
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Delete(Company c)
        {
            context.Remove(c);
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Edit(Company c)
        {
            context.Update(c);
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public Company GetCompanyById(string code)
        {
            Company com = context.Companies.Find(code);
            return com;
            //throw new NotImplementedException();
        }

        public bool Validate(string uname, string pwd)
        {
            if (uname == "Pratyush" && pwd == "pass")
            {
                return true;
            }
            else return false;
        }
    }
}
