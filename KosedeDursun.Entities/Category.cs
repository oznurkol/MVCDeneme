using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosedeDursun.Entities
{
    [Table("Category")]
    public class Category: EntitiyBase //Varsayılan internal o yüzden public
    {                     //internal:aynı namespace erişebilir ama kalıtımda erişeme
        [Required, StringLength(30)]
        public string Title { get; set; }
        [Required, StringLength(2000)]
        public string Description { get; set; }
        public virtual List<Article> Articles { get; set; }

        public Category()
        {
            Articles = new List<Article>();
        }
    }
}
