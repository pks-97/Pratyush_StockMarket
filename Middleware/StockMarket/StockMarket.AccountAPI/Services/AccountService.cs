using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AccountAPI.Repositories;
using StockMarket.AccountAPI.Models;
using StockMarket.AccountAPI.Services;
namespace StockMarket.AccountAPI.Services
{
    public class AccountService: IAccountService
    {
        private IAccountRepository rep;
        public AccountService(IAccountRepository r)
        {
            rep = r;
        }
        public void AddUser(User item)
        {
            rep.AddUser(item);
            //throw new NotImplementedException();
        }

        public User Validate(string uname, string pwd)
        {
            return (rep.Validate(uname, pwd));
            //throw new NotImplementedException();
        }
    }
}
