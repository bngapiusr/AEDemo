using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AEEFCore3.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AEEFCore3.Web.Models;

namespace AEEFCore3.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustomerDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, CustomerDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var customers = _context.Customer.ToList();

            //add data
            //var newCustomer = new Customer
            //{
            //    FirstName = "John",
            //    LastName = "Doe",
            //    CreditCardNumber = "4012888888881881",
            //    Total = 3000,
            //    CreatedDate = DateTime.UtcNow
            //};

            var newCustomer = new Customer
            {
                FirstName = "Peter",
                LastName = "Amos",
                CreditCardNumber = "5312888888886003",
                Total = 4010,
                CreatedDate = DateTime.UtcNow
            };

            _context.Customer.Add(newCustomer);
            _context.SaveChanges();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

