using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UKSAquator.Models
{
    public class Gallery
    {
        public int GalleryId { get; set; }
        public string GalleryFileName { get; set; }
        public int NewsId { get; set; }
    }
}