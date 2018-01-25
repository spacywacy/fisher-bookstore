using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{

    public class HomeController : Controller{

        public IActionResult Index(){
            return Content("hello world");
        }
    }

    public class AboutController : Controller{

        public IActionResult Index(){
            return Content("index");
        }

        public IActionResult History(){
            return Content("history");
        }

        public IActionResult Location(){
            return Content("location");
        }

    }

    public class BooksController : Controller{

        public IActionResult Index(){
            return Content("book index");
        }

        public IActionResult New(){
            return Content("book new");
        }
    }

    public class AuthorsController : Controller{

        public IActionResult Index(){
            return Content("author index");
        }

        public IActionResult Featured(){
            return Content("author featured");
        }
    }

    public class OfferingsController : Controller{
        [Route("Products")]
        [Route("Products/Index")]

        public IActionResult Product(){
            return Content("This is the products page.");
        }

        [Route("Services")]
        [Route("Services/Index")]

        public IActionResult Services(){
            return Content("This is the products page.");
        }
    }

}