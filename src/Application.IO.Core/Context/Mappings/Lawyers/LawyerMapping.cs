using Application.IO.Core.Context.Extensions;
using Application.IO.Core.Domain.Lawyers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.IO.Core.Context.Mappings.Lawyers
{
    public class LawyerMapping : EntityTypeConfiguration<Lawyer>
    {
        public override void Map(EntityTypeBuilder<Lawyer> builder)
        {
            builder.ToTable("Lawyers");

            builder.HasOne(e => e.ApplicationUser)
                .WithMany(o => o.Lawyers)
                .HasForeignKey(e => e.IdApplicationUser);
        }
    }
}
