using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int id = User.Identity.GetUserId<int>();
            ViewBag.Message = "Ваш id: " + id.ToString();
            return View();
        }
    }
}