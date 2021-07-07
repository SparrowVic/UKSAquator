using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UKSAquator.DAL;
using UKSAquator.ViewModels;

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
            var news = db.DbNews.Where(a => !a.IsHidden).OrderByDescending(a => a.PublicationDate).ToList();

            var vm = new HomeViewModel()
            {
                News = news
            };

            return View(vm);
        }
    }
}