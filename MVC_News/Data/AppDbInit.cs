using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MVC_News.Models;

namespace MVC_News.Data
{
    public static class AppDbInit
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<NewsContext>();

                if(context is null)
                {
                    throw new Exception();
                }
                context.Database.EnsureCreated();

                //News
                if(!context.News.Any())
                {
                    context.News.AddRange(new List<New>()
                    {
                        new New
                        {
                            Title= "Title1",
                            Subtitle= "Subtitle1",
                            Description= "Description1",
                            NewPictureURL = "https://ouch-cdn2.icons8.com/VZ0cVizYAmY76vIFJJUlX8KFs4LP1ZmtozfNAGdnJ1g/rs:fit:256:237/czM6Ly9pY29uczgu/b3VjaC1wcm9kLmFz/c2V0cy9wbmcvMjIv/ODg3ZmNiMDItNWRk/NC00ZmQ5LWExOWYt/MzNjNDA1NTYyNGNi/LnBuZw.png",
                            CreateDate= DateTime.MinValue,
                        },

                        new New
                        {
                            Title= "Title2",
                            Subtitle= "Subtitle2",
                            Description= "Description2",
                            NewPictureURL = "https://ouch-cdn2.icons8.com/FLxcYK0EgIyTpjAaRqyplxvFuJ9hNa7xoR5jgVcczeY/rs:fit:256:250/czM6Ly9pY29uczgu/b3VjaC1wcm9kLmFz/c2V0cy9wbmcvODgx/LzFhYWE2Y2ZiLTI4/ZmMtNDBjZS05NzM1/LTQzNmI1MmNjOTU1/ZS5wbmc.png",
                            CreateDate= DateTime.MinValue,
                        },

                        new New
                        {
                            Title= "Title3",
                            Subtitle= "Subtitle3",
                            Description= "Description3",
                            NewPictureURL = "https://ouch-cdn2.icons8.com/VebZmsYmh6HtXp2dNp_5N4ev--Ydc2sPbPo7Pnnl250/rs:fit:256:296/czM6Ly9pY29uczgu/b3VjaC1wcm9kLmFz/c2V0cy9wbmcvNTEw/L2Y0MjFkZDAxLWQw/NzItNGMzOS05MmNi/LWE0YmVlZTQ5ODBh/My5wbmc.png",
                            CreateDate= DateTime.MinValue,
                        },

                        new New
                        {   
                            Title= "Title4",
                            Subtitle= "Subtitle4",
                            Description= "Description4",
                            NewPictureURL = "https://ouch-cdn2.icons8.com/R6zYUfbUjbgJ8nulg71sBnGBUkHcYLFE54cTvO4rJV4/rs:fit:256:288/czM6Ly9pY29uczgu/b3VjaC1wcm9kLmFz/c2V0cy9wbmcvNjcx/LzMyODIzZjY0LTg0/ZDEtNDE4MS05ZDRl/LWNiMDZlY2FlMzM0/Zi5wbmc.png",
                            CreateDate= DateTime.MinValue,
                        },

                        new New
                        {
                            Title= "Title5",
                            Subtitle= "Subtitle5",
                            Description= "Description5",
                            NewPictureURL = "https://ouch-cdn2.icons8.com/dsLO87PtdlvUlsDmuxMtCKF-sEzMkzzyo5iVqNDuaN8/rs:fit:256:228/czM6Ly9pY29uczgu/b3VjaC1wcm9kLmFz/c2V0cy9wbmcvMTI5/LzNjNmExMDU5LTNm/MTEtNDJiNS1iOWQ4/LTdiNjAwOTc3OWFm/OS5wbmc.png",
                            CreateDate= DateTime.MinValue,
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
