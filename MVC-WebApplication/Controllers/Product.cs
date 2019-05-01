using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_MVC.DAL;
using WebApplication_MVC.Models;

namespace WebApplication_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDBContext db;
        public ProductController()
        {
            db = new ProductDBContext();
        }
        public ActionResult Index()
        {
            var list = new List<Product>();
            list = db.Product.ToList();
            return View(list);
        }
        public ActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product entity)
        {
            if (!ModelState.IsValid)
            {
                
            }
            if(entity.BrandName==null)
            {
                ViewBag.Message = "Please Enter Brand Name";
                return View(entity);
            }
            if (entity.ModelNo == null)
            {
                ViewBag.Message = "Please Enter Model Number";
                return View(entity);
            }
            db.Product.Add(entity);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       [HttpGet]
       public ActionResult Edit(int Id)
       {
            var entity = db.Product.Find(Id);
            if(entity==null)
            {
                ViewBag.Message = "Not Found";
                return RedirectToAction("Index");
            }
            return View(entity);
       }
        [HttpPost]
        public ActionResult Edit(Product entity)
        {


            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int code)
        {
            var entity = db.Product.FirstOrDefault(x => x.Id == code);

            if (entity == null)
            {
                ViewBag.Message = "Not Found.";
                return RedirectToAction("Index");
            }

            db.Product.Remove(entity);
            db.SaveChanges();

            return RedirectToAction("Index");

        }


    }
}