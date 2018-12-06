using Application.IO.Core.Context.Extensions;
using Application.IO.Core.Domain.Lawyers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.IO.Core.Context.Mappings.Lawyers
{
    public class OccupationAreasLawyerMapping : EntityTypeConfiguration<OccupationAreasLawyer>
    {
        public override void Map(EntityTypeBuilder<OccupationAreasLawyer> builder)
        {
            builder.ToTable("OccupationAreasLawyer");

            builder.HasOne(e => e.Lawyer)
                .WithMany(o => o.OccupationAreasLawyer)
                .HasForeignKey(e => e.IdLawyer);

            builder.HasOne(e => e.LawyerOccupationAreas)
                .WithMany(o => o.OccupationAreasLawyer)
                .HasForeignKey(e => e.IdLawyerOccupationArea);
        }
    }
}
