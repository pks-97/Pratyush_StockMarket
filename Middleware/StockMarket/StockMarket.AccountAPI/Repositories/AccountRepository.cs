using StockMarket.AccountAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AccountAPI.DBAccess;
namespace StockMarket.AccountAPI.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private StockDBContext context;

        public AccountRepository(StockDBContext context)
        {
            this.context = context;
        }
        public void AddUser(User item)
        {
            context.Users.Add(item);
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public User Delete(User item)
        {
            context.Users.Remove(item);
            context.SaveChanges();
            return item;
            //throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            IEnumerable<User> UserList = context.Users.ToList();
            return UserList;
            //throw new NotImplementedException();
        }

        public User GetUserById(string uid)
        {
            User user = context.Users.SingleOrDefault(i => i.UserId == uid);
            return user;
            //throw new NotImplementedException();
        }

        public bool IsUserName(string uname)
        {
            List<User> UserList = context.Users.ToList();
            User user = UserList.Find(x => x.Username == uname);
            if (user == null)
            {
                return false;
            }
            else return true;
            //throw new NotImplementedException();
        }

        public User Update(User item)
        {
            context.Users.Update(item);
            return item;
            //throw new NotImplementedException();
        }

        public User Validate(string uname, string pwd)
        {
            User user = context.Users.SingleOrDefault(i => i.Username == uname && i.Password == pwd);
            return user;
            //throw new NotImplementedException();
        }
    }
}
