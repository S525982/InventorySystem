using InventorySystem.Models;
using InventorySystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventorySystem.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _context;
        // GET: Product
        public ProductController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
           _context.Dispose();
        }
        public ActionResult Index()
        {
            try
            {
                var product = _context.Products.ToList();
                return View(product);
            }
            catch (DbEntityValidationException e)
            {

                Console.WriteLine(e);
            }
            return View();
            
        }
        
        public ActionResult New()
        {
            return View();
        }
        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var product = _context.Products.SingleOrDefault(c => c.ProductId == id);
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(SellerProduct SellerProduct)
        {
            var product = new Product {
                Name = SellerProduct.Product.Name,
                Size = SellerProduct.Product.Size,
                Code = SellerProduct.Product.Code,
                Color = SellerProduct.Product.Color,
                Comment = SellerProduct.Product.Comment,
                Quantity = SellerProduct.Product.Quantity,
                Type=SellerProduct.Product.Type
            };
            var seller = new Seller();
            try
            {
                //if (!ModelState.IsValid)
                //{
                //    return View(SellerProduct); 
                //}
                //_context.Products.Add(product);
                product.SellerId=1;
                _context.Products.Add(product);
                _context.SaveChanges();
                
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("Index");
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
