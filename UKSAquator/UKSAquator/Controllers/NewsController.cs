using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UKSAquator.DAL;

namespace UKSAquator.Controllers
{
    public class NewsController : Controller
    {
        NewsContext db = new NewsContext();

        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var news = db.DbNews.Find(id);

            return View(news);
        }

        public ActionResult List()
        {
            return View();
        }
    }
}