using KosedeDursun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KosedeDursun.DataAccessLayer;

namespace KosedeDursun.BusinessLayer.Managers
{
    public class ArticleRepo
    {
        Repository<Article> _article = new Repository<Article>(); 

        public List<Article> getAll()
        {
            return _article.List();
        }

        public Article getArticle(int? id)
        {
            return _article.Find(x => x.Id == id.Value);
        }

        public int SaveArticle(Article newArticle)
        {
            return _article.Insert(newArticle);
        }

        public int updateArticle()
        {
            return _article.Update();
        }
    }
}
