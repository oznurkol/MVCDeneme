using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosedeDursun.Entities
{
    [Table("Comment")]
    public class Comment:EntitiyBase
    {
        [Required, StringLength(30)]
        public string Name { get; set; }
        [Required, StringLength(30)]
        public string Surname { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
        public bool isConfirmation { get; set; }
        [Required, StringLength(30)]
        public string IPAdress { get; set; }
        [Required, StringLength(2000)]
        public string Text { get; set; }
        public virtual Article Article { get; set; }
        public virtual List<CommentReply> Replys { get; set; }

        
    }
}
