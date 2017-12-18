using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DidlyVidly.Models;
using DidlyVidly.ViewModels;

namespace DidlyVidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John Smith"},
            new Customer { Id = 2, Name = "Mary Williams" }
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int Id)
        {
            foreach (Customer c in customers)
            {
                if (c.Id == Id)
                {
                    var viewModel = new CustomerDetailsViewModel
                    {
                        Customer = customers[Id - 1]
                    };
                    return View(viewModel);
                }
            }

            return HttpNotFound();
        }
    }
}