using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBook.Models
{

    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<User> AllUsers => _appDbContext.Users;

        public void Add(User user)
        {
            _appDbContext.Add(user);
            _appDbContext.SaveChanges();
        }



        public User GetUser(int id)
        {
            return AllUsers.Where(a => a.UserId == id).FirstOrDefault();

        }

        public void Remove(int id)
        {
            _appDbContext.Remove(AllUsers.Where(a => a.UserId == id).FirstOrDefault());
            _appDbContext.SaveChanges();
        }

        public void Update(int id)
        {
            User user = GetUser(id);
            _appDbContext.Update(user);
            _appDbContext.SaveChanges();
        }
    }
}

