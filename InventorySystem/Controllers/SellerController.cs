using InventorySystem.Models;
using InventorySystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace InventorySystem.Controllers
{
    public class SellerController : Controller
    {
        private ApplicationDbContext _context;
        // GET: Seller
        public SellerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
           _context.Dispose();
        }
        public ActionResult Index()
        {
            var sellers = _context.Sellers.Include(c => c.Location).ToList();
            //var seller = new Seller() { FName="Emrik"};
            //var location = new Location() { address = "Alapot" };
            //var viewModel = new SellerLocation
            //{
            //    Seller = seller,
            //    Location = location

            //};
            return View(sellers);
        }

        // GET: Seller/Details/5
        public ActionResult Details(int id)
        {
            var seller = _context.Sellers.SingleOrDefault(c => c.id == id);
            if (seller==null)
            {
                return HttpNotFound();
            }
            return View(seller);
        }

        // GET: Seller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seller/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Seller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seller/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Seller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seller/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
