using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBook.Models
{
    public class MockUserRepository : IUserRepository
    {
        public IEnumerable<User> AllUsers =>
            new List<User>
            {
                new User{UserId = 1, GivenName= "Tomasz", FamilyName = "Kowalski"},
                new User{UserId = 2, GivenName = "Marcin", FamilyName = "Izworski"},
                new User{UserId = 3, GivenName = "Maciej", FamilyName = "Ambroziak"}
            };
    }
}
