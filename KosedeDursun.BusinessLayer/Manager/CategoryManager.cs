using KosedeDursun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosedeDursun.BusinessLayer.Manager
{
    public class CategoryManager
    {
        Repository<Category> cate = new Repository<Category>();
        public List<Category> GetCategories()
        {
            return cate.List();
        }

        public Category GetCategory(int id)
        {
            Repository<Category> cate = new Repository<Category>();
            return cate.Find(x => x.Id == id);
        }

    }
}
