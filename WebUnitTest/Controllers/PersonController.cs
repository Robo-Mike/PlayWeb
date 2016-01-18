using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using WebUnitTest.Models;
using WebUnitTest.Repository;

namespace WebUnitTest.Controllers
{
    

    public class PersonController : Controller
    {
        private IPersonBuilderPersonRepository _repository;


        public PersonController(IPersonBuilderPersonRepository repository)
        {
            _repository = repository;
        }

        public PersonController()
        {
            _repository = new PersonBuilderPersonRepository();
        }
        //
        // GET: /Person/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Person/Details/5

        public ActionResult Details(int id)
        {
            PersonModel model = _repository.Get(id);
            return View("Details", model);
        }

        //
        // GET: /Person/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Person/Create

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

        //
        // GET: /Person/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Person/Edit/5

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

        //
        // GET: /Person/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Person/Delete/5

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
