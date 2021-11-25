using KosedeDursunDBFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosedeDursun.DataAccessLayer
{
    class RepositoryBase
    {
        private KosedeDursunEntities context;
        public RepositoryBase()
        {
            if (context == null)
                context = new KosedeDursunEntities();
        }
    }
}
