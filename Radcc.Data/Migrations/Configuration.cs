namespace Radcc.Data.Migrations
{
    using Context;
    using Model;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Radcc.Data.Context.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {

            context.Programmes.AddOrUpdate(e => e.Id,
               new Programme { Id = 1, Title = "Show and Tell", EventDate = new DateTime(2015, 9, 1, 20, 00, 0), Description = "Photos taken over the summer", Comment = "" },
               new Programme { Id = 2, Title = "Practical Evening", EventDate = new DateTime(2015, 9, 15, 20, 00, 0), Description = "Water Drop Photography", Comment = "Bring along your camera, tripod and flash gun" },
               new Programme { Id = 3, Title = "CD Presentation", EventDate = new DateTime(2015, 10, 6, 20, 00, 0), Description = "The Rushden Open Competition", Comment = "" },
               new Programme { Id = 4, Title = "Practical Evening", EventDate = new DateTime(2015, 10, 20, 20, 00, 0), Description = "More Photoshop by John Heppell", Comment = "" },
               new Programme { Id = 5, Title = "Practical Evening", EventDate = new DateTime(2015, 11, 3, 20, 00, 0), Description = "Monochrome Photography", Comment = "" },
               new Programme { Id = 6, Title = "Our Kruger Odyssey", EventDate = new DateTime(2015, 11, 17, 20, 00, 0), Description = "A talk by John Nash and Stuart Boyd", Comment = "" },
               new Programme { Id = 7, Title = "Competition", EventDate = new DateTime(2015, 12, 1, 20, 00, 0), Description = "Subject - Monochrome", Comment = "Judge : Derek Doar DPAGB" },
               new Programme { Id = 8, Title = "Christmas Party", EventDate = new DateTime(2015, 12, 15, 20, 00, 0), Description = "Social and Nibbles", Comment = "" },
               new Programme { Id = 9, Title = "Competition Feedback", EventDate = new DateTime(2016, 1, 5, 20, 00, 0), Description = "Analysis and reflection", Comment = "" },
               new Programme { Id = 10, Title = "Landscapes (GB v NZ)", EventDate = new DateTime(2016, 1, 19, 20, 00, 0), Description = "A talk by David Slade DPAGB", Comment = "" },
               new Programme { Id = 11, Title = "Member Evening", EventDate = new DateTime(2016, 2, 2, 20, 00, 0), Description = "Each member will have an opportunity to talk about a personal photographic topic or issue", Comment = "" },
               new Programme { Id = 12, Title = "Competition", EventDate = new DateTime(2016, 2, 16, 20, 00, 0), Description = "Subject: Open", Comment = "Judge: Alan Fernihough" },
               new Programme { Id = 13, Title = "Travel Photography", EventDate = new DateTime(2016, 3, 1, 20, 00, 0), Description = "A talk by Alan Hartley ARPS", Comment = "" },
               new Programme { Id = 14, Title = "Member Evening", EventDate = new DateTime(2016, 3, 15, 20, 00, 0), Description = "Opportunity for Members to talk about a personal photographic topic or issue", Comment = "10 - 15 mins each member" },
               new Programme { Id = 15, Title = "Taking Motion Photographs", EventDate = new DateTime(2016, 4, 5, 20, 00, 0), Description = "Techniques explained and demonstrated", Comment = "" },
               new Programme { Id = 16, Title = "Competition", EventDate = new DateTime(2016, 4, 19, 20, 00, 0), Description = "Subject: Natural History", Comment = "JUdge: T.B.A" },
               new Programme { Id = 17, Title = "The Seeing Eye", EventDate = new DateTime(2016, 5, 3, 20, 00, 0), Description = "Talk by Irene Froy EFIAP MPAGB HonPAGB BPE4", Comment = "This is going to be our biggest event of the year, please let us know in advance of your attendance" },
               new Programme { Id = 18, Title = "Annual General Meeting", EventDate = new DateTime(2016, 5, 17, 20, 00, 0), Description = "Nominations for committee member elections to be submitted by the previous meeting", Comment = "" },
               new Programme { Id = 19, Title = "Show and Tell", EventDate = new DateTime(2016, 9, 6, 20, 00, 0), Description = "Photos taken over the summer", Comment = "" },
               new Programme { Id = 20, Title = "Practical Evening", EventDate = new DateTime(2016, 9, 20, 20, 00, 0), Description = "Table Top Photography", Comment = "Bring along your camera, tripod and flash gun" },
               new Programme { Id = 21, Title = "Guidelines to Club Judging", EventDate = new DateTime(2016, 10, 4, 20, 00, 0), Description = "A Talk by David Gibbins", Comment = "" },
               new Programme { Id = 22, Title = "Demo and Practical Evening", EventDate = new DateTime(2016, 10, 18, 20, 00, 0), Description = "Retouching Old Photographs by  John Nash", Comment = "Bring along your laptops with photo editing software to follow up on Johns demonstration." },
               new Programme { Id = 23, Title = "Lightroom", EventDate = new DateTime(2016, 11, 1, 20, 00, 0), Description = "Filing, Raw Editing and Monochrome by Jon Heppell", Comment = "" },
               new Programme { Id = 24, Title = "Competition", EventDate = new DateTime(2016, 11, 15, 20, 00, 0), Description = "Subject-Theme: Action Photography", Comment = "Judge: TBA" },
               new Programme { Id = 25, Title = "Peak District Photography", EventDate = new DateTime(2016, 12, 6, 20, 00, 0), Description = "Talk and Images by Tony Piolli", Comment = "" },
               new Programme { Id = 26, Title = "Christmas Party", EventDate = new DateTime(2016, 12, 20, 20, 00, 0), Description = "Social and Nibbles", Comment = "Venue to be confirmed" },
               new Programme { Id = 27, Title = "Competition Feedback", EventDate = new DateTime(2017, 1, 3, 20, 00, 0), Description = "Analysis and reflection", Comment = "" },
               new Programme { Id = 28, Title = "Creative Photography", EventDate = new DateTime(2017, 1, 17, 20, 00, 0), Description = "A talk by Tony Winfield", Comment = "" },
               new Programme { Id = 29, Title = "Demo and Practical", EventDate = new DateTime(2017, 2, 7, 20, 00, 0), Description = "Layers in Photoshop by John Heppell", Comment = "" },
               new Programme { Id = 30, Title = "Competition", EventDate = new DateTime(2017, 2, 21, 20, 00, 0), Description = "Subject-Theme: Open Competiton and must have been taken in 2016", Comment = "Judge: TBA" },
               new Programme { Id = 31, Title = "Black and White Photography", EventDate = new DateTime(2017, 3, 7, 20, 00, 0), Description = "with Clive Rowley", Comment = "" },
               new Programme { Id = 32, Title = "Irene Froy DVD Presentation", EventDate = new DateTime(2016, 3, 21, 20, 00, 0), Description = "A Paaaion for Pastels", Comment = "" },
               new Programme { Id = 33, Title = "Competition", EventDate = new DateTime(2017, 4, 4, 20, 00, 0), Description = "Subject-Theme: Altered Reality", Comment = "Judge: Tony Winfield" },
               new Programme { Id = 34, Title = "Creating A/V's in Photoshop", EventDate = new DateTime(2017, 4, 18, 20, 00, 0), Description = "Presentation and Demonstration by Paul Redshaw ", Comment = "" },
               new Programme { Id = 35, Title = "Outdoor Practical Evening", EventDate = new DateTime(2017, 5, 2, 20, 00, 0), Description = "A walk around JCB lake with an emphasis on Macro photography ", Comment = "Meet at Rocester Village Hall" },
               new Programme { Id = 36, Title = "Outdoor Practical Evening", EventDate = new DateTime(2017, 5, 16, 20, 00, 0), Description = "Nature Photography at Wolseley Nature Reserve - Stuart Boyd", Comment = "" },
               new Programme { Id = 37, Title = "Annual general Meeting", EventDate = new DateTime(2017, 5, 23, 20, 00, 0), Description = "Nominations for committee member elections to be submitted by the previous meeting", Comment = "" },
               new Programme { Id = 38, Title = "Show and Tell", EventDate = new DateTime(2017, 9, 5, 20, 00, 0), Description = "Photographs taken over the summer", Comment = "" }
               );
            context.SaveChanges();
            context.UsefulLinks.AddOrUpdate(e => e.Id,
                new UsefulLink { Id = 1, Name = "Midland Counties Photographic Federation", URL = "http://www.mcpf.co.uk/", Description = "MCPF" },
                new UsefulLink { Id = 2, Name = "Photographic Alliance of Great Britain", URL = "http://www.thepagb.org.uk/", Description = "PAGB" },
                new UsefulLink { Id = 3, Name = "Royal Photographic Society", URL = "http://www.rps.org/", Description = "RPS" },
                new UsefulLink { Id = 4, Name = "Adobe TV", URL = "http://tv.adobe.com/", Description = "Online Tutorials for Photoshop and LIghtroom" }
                );
            context.SaveChanges();
            context.NewsArticles.AddOrUpdate(e => e.Id,
               new NewsArticle
               {
                   Id = 1,
                   ArticleHeading = "New Website is now live",
                   article = "The new website is now up and running. although only the basic information is available to the same level as the previous website, However new areas for members and photo galleries will be available soon",
                   DatePosted = new DateTime(2017, 02, 10)
               }

               );

        }
    }
}
