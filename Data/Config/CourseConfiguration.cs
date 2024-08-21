using EF.CreateDropAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EF.CreateDropAPI.Data.Config
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
      

        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Id)
                .ValueGeneratedNever()
                .IsRequired();

            
            builder.Property(x => x.CourseName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();

            builder.Property(x => x.Price)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.ToTable("Courses");

        }
    }

}
