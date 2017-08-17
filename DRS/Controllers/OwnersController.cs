using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DRS.Models;

namespace DRS.Controllers
{
    public class OwnersController : Controller
    {

        IList<Owner> ownerList = new List<Owner>()
        {
            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },
                        new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" },            new Owner() { owner_id=1,owner_firstname="Malindu",owner_middlename="Dilshan",owner_nic="961953030v",owner_address="394/c Gunasekara Rd, Heiyanthuduwa",owner_tele="0112401389"},
            new Owner() { owner_id=2,owner_firstname="Gayan",owner_middlename="Lakmal",owner_nic="881957830v",owner_address="121/A Pansala Rd, Gampaha",owner_tele="0112460578" }
        };

        // GET: Owners
        public ActionResult Index()
        {
            return View(ownerList);
        }

        // GET: Owners/Create
        public ActionResult Create()
        {
            var owner = new Owner();
            return View(owner);
        }

        // POST: Owners/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Owner owner)
        {
            if (ModelState.IsValid)
            {
                //db methods
                return RedirectToAction("Index");
            }
            return View(owner);
        }

        // GET: Owners/Edit?id=1
        public ActionResult Edit()
        {
            var id = Request.QueryString["id"];
            //db retrive data
            //get owner object and pass it to view
            var owner = ownerList.Where(s => s.owner_id.Equals(id)).FirstOrDefault();
            return View(owner);
        }

        // POST: Owners/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Owner owner)
        {
            //db update owner
            return RedirectToAction("Index");
        }

        // GTE: Owners/Delete?id=1
        public ActionResult Delete()
        {
            var id = Request.QueryString["id"];
            //db retrive data
            //get owner object and pass it to view
            var owner = ownerList.Where(s => s.owner_id.Equals(id)).FirstOrDefault();
            return View(owner);
        }

        // POST: Owners/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Owner owner)
        {
            //db delete owner
            return RedirectToAction("Index");
        }

        // GTE: Owners/Details?id=1
        public ActionResult Details()
        {
            var id = Request.QueryString["id"];
            //retrive owner data from db
            var owner = ownerList.Where(s => s.owner_id.Equals(id)).FirstOrDefault();
            return View(owner);
        }
    }
}