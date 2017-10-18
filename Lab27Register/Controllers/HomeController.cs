using Lab27Register.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27Register.Controllers
{
    public class HomeController : Controller
    {
        private readonly Lab27RegisterContext _context;
        public HomeController(Lab27RegisterContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.CMS.Where(c => c.ID > 0);
            return View(result.ToList());
        }
    }
}
