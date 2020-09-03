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
        private readonly IUserRepository _userRepository;

        public EntryController(IEntryRepository entryRepository, IUserRepository userRepository)
        {
            _entryRepository = entryRepository;
            _userRepository = userRepository;
        }

        public ViewResult List()
        {
            return View(_entryRepository.AllEntries);
        }
    }
}
