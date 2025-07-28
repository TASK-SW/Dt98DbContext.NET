
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class CardTracksConfiguration : IEntityTypeConfiguration<CardTracks>
    {
        public void Configure(EntityTypeBuilder<CardTracks> builder)
        {
            builder.ToTable("_sptCARDTRACKS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidCardProfile).HasColumnName("OID_CARDPROFILE");
            builder.Property(e => e.TrackPos).HasColumnName("TRACKPOS");
            builder.Property(e => e.LowVal).HasColumnName("LOWVAL");
            builder.Property(e => e.UpVal).HasColumnName("UPVAL");
            builder.Property(e => e.Condition).HasColumnName("CONDITION");
        }
    }
}
