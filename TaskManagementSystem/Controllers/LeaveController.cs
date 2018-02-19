using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMS.DataAccessLayer;
using TaskManagementSystem.Models.CustomClass;

namespace TaskManagementSystem.Controllers
{
    public class LeaveController : Controller
    {
        // GET: Leave
        public ActionResult Index()
        {
            return View();
        }

        // GET: Leave/Details/5
        public ActionResult Details(int id)
        {
            
            return View();
        }

        // GET: Leave/Create
        public ActionResult Create()
        {
            return View();
        }
      
        [HttpPost]
        [ActionName("ClearData")]
        public ActionResult ClearData(LeaveModel model)
        {
            return View();
        }
        // POST: Leave/Create
        [HttpPost]
        [ActionName("SaveData")]
        public ActionResult Create(LeaveModel model)
        {
            try
            {                
                TestDAL d = new TestDAL();
                
                if(ModelState.IsValid)
                {
                    return RedirectToAction("Index","Home");
                }
                // TODO: Add insert logic here
                return View("ViewTestModel");
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Leave/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Leave/Edit/5
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

        // GET: Leave/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Leave/Delete/5
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
