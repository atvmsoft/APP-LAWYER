using Application.IO.Core.Context.Extensions;
using Application.IO.Core.Domain.Lawyers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.IO.Core.Context.Mappings.Lawyers
{
    public class OccupationAreaLawyerMapping : EntityTypeConfiguration<OccupationAreaLawyer>
    {
        public override void Map(EntityTypeBuilder<OccupationAreaLawyer> builder)
        {
            builder.Property(e => e.LawyerScore).HasColumnType("float");

            builder.ToTable("OccupationAreasLawyer");

            builder.HasOne(e => e.LawyerOccupationAreas)
                .WithMany(o => o.OccupationAreasLawyer)
                .HasForeignKey(e => e.IdLawyerOccupationArea);

            builder.HasOne(e => e.Lawyer)
                .WithMany(o => o.OccupationAreasLawyer)
                .HasForeignKey(e => e.IdLawyer);
        }
    }
}
