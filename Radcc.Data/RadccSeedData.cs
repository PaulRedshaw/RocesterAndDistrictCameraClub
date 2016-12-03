using Radcc.Data.Context;
using Radcc.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Radcc.Data
{
    public class RadccSeedData : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            GetEvents().ForEach(e => context.Programmes.Add(e));
        }
      
        private static List<Programme> GetEvents()
        {
            return new List<Programme>
            {
                new Programme { Id = 1, Title="Show and Tell", Description="Photos taken over the summer", Comment ="", EventDate=new DateTime(2016, 09, 06, 20, 00, 00) },
                new Programme { Id = 2, Title="Practical Evening", Description="Table Top Photography", Comment ="Bring your camera, Tripod, Flashgun and something to photograph. There will be equipment and accessories to borrow and try on the night", EventDate=new DateTime(2016, 09, 20, 20, 00, 00) },
                new Programme { Id = 3, Title="Guidelines to Club Judging", Description="A talk by David Gibbins", Comment ="", EventDate=new DateTime(2016, 10, 04, 20, 00, 00) },
                new Programme { Id = 4, Title="Retouching old photographs", Description="Demonstration and practical by John Nash", Comment ="Bring along your laptops and any old photgraphs, you will get the oportunity to try some of the demonstrated techniques.", EventDate=new DateTime(2016, 10, 18, 20, 00, 00) },
                new Programme { Id = 5, Title="Lightroom: Filing,Raw editing and monochrome", Description="Demonstration led by John Heppell", Comment ="", EventDate=new DateTime(2016, 11, 01, 20, 00, 00) },
                new Programme { Id = 6, Title="Competition: Theme - Motion in photography", Description="Judge: Ralph Duckett", Comment ="Both PDI images and Prints need to be submitted at least 1 week before tonight.", EventDate=new DateTime(2016, 11, 15, 20, 00, 00) },
                new Programme { Id = 7, Title="Peak District Photography", Description="A talk by Tony Pioli", Comment ="We welcome back Tony Pioli for what will be a very interesting talk", EventDate=new DateTime(2016, 12, 06, 20, 00, 00) },
                new Programme { Id = 8, Title="Christmas Social Event", Description="A chance for members to relax and enjoy the festive season", Comment ="", EventDate=new DateTime(2016, 12, 20, 20, 00, 00) },
                new Programme { Id = 9, Title="Competition feedback and analysis", Description="A chance to discuss and look at some of the images from our first competition in the current years programme", Comment ="", EventDate=new DateTime(2017, 01, 03, 20, 00, 00) },
                new Programme { Id = 10, Title="Creative photography", Description="A talk by Tony Winfield ", Comment ="Tony returns to give us another talk on this what some see as a contraversial topic.", EventDate=new DateTime(2017, 01, 17, 20, 00, 00) },
                new Programme { Id = 11, Title="Layers in Photoshop", Description="Demonstration and practical by John Heppell", Comment ="John covers this essential skill when working in photoshop ", EventDate=new DateTime(2017, 02, 07, 20, 00, 00) },
                new Programme { Id = 12, Title="Competition: Theme - Open", Description="Judge: Peter Cheetham", Comment ="Although this is an open themed competition The photographs must have been taken in 2016 ", EventDate=new DateTime(2017, 02, 21, 20, 00, 00) },
                new Programme { Id = 13, Title="Members Evening", Description="A chance for members to decide what to do this evening", Comment ="", EventDate=new DateTime(2017, 03, 07, 20, 00, 00) },
                new Programme { Id = 14, Title="Inter-club Competition", Description="Details to be confirmed", Comment ="", EventDate=new DateTime(2017, 03, 21, 20, 00, 00) },
                new Programme { Id = 15, Title="Competition: Theme - Altered Reality", Description="Judge: Tony Winfield", Comment ="", EventDate=new DateTime(2017, 04, 04, 20, 00, 00) },
                new Programme { Id = 16, Title="In Pursuit", Description="A talk by Dave", Comment ="", EventDate=new DateTime(2017, 04, 18, 20, 00, 00) },
                new Programme { Id = 17, Title="Outdoor Practical Evening", Description="Nature Photography", Comment ="With Paddy Ruske at Wollesley Nature Reserve", EventDate=new DateTime(2017, 05, 16, 20, 00, 00) },
                new Programme { Id = 18, Title="Annual General Meeting", Description="Members are urged to attend the AGM", Comment ="Any presentations and awards will be offically presented to the relevant members. Committee member election", EventDate=new DateTime(2017, 05, 30, 20, 00, 00) }
            };
        }
    }
}
