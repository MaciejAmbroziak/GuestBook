﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBook.Models
{
    public interface IEntryRepository
    {
        IEnumerable<Entry> AllEntries { get; }
        Entry getEntryById(int ID);

    }
}
