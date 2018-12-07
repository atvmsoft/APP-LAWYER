using Application.IO.Core.Context.Extensions;
using Application.IO.Core.Domain.Lawyers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.IO.Core.Context.Mappings.Lawyers
{
    public class LawyerOccupationAreaMapping : EntityTypeConfiguration<LawyerOccupationArea>
    {
        public override void Map(EntityTypeBuilder<LawyerOccupationArea> builder)
        {
            builder.Property(e => e.Name).HasColumnType("varchar(200)");
            builder.Property(e => e.MinScore).HasColumnType("float");

            builder.ToTable("LawyerOccupationAreas");
        }
    }
}
