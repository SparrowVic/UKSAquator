using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UKSAquator.Models;

namespace UKSAquator.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<News> News { get; set; }
        public IEnumerable<Gallery> Galleries { get; set; }

    }
}