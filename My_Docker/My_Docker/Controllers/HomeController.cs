using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace My_Docker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            // HttpClient client = new HttpClient();
            // var result = await client.GetAsync("http://webapi/api/home");
            // if (result.IsSuccessStatusCode)
            // {
            //     string? jsonResponse = await result.Content.ReadAsStringAsync() ?? null;
            //     var Names = new List<string>(); 
            //     Names =  JsonConvert.DeserializeObject<List<string>>(jsonResponse);
            //     ViewData["Names"] = Names;
            // }
            //
            //
            // byte[] fileBytes = System.IO.File.ReadAllBytes(@"E:\xxx\4_26_2023 12_00_00 AM.pdf");
            // string base64String = Convert.ToBase64String(fileBytes);
            // ViewData["Code"] = base64String;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}