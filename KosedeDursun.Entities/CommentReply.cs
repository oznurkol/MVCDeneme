using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosedeDursun.Entities
{
    [Table("CommentReply")]
    public class CommentReply:EntitiyBase
    {
        public virtual Author ReplyAuthor { get; set; }
        [Required, StringLength(2000)]
        public string Text { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
