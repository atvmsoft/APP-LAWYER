using Application.IO.Core.Context.Extensions;
using Application.IO.Core.Domain.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.IO.Core.Context.Mappings.System
{
    public class AdmUserSystemMapping : EntityTypeConfiguration<AdmUserSystem>
    {
        public override void Map(EntityTypeBuilder<AdmUserSystem> builder)
        {
            builder.ToTable("AdmUsersSystem");

            builder.HasOne(e => e.ApplicationUser)
                .WithMany(o => o.AdmUsersSystem)
                .HasForeignKey(e => e.IdApplicationUser);
        }
    }
}
