using Application.IO.Core.Context.Extensions;
using Application.IO.Core.Domain.Lawyers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.IO.Core.Context.Mappings.Lawyers
{
    public class LawyerOccupationAreaMapping : EntityTypeConfiguration<OccupationAreasLawyer>
    {
        public override void Map(EntityTypeBuilder<OccupationAreasLawyer> builder)
        {
            builder.ToTable("LawyerOccupationAreas");
        }
    }
}
