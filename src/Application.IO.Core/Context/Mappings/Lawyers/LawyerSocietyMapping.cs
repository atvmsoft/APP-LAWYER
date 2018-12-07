using Application.IO.Core.Context.Extensions;
using Application.IO.Core.Domain.Lawyers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.IO.Core.Context.Mappings.Lawyers
{
    public class LawyerSocietyMapping : EntityTypeConfiguration<LawyerSociety>
    {
        public override void Map(EntityTypeBuilder<LawyerSociety> builder)
        {
            builder.Property(e => e.Name).HasColumnType("varchar(80)");
            builder.Property(e => e.Number).HasColumnType("varchar(10)");
            builder.Property(e => e.Complement).HasColumnType("varchar(100)");
            builder.Property(e => e.BusinessPhone).HasColumnType("varchar(20)");
            builder.Property(e => e.BusinessFax).HasColumnType("varchar(20)");
            builder.Property(e => e.BusinessEmail).HasColumnType("varchar(256)");

            builder.ToTable("LawyersSociety");

            builder.HasOne(e => e.Lawyer)
                .WithMany(o => o.LawyersSociety)
                .HasForeignKey(e => e.IdLawyer);

            builder.HasOne(e => e.PostalCodeAdress)
                .WithMany(o => o.LawyersSociety)
                .HasForeignKey(e => e.IdPostalCodeAdress);
        }
    }
}
