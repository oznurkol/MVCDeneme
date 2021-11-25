using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KosedeDursun.BusinessLayer.Manager;
using System.Net;
using KosedeDursun.Entities;

namespace KosedeDursun.MVC.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Select(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryManager cm = new CategoryManager();
            Category cate = cm.GetCategory(id.Value);
            if (cate == null)
            {
                return HttpNotFound();
            }
            TempData["articles"] = cate.Articles;
            return RedirectToAction("Index", "Home");
            //return View();
        }
    }
}