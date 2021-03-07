using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using UKSAquator.Models;

namespace UKSAquator.DAL
{
    public class NewsContext : DbContext
    {
        public NewsContext() : base("NewsContext")
        {

        }

        static NewsContext()
        {
            Database.SetInitializer<NewsContext>(new NewsInitializer());
        }

        public DbSet<News> DbNews { get; set; }
        public virtual DbSet<Gallery> DbGallery { get; set; }

    }
}