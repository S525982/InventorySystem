using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventorySystem.Controllers
{
    public class LocationController : Controller
    {
        private ApplicationDbContext _context;
        // GET: Location/Index
        public LocationController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var location = _context.Locations.ToList();
            return View(location);

            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //from one page to another
            //return RedirectToAction("Index", "Home", new {page=1,sortby=name});
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //[Route("moview/released/{year}/{month:regex(\\d{4})range(1,12)}")]
        public ActionResult Page(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
	        {
		        sortBy="Name";
	        }
            return Content(String.Format("pageIndex={0}&sortby={1}",pageIndex,sortBy));
        }
    }
}