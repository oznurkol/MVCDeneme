using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosedeDursun.Entities
{
    [Table("Article")]
    public class Article:EntitiyBase
    {
        [Required, StringLength(160)]
        public string Title { get; set; }
        [Required, MaxLength]
        public string Text { get; set; }

        public bool isDraft { get; set; }
        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
        public virtual List<Comment> Comments { get; set; }

        public Article()
        {
            Comments = new List<Comment>();
        }
    }
}
