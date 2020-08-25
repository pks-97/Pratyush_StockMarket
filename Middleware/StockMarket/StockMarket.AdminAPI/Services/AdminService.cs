using StockMarket.AdminAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Repositories;
namespace StockMarket.AdminAPI.Services
{
    public class AdminService : IAdminService
    {
        private IAdminRepository ar;

        public AdminService(IAdminRepository rep)
        {
            ar = rep;
        }
        public void Add(Company c)
        {
            ar.Add(c);
            //throw new NotImplementedException();
        }

        public void Delete(Company c)
        {
            ar.Delete(c);
            //throw new NotImplementedException();
        }

        public void Edit(Company c)
        {
            ar.Edit(c);
            //throw new NotImplementedException();
        }

        public Company GetCompanyById(string code)
        {
            Company com = ar.GetCompanyById(code);
            return com;
            //throw new NotImplementedException();
        }
        public bool Validate(string uname, string pwd)
        {
            return (ar.Validate(uname, pwd));
        }
        public void EditIPO(IPO ipo)
        {
            ar.EditIPO(ipo);
            //context.SaveChanges();
            //throw new NotImplementedException();
        }
        public void DeleteIPO(IPO ipo)
        {
            ar.DeleteIPO(ipo);
            //context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void AddIPO(IPO ipo)
        {
            ar.AddIPO(ipo);
            //context.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
