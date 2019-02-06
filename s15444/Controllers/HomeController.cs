using s15444.Models;
using s15444.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace s15444.Controllers
{
    public class HomeController : Controller
    {
        private OsobyDbContext _context;
        
        public HomeController()
        {
            _context = new OsobyDbContext();
        }

        // GET: Home
        public ActionResult Index()
        {
            var vm = new OsobyIndexViewModel
            {
                IEOsoby = _context.Osoby.OrderBy(o => o.FirstName).ToList(),
                IETypes = _context.Types.OrderBy(t => t.Rabat).ToList(),
                Osoba = new Osoba()
            };

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(OsobyIndexViewModel model)
        {
            if(ModelState.IsValid)
            {
                _context.Osoby.Add(model.Osoba);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            model.IEOsoby = _context.Osoby.OrderBy(a => a.FirstName).ToList();
            model.IETypes = _context.Types.OrderBy(t => t.Rabat).ToList();
            return View(model);
        }
    }
}   