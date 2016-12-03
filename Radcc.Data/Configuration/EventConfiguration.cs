using Radcc.Model;
using System.Data.Entity.ModelConfiguration;

namespace Radcc.Data.Configuration
{
    public class EventConfiguration : EntityTypeConfiguration<Event>
    {
        public EventConfiguration()
        {
            ToTable("Event");
            Property(e => e.Title).IsRequired().HasMaxLength(250);
            Property(e => e.Description).IsRequired().HasMaxLength(250);
            Property(e => e.Comments).HasMaxLength(500);
            Property(e => e.EventDate).IsRequired();
    }
    }
}
