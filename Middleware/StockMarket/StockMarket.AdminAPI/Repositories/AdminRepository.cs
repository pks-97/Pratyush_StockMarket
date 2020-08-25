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
            context.Companies.Add(c);
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void AddIPO(IPO ipo)
        {
            context.IPO.Add(ipo);
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void DeleteIPO(IPO ipo)
        {
            context.IPO.Remove(ipo);
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Delete(Company c)
        {
            context.Companies.Remove(c);
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Edit(Company c)
        {
            context.Companies.Update(c);
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void EditIPO(IPO ipo)
        {
            context.IPO.Update(ipo);
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
