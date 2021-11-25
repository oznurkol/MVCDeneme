using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using KosedeDursun.Entities;
using KosedeDursun.BusinessLayer.Manager;

namespace KosedeDursun.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? id)
        {
            //if (TempData["articles"] != null)
            //{
            //    return View(TempData["articles"] as List<Article>);
            //}
            ArticleManager articleManager = new ArticleManager();
            if (id == null || id <= 0)
                return View(articleManager.GetArticlePage(0));
            else
            {
                List<Article> article = articleManager.GetArticlePage(id.Value);
                if (article.Count == 0)
                    return HttpNotFound();
                return View(article);
            }
        }

        public ActionResult Article(int? id)
        {
            if (id == null)
                return HttpNotFound();
            ArticleManager article = new ArticleManager();
            Article art = article.GetArticle(id.Value);
            if (art == null)
                return HttpNotFound();
            return View(art);
        }

        public ActionResult Category(int? id)
        {
            if (id == null)
                return HttpNotFound();
            CategoryManager cm = new CategoryManager();
            Category cate = cm.GetCategory(id.Value);
            if (cate == null)
                return HttpNotFound();
            return View(cate.Articles.ToList());
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login login)
        {
            
            
            return View();
        }
    }
}