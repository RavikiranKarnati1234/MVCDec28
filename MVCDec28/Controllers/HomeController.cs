using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDec28.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index(string id,string pass,string token)
        {
            return "HelloWorld @" + DateTime.Now.ToString();
        }

        public string Index1(string id)
        {
            return "HelloWorld1 @" + DateTime.Now.ToString();
        }
    }
}