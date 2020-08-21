using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AccountAPI.Models;
namespace StockMarket.AccountAPI.Repositories
{
    public interface IAccountRepository
    {
        public void AddUser(User item);
        public User Validate(string uname, string pwd);
    }
}
