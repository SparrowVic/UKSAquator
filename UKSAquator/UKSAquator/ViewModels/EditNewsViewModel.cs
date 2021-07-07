using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UKSAquator.Models;

namespace UKSAquator.ViewModels
{
    public class EditNewsViewModel
    {
        public News News { get; set; }
        public bool? ConfirmSuccess { get; set; }
    }
}