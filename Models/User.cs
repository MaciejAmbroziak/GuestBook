using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBook.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
    }
}
