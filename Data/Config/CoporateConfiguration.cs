using EF.CreateDropAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.CreateDropAPI.Data.Config
{
    public class CoporateConfiguration : IEntityTypeConfiguration<Coporate>
    {


        public void Configure(EntityTypeBuilder<Coporate> builder)
        {

            builder.ToTable("Coporates");

        }


    }
}
