using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBook.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public User User { get; set; }
        public string Description { get; set; }
    }
}
