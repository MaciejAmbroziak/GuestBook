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
                new Entry {EntryID = 1, User = _userRepository.AllUsers.ToList()[0], Description="Lorem Ipsum Dolor"},
                new Entry {EntryID = 2, User = _userRepository.AllUsers.ToList()[1], Description = "Lorem Ipsum Dolor"},
                new Entry {EntryID = 3, User = _userRepository.AllUsers.ToList()[2], Description = "Lorem Ipsum Dolor"}
            };

        public Entry getEntryById(int EntryID)
        {
            return AllEntries.FirstOrDefault(e => e.EntryID == EntryID);
        }
    }
}
