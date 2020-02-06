using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practical.Models
{
    public class UserController : Controller
    {
        // GET: User

        public int newQuote { get; private set; }
        public ActionResult Index()
        {
            return View();
        }
    }
}