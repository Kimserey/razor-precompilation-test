using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RazorPrecompilationTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RazorPrecompilationTest.Controllers
{
    [Route("account")]
    public class AccountController: Controller
    {
        [HttpGet("login")]
        public async Task<IActionResult> Login([FromServices] IHttpClientFactory factory)
        {
            var client = factory.CreateClient();
            client.BaseAddress = new Uri("http://api");
            var res = await client.GetAsync("api/values");
            var json = await res.Content.ReadAsStringAsync();

            return View(new LoginViewModel
            {
                Title = "Helloworld",
                Values = JsonConvert.DeserializeObject<string[]>(json)
            });
        }
    }
}
