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
    public class BuyerController : Controller
    {
        private ApplicationDbContext _context;
        // GET: Buyer
        public BuyerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
           _context.Dispose();
        }
        public ActionResult Index()
        {
            var buyers = _context.Buyers.Include(c => c.MembershipType).Include(c=>c.Location).ToList();
            return View(buyers);
        }

        // GET: Buyer/Details/5
        public ActionResult Details(int id)
        {
            var buyer=_context.Buyers.SingleOrDefault(c=>c.BuyerId==id);
            var location = _context.Locations.SingleOrDefault(c=>c.id==id);
            var viewModel = new CustomerFormViewModel
            {
                Buyer = buyer,
                MembershipType = _context.MembershipTypes.ToList(),
                Location = location
            };
            return View("Details",viewModel);
        }
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                MembershipType = membershipTypes
            };
            return View("BuyerForm",viewModel);
        }
        //public ActionResult location()
        //{
        //    var location = _context.Locations.ToList();
        //    var viewModel = new CustomerFormViewModel
        //    {
        //        Location =location 
        //    };
        //    return View(viewModel);
        //}
        // GET: Buyer/Create
        [HttpPost]
        public ActionResult Save(CustomerFormViewModel c)
        {
            //[Bind(Include="Id,address,city,zipcode,phone,email")]Location location
            //PopulateMembershipTypes();
             
            
            if  (!ModelState.IsValid)
            {
                 var buyer=_context.Buyers.SingleOrDefault(d=>d.BuyerId==c.Buyer.BuyerId);
            var location = _context.Locations.SingleOrDefault(d=>d.id==c.Location.id);
            var viewModel = new CustomerFormViewModel
            {
                Buyer = buyer,
                MembershipType = _context.MembershipTypes.ToList(),
                Location = location
            };
            return View("BuyerForm", viewModel);
            }
            var b=new Buyer()
                { 
                    FName=c.Buyer.FName,
                    LName = c.Buyer.LName,
                    MName = c.Buyer.MName,
                    MembershipTypeId = c.Buyer.MembershipTypeId,
                    Verified = c.Buyer.Verified
                };
            var l = new Location();
            using (var _context = new ApplicationDbContext())
            {
                _context.Buyers.Add(b);
                l.id=b.LocationId;
                _context.Locations.Add(l);
                _context.SaveChanges();
            }
                //var buyers = _context.Buyers.Join(_context.Locations, d => d.LocationId, o => o.id, (d, o) => new {c.Location,c.Buyer }).AsEnumerable(); 
            //var  viewModel =  from l in _context.Locations
            //                join b in _context.Buyers
            //                on l.id equals (b.LocationId)
            //                select new CustomerFormViewModel {Buyer=c.Buyer,Location=c.Location };
                //foreach (var v in buyers)
                //{
                //    v.Buyer.FName = c.Buyer.FName;
                //    v.Buyer.MName = c.Buyer.MName;
                //    v.Buyer.LName = c.Buyer.LName;
                //    v.Buyer.MembershipTypeId = c.Buyer.MembershipTypeId;
                //    v.Buyer.Verified = c.Buyer.Verified;
                //    v.Location.address = c.Location.address;
                //    v.Location.city = c.Location.city;
                //    v.Location.email = c.Location.email;
                //    v.Location.phone = c.Location.phone;
                //    v.Location.zipcode = c.Location.zipcode;

                //}
            
            //var buyersLocationInDb=_context.Locations.Single(c=>c.id==location)
                //TryUpdateModel(buyersInDb);
                //Mapper.Map(customer, customerInDb)

                //buyers.MName = buyer.MName;
                //buyersInDb.LName = buyer.LName;
                //buyersInDb.MembershipTypeId = buyer.MembershipTypeId;
                //buyersInDb.Verified = buyer.Verified;
                //buyersInDb.Location.zipcode = buyer.Location.zipcode;
                //buyersInDb.Location.email = buyer.Location.email;
                //buyersInDb.Location.phone = buyer.Location.phone;
                //buyersInDb.Location.address = buyer.Location.address;
                //buyersInDb.Location.city = buyer.Location.city;
               // buyersInDb.Location..address = buyer.Location.address;

                //buyersInDb.FName = buyer.FName;

            
            
            return RedirectToAction("Index","Buyer");
        }

        public ActionResult Action()
        {
            return View();
        }

        // POST: Buyer/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Buyer/Edit/5
        public ActionResult Edit(int id)
        {
            var location = _context.Locations.SingleOrDefault(c => c.id == id);
            var buyer=_context.Buyers.SingleOrDefault(c=>c.BuyerId==id);
            if (buyer==null)
            {
                return HttpNotFound();
            }
            var viewModel = new CustomerFormViewModel
            {
                Buyer = buyer,
                MembershipType = _context.MembershipTypes.ToList(),
                Location = location
            };
            return View("BuyerForm",viewModel);
        }

        // POST: Buyer/Edit/5
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

        // GET: Buyer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buyer/Delete/5
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

        private void PopulateMembershipTypes(object selectMembershipType=null)
        {
            var membershipQuery = from d in _context.MembershipTypes
                                  orderby d.Name
                                  select d;
            ViewBag.MembershipId = new SelectList(membershipQuery, "Id", "Name", selectMembershipType);
        }
    }
}
