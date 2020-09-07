using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBook.Models
{
    public class EntryRepository : IEntryRepository
    {
        private readonly AppDbContext _appDbContext;
        public EntryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Entry> AllEntries
        {
            get
            {
                return _appDbContext.Entries;
            }
        }
        public Entry getEntryById(int ID)
        {
            return _appDbContext.Entries.FirstOrDefault(a => (a.EntryID == ID));
        }
    }
}
