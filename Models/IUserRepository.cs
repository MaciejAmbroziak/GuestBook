using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBook.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> AllUsers { get; }
        public void Add(User user);
        public void Remove(int id);
        public User GetUser(int id);
        void Update(int id);
    }
}
