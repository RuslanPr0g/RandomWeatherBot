using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RandWeatherBot.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "попадется твой город - повезло";
        }
    }
}