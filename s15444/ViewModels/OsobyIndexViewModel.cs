using s15444.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace s15444.ViewModels
{
    public class OsobyIndexViewModel
    {
        public IEnumerable<Osoba> IEOsoby { get; set; }
        public IEnumerable<Models.Type> IETypes { get; set; }
        public Osoba Osoba { get; set; }
        public IEnumerable<SelectListItem> TypesSelectList {
            get
            {
                return IETypes?.Select(t => new SelectListItem
                {
                    Value = t.IdType.ToString(),
                    Text = t.Rabat
                }) ?? new List<SelectListItem>();
            }
        }
    } 
}