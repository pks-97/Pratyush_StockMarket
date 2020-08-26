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

        public User Delete(User item)
        {
            User user = rep.Delete(item);
            return item;
            //throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return (rep.GetAllUsers());
            //throw new NotImplementedException();
        }

        public User GetUserById(string uid)
        {
            return (rep.GetUserById(uid));
            //throw new NotImplementedException();
        }

        public bool IsUserName(string uname)
        {
            return (rep.IsUserName(uname));
         //   throw new NotImplementedException();
        }

        public User Update(User item)
        {
            return (rep.Update(item));
            //throw new NotImplementedException();
        }

        public User Validate(string uname, string pwd)
        {
            return (rep.Validate(uname, pwd));
            //throw new NotImplementedException();
        }
    }
}
