using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UKSAquator.Models
{
    public class News
    {
        public int NewsId { get; set; }
        public string NewsTitle { get; set; }
        public string Description { get; set; }
        public string CountryEvent { get; set; }
        public string CityEvent { get; set; }
        public DateTime StartDateEvent { get; set; }
        public DateTime EndDateEvent { get; set; }
        public DateTime PublicationDate { get; set; }
        public string CoverFileName { get; set; }
        public bool IsHidden { get; set; }
    }
}