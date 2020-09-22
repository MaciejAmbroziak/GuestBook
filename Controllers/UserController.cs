using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuestBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace GuestBook.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public ViewResult List()
        {
            return View(_userRepository.AllUsers);
        }
        [HttpPost]
        public ViewResult Remove(int id)
        {
            _userRepository.Remove(id);
            return View("List", _userRepository.AllUsers);
        }
        [HttpGet]
        public ViewResult SaveUser()
        {
            return View();
        }
        [HttpPost]
        public ViewResult SaveUser([Bind("UserId, GivenName, FamilyName")] User user)
        {
            _userRepository.Add(user);
            return View("List",_userRepository.AllUsers);
        }
        [HttpGet]
        public ViewResult Modify(int id)
        {
            User user = _userRepository.GetUser(id);
            return View(user);
        }
        [HttpPost]
        public ViewResult Update(int id)
        {
            User user = _userRepository.GetUser(id);
            TryUpdateModelAsync(user, "", s => s.GivenName, s => s.FamilyName);
            _userRepository.Update(id);
            return View("List", _userRepository.AllUsers);
        }

    } 
}
