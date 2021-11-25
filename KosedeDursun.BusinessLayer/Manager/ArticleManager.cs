using KosedeDursun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosedeDursun.BusinessLayer.Manager
{
    public class ArticleManager
    {
        Repository<Article> article = new Repository<Article>();

        public List<Article> GetCategoryArticle(Category category)
        {
            return article.List(x => x.Category == category);
        }

        public List<Article> GetAllArticle()
        {
            return article.List();
        }

        public List<Article> GetArticlePage(int? alt=0)
        {
            return article.OrderByLimitList(x => x.Id, true, 5, alt.Value);
        }

        public Article GetArticle(int  get)
        {
            Article search=article.Find(x => x.Id == get);
            return search;
        }
    }
}
