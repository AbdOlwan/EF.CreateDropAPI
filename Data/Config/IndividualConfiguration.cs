using EF.CreateDropAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.CreateDropAPI.Data.Config
{
    public class IndividualConfiguration : IEntityTypeConfiguration<Individual>
    {


        public void Configure(EntityTypeBuilder<Individual> builder)
        {

            builder.ToTable("Individuals");

        }


    }
}
