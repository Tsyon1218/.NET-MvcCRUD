using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCRUD.Models;

namespace MVCCRUD.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student/Index
        public ActionResult Index()
        {
            using (DBModels dbModel = new DBModels())
            {
                return View(dbModel.Student.ToList());
            }
            
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {

            using (DBModels dbModel = new DBModels())
            {
                return View(dbModel.Student.FirstOrDefault());
            }
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                using (DBModels dbModel = new DBModels() )
                {
                    dbModel.Student.Add(student);
                    dbModel.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            { 
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModels dbModel = new DBModels())
            {
                return View(dbModel.Student.FirstOrDefault());
            }
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                using (DBModels dbModel = new DBModels())
                {
                    dbModel.Entry(student).State = System.Data.Entity.EntityState.Modified;
                    dbModel.SaveChange();

                }
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModels dbModel = new DBModels())
            {
                return View(dbModel.Student.FirstOrDefault());
            }
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBModels dbModel = new DBModels())
                {
                    Student student = dbModel.Student.Where(x => x.Id = id).FirstOrDefault();
                    dbModel.Student.Remove(student);
                    dbModel.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
