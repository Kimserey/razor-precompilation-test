using Microsoft.AspNetCore.Mvc;
using RazorPrecompilationTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPrecompilationTest.Controllers
{
    [Route("account")]
    public class AccountController: Controller
    {
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View(new LoginViewModel {
                Title = "Helloworld"
            });
        }
    }
}
