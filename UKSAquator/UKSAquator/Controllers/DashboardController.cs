using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UKSAquator.DAL;
using UKSAquator.Models;
using UKSAquator.ViewModels;
using UKSAquator.Infrastructure;

namespace UKSAquator.Controllers
{
    public class DashboardController : Controller
    {
        private NewsContext db = new NewsContext();

        // GET: Home
        public ActionResult NewsList()
        {
            var news = db.DbNews.OrderByDescending(a => a.PublicationDate).ToList();

            var vm = new HomeViewModel()
            {
                News = news
            };

            return View(vm);
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult AddNews(int? NewsId, bool? confirmSuccess)
        {
            News n;

            if (NewsId.HasValue)
            {
                ViewBag.EditMode = true;
                n = db.DbNews.Find(NewsId);
            }
            else
            {
                ViewBag.EditMode = false;
                n = new News();
            }

            var result = new EditNewsViewModel();

            result.News = n;
            result.ConfirmSuccess = confirmSuccess;
            return View(result);
        }

        [HttpPost]
        public ActionResult AddNews(EditNewsViewModel model, HttpPostedFileBase file)
        {
            if (model.News.NewsId > 0)
            {
                // Saving existing entry

                db.Entry(model.News).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("AddNews", new { confirmSuccess = true });
            }
            else
            {
                var f = Request.Form;

                if (file != null && file.ContentLength > 0)
                {

                    // Generate filename

                    var fileExt = Path.GetExtension(file.FileName);
                    var filename = Guid.NewGuid() + fileExt;

                    var path = Path.Combine(Server.MapPath(AppConfig.PhotosFolderRelative), filename);
                    file.SaveAs(path);

                    // Save info to DB
                    model.News.CoverFileName = filename;
                    model.News.PublicationDate = DateTime.Now;
                    model.News.StartDateEvent = DateTime.Now;
                    model.News.EndDateEvent = DateTime.Now;

                    db.Entry(model.News).State = EntityState.Added;
                    db.SaveChanges();

                    return RedirectToAction("AddNews", new { confirmSuccess = true });
                }
                else
                {
                    ModelState.AddModelError("", "Nie wskazano pliku.");

                    return View();
                }
            }
        }
    }
}
