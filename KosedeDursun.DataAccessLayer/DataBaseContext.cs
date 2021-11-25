using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KosedeDursun.Entities;

namespace KosedeDursun.DataAccessLayer
{
    public class DataBaseContext: DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentReply> CommentReplies { get; set; }

        public DataBaseContext()
        {
            Database.SetInitializer(new DataAccessLayer.Initilizer());
        }

    }
}
