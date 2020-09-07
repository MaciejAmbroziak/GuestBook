using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBook.Models
{
    public class MockUserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public MockUserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<User> AllUsers => _appDbContext.Users;

        public void AddUser(User user)
        {
            _appDbContext.Add(user);
            _appDbContext.SaveChanges();
        }
    }
}

