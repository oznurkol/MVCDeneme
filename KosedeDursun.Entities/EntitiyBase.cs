using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosedeDursun.Entities
{
    public class EntitiyBase
    {
        internal EntitiyBase()
        {
            CreatedOn = DateTime.Now;
            ModifedOn = DateTime.Now;
            CreatedAuthor = "CONSTRUCTOR";
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public DateTime ModifedOn { get; set; }
        [Required, StringLength(30)]
        public string CreatedAuthor { get; set; }
    }
}
