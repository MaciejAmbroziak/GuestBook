using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBook.Models
{
    public class MockEntryRepository : IEntryRepository
    {
        private IUserRepository _userRepository = new MockUserRepository();
        public IEnumerable<Entry> AllEntries =>
            new List<Entry>
            {
                new Entry {ID = 1, User = _userRepository.AllUsers.ToList()[0], Description="Lorem"},
                new Entry {ID = 2, User = _userRepository.AllUsers.ToList()[1], Description = "Ipsum"},
                new Entry {ID = 3, User = _userRepository.AllUsers.ToList()[3], Description = "Dolor"}
            };

        public Entry getEntryById(int EntryID)
        {
            return AllEntries.FirstOrDefault(e => e.ID == EntryID);
        }
    }
}
