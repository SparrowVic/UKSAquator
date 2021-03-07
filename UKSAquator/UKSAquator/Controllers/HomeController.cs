using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UKSAquator.DAL;
using UKSAquator.Models;
using UKSAquator.ViewModels;

namespace UKSAquator.Controllers
{
    public class HomeController : Controller
    {
        private NewsContext db = new NewsContext();

        // GET: Home
        public ActionResult Index()
        {
            var news = db.DbNews.Where(a => !a.IsHidden).OrderByDescending(a => a.PublicationDate).Take(6).ToList();

            var vm = new HomeViewModel()
            {
                News = news
            };

            return View(vm);
        }

        public ActionResult Gallery(int id)
        {
            var galleries = db.DbGallery.Where(a => a.NewsId == id).ToList();

            var vm = new HomeViewModel()
            {
                Galleries = galleries
            };

            return View(vm);

            //var news = db.DbGallery.Find(id);

            //return View(news);
        }

        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);
        }
    }
}