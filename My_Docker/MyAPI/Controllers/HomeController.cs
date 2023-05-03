using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Models;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : Controller
    {
        private readonly DockerContext _context;
        public HomeController(DockerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<string> GetValues()
        {

            var c= _context.Students.FirstOrDefault();
            Console.WriteLine(c.Name);
            var students = _context.Students.ToList();
            return students.Select(x=>x.Name).ToList();
        }
        
        [HttpGet]
        [Route("home1")]
        public List<string> GetValues1()
        {
            return new List<string>()
            {
                "A",
                "B"
            };
        }
    }
}