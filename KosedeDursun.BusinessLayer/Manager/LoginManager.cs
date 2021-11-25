using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KosedeDursun.Entities;

namespace KosedeDursun.BusinessLayer.Manager
{
    public class LoginManager
    {
        public List<string> ErrorMessege { get; set; }
        public Login User { get; set; }

        private LoginManager()
        {
            ErrorMessege = new List<string>();
        }
    }
}
