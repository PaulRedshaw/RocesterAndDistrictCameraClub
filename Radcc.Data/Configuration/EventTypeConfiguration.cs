using Radcc.Model;
using System.Data.Entity.ModelConfiguration;

namespace Radcc.Data.Configuration
{
    public class EventTypeConfiguration : EntityTypeConfiguration<EventType>
    {
        public EventTypeConfiguration()
        {
            ToTable("EventType");
            Property(e => e.Name).IsRequired().HasMaxLength(50);
            Property(e => e.Description).HasMaxLength(250);
        }

    }
}
