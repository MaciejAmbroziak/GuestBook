using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBook.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> AllUsers { get; }
    }
}
