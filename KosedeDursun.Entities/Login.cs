using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosedeDursun.Entities
{
    public class Login
    {
        [Required(ErrorMessage ="Kullanıcı adı zorunludur."), StringLength(30, ErrorMessage ="Maximum 30 karakter olabilir.")]
        public string username { get; set; }
        [Required(ErrorMessage = "Şifre zorunludur."), StringLength(30, ErrorMessage = "Maximum 30 karakter olabilir.")]
        public string password { get; set; }
    }
}
