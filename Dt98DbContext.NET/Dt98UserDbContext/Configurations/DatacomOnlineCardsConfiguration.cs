
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class DatacomOnlineCardsConfiguration : IEntityTypeConfiguration<DatacomOnlineCards>
    {
        public void Configure(EntityTypeBuilder<DatacomOnlineCards> builder)
        {
            builder.ToTable("DatacomOnlineCards");

            builder.HasKey(e => new { e.TrackNo, e.CardId, e.RecordState, e.ApplicationId });
            builder.Property(e => e.TrackNo).HasColumnName("TrackNo");
            builder.Property(e => e.CardId).HasColumnName("CardId");
            builder.Property(e => e.RecordState).HasColumnName("RecordState");
            builder.Property(e => e.ApplicationId).HasColumnName("ApplicationId");
            builder.Property(e => e.OnlineCheckIndoor).HasColumnName("OnlineCheckIndoor");
            builder.Property(e => e.OnlineCheckOutdoor).HasColumnName("OnlineCheckOutdoor");
            builder.Property(e => e.OnlinePresetOutdoor).HasColumnName("OnlinePresetOutdoor");
            builder.Property(e => e.DownOptionLimitIndoor).HasColumnName("DownOptionLimitIndoor");
            builder.Property(e => e.DownOptionLimitOutdoor).HasColumnName("DownOptionLimitOutdoor");
            builder.Property(e => e.DownOptionTransactionCount).HasColumnName("DownOptionTransactionCount");
            builder.Property(e => e.DownOptionCheckBlacklist).HasColumnName("DownOptionCheckBlacklist");
            builder.Property(e => e.OnlineFloorLimit).HasColumnName("OnlineFloorLimit");
            builder.Property(e => e.AuthorizationHost1Id).HasColumnName("AuthorizationHost1Id");
            builder.Property(e => e.AuthorizationHost2Id).HasColumnName("AuthorizationHost2Id");
            builder.Property(e => e.TdFileOnlineInformation).HasColumnName("TdFileOnlineInformation");
            builder.Property(e => e.OnlineSiteId).HasColumnName("OnlineSiteId");
            builder.Property(e => e.OlisVersion).HasColumnName("OlisVersion");
            builder.Property(e => e.SiteIdOlis1P).HasColumnName("SiteIdOlis1P");
            builder.Property(e => e.CheckLuhn).HasColumnName("CheckLuhn");
            builder.Property(e => e.MinumumPanLength).HasColumnName("MinumumPanLength");
            builder.Property(e => e.MaximumPanLength).HasColumnName("MaximumPanLength");
            builder.Property(e => e.ExpirationDatePosition).HasColumnName("ExpirationDatePosition");
            builder.Property(e => e.IssuerId).HasColumnName("IssuerId");
            builder.Property(e => e.SignatureAllowed).HasColumnName("SignatureAllowed");
            builder.Property(e => e.BlacklistId).HasColumnName("BlacklistId");
            builder.Property(e => e.DccQuery).HasColumnName("DCCQuery");
        }
    }
}
