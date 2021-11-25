using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KosedeDursun.Entities;

namespace KosedeDursun.DataAccessLayer
{
    class Initilizer: CreateDatabaseIfNotExists<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            Author authorAdmin = new Author()
            {
                Name = "Öznur",
                Surname="Kol",
                Email="oznurrkol@gmail.com",
                ActiveGuid=Guid.NewGuid(),
                isActive=true,
                isAdmin=true,
                isBlock=false,
                Username="kolo",
                Password="123123",
                CreatedOn=DateTime.Now,
                ModifedOn=DateTime.Now,
                CreatedAuthor="ADMIN"
            };
            context.Authors.Add(authorAdmin);
            context.SaveChanges();
            
            for(int i = 0; i < 10; i++)
            {
                Category category = new Category() {
                    Title = FakeData.PlaceData.GetStreetName(),
                    Description=FakeData.PlaceData.GetAddress(),
                    CreatedOn=DateTime.Now,
                    ModifedOn=DateTime.Now,
                    CreatedAuthor= authorAdmin.Username
                };
                context.Categories.Add(category);
                for (int x = 0; x < FakeData.NumberData.GetNumber(2, 5); x++)
                {
                    Article article = new Article()
                    {
                        Title = FakeData.TextData.GetAlphabetical(FakeData.NumberData.GetNumber(5, 25)),
                        Text = FakeData.TextData.GetSentences(FakeData.NumberData.GetNumber(1, 3)),
                        isDraft = false,
                        Category=category,
                        Author=authorAdmin,
                        CreatedOn=DateTime.Now,
                        ModifedOn=DateTime.Now,
                        CreatedAuthor=authorAdmin.Username
                    };
                    category.Articles.Add(article);
                    for (int k=0; k < FakeData.NumberData.GetNumber(1, 3); k++)
                    {
                        Comment comment = new Comment()
                        {
                            Name = FakeData.NameData.GetFirstName(),
                            Surname=FakeData.NameData.GetSurname(),
                            Email=FakeData.NetworkData.GetEmail(),
                            isConfirmation=true,
                            IPAdress=FakeData.NetworkData.GetIpAddress(),
                            Text=FakeData.TextData.GetSentence(),
                            CreatedOn = DateTime.Now,
                            ModifedOn = DateTime.Now,
                            CreatedAuthor = authorAdmin.Username
                        };
                        article.Comments.Add(comment);
                        for (int j = 0; j < FakeData.NumberData.GetNumber(1, 3); j++)
                        {
                            CommentReply reply = new CommentReply()
                            {
                                ReplyAuthor = authorAdmin,
                                Text = FakeData.TextData.GetSentences(2),
                                Comment = comment,
                                CreatedOn = DateTime.Now,
                                ModifedOn = DateTime.Now,
                                CreatedAuthor = authorAdmin.Username
                            };
                            context.CommentReplies.Add(reply);
                        }
                       
                    }
                    
                }
                
            }
            context.SaveChanges();

            

        }
    }
}
