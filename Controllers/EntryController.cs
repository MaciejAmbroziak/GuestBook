using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuestBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuestBook.Controllers
{
    public class EntryController : Controller
    {
        private readonly IEntryRepository _entryRepository;
  

        public EntryController(IEntryRepository entryRepository)
        {
            _entryRepository = entryRepository;
        }

        public ViewResult List()
        {
            return View(_entryRepository.AllEntries);
        }
    }
}
