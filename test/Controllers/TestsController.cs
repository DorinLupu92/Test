using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class TestsController : Controller
    {
        private ModelDB db = new ModelDB();

        // GET: Tests
        public ActionResult Index()
        {
            return View(db.Tests.ToList());
        }

       

        // GET: Tests/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Test test)
        {
            if (ModelState.IsValid)
            {
                db.Tests.Add(test);
                db.SaveChanges();

                test.File.SaveAs(Server.MapPath("~/PDF/") + test.ID + ".pdf");


                return RedirectToAction("Index");
            }

            return View(test);
        }

        // GET: Tests/Edit/5
      

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
