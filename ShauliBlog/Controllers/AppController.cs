using ShauliBlog.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShauliBlog.Controllers
{
    public class AppController : Controller
    {
        private ShuliDB db = new ShuliDB();
        
        public ActionResult Index()
        {
            
            return View(db.Posts.ToList());
        }
    }
}