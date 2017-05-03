using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Epidemic.Models;
using Microsoft.AspNetCore.Identity;
using Epidemic.ViewModels;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Epidemic.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _adminManager;
        private readonly SignInManager<User> _signInManager;
        public UserController(UserManager<User> adminManager, SignInManager<User> signInManager, EpidemicDbContext db)
        {
            _adminManager = adminManager;
            _signInManager = signInManager;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
