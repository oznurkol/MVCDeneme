using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosedeDursun.Entities
{
    [Table("Author")]
    public class Author:EntitiyBase
    {
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Surname { get; set; }
        [Required, StringLength(30)]
        public string Username { get; set; }
        [Required, StringLength(50)]
        public string Password { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
        public bool isAdmin { get; set; }
        public bool isActive { get; set; }
        public bool isBlock { get; set; }
        public Guid ActiveGuid { get; set; }
        
        public virtual List<Article> Articles { get; set; }
        public virtual List<CommentReply> CommentReplys { get; set; }
    }
}
