using EF.CreateDropAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EF.CreateDropAPI.Enums;

namespace EF.CreateDropAPI.Data.Config
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {


        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedNever()
                .IsRequired();



            builder.Property(s => s.Title)
                .HasConversion(
                  x => x.ToString(),
                  x => (ScheduelEnum)Enum.Parse(typeof(ScheduelEnum), x)
                  );




            builder.ToTable("Schedules");

        }

      
    }

}
