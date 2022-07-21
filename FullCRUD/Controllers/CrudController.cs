using FullCRUD.DBContext;
using FullCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullCRUD.Controllers
{
    public class CrudController : Controller
    {
        private readonly DataContext _dbContext;
        public CrudController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: CrudController1
        public ActionResult ViewList()
        {
            var crudmodel = _dbContext.CrudModel.ToList();
            
            return View(crudmodel);
        }

        // GET: CrudController1/Details/5
        public ActionResult Details(int id)
        {
           var detail= _dbContext.CrudModel.Find(id);
              ViewBag.HostingRenwalDate = Convert.ToDateTime(detail.HostingRenwalDate).ToString("dd/MM/yyyy");
                ViewBag.DomainRenewalDate = Convert.ToDateTime(detail.DomainRenewalDate).ToString("dd/MM/yyyy");
                ViewBag.AMCRenewalDate = Convert.ToDateTime(detail.AMCRenewalDate).ToString("dd/MM/yyyy");
                ViewBag.SEORenewalDate = Convert.ToDateTime(detail.SEORenewalDate).ToString("dd/MM/yyyy");
            
            return View(detail);
        }

        // GET: CrudController1/Create
        public ActionResult CreateCrud()
        {
            return View();
        }

        // POST: CrudController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCrudPost(CrudModel collection)
        {
            try
            {
                _dbContext.CrudModel.Add(collection);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(ViewList));
            }
            catch
            {
                return View();
            }
        }

        // GET: CrudController1/Edit/5
        public ActionResult Edit(int id)
        {
            
            var list = _dbContext.CrudModel.Find(id);
          //  list.HostingRenwalDate = Convert.ToDateTime(list.HostingRenwalDate).ToString("dd/mm/yyyy");
            return View(list);
        }

        // POST: CrudController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CrudModel model)
        {
            try
            {
                 _dbContext.CrudModel.Update(model);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(ViewList));
            }
            catch
            {
                return View();
            }
        }

      
        // POST: CrudController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,CrudModel crud)
        {
            try
            {
                _dbContext.CrudModel.Remove(crud);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(ViewList));
            }
            catch
            {
                return View();
            }
        }

    }
}
