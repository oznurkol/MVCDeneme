using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KosedeDursun.DataAccessLayer;

namespace KosedeDursun.BusinessLayer
{
    public static class RepositoryBasex //singleton repository
    {
        private static DataBaseContext _db;
        public static DataBaseContext CreateContext()
        {
            if (_db == null)
            {
                _db = new DataBaseContext();
            }
            return _db;
        }
    }
}
