
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class DatacomOnlineHostsConfiguration : IEntityTypeConfiguration<DatacomOnlineHosts>
    {
        public void Configure(EntityTypeBuilder<DatacomOnlineHosts> builder)
        {
            builder.ToTable("DatacomOnlineHosts");

            builder.HasKey(e => new { e.HostId, e.RecordState, e.ApplicationId, e.MacKeyId, e.MacKey, e.EncKeyId, e.EncKey });
            builder.Property(e => e.HostId).HasColumnName("HostId");
            builder.Property(e => e.RecordState).HasColumnName("RecordState");
            builder.Property(e => e.ApplicationId).HasColumnName("ApplicationId");
            builder.Property(e => e.HostAddressIsdnB).HasColumnName("HostAddressIsdnB");
            builder.Property(e => e.HostAddressIP).HasColumnName("HostAddressIP");
            builder.Property(e => e.MessageTimeout).HasColumnName("MessageTimeout");
            builder.Property(e => e.RetryCountAuthorization).HasColumnName("RetryCountAuthorization");
            builder.Property(e => e.RetryCountCancellation).HasColumnName("RetryCountCancellation");
            builder.Property(e => e.MacKeyId).HasColumnName("MACKeyId");
            builder.Property(e => e.MacKey).HasColumnName("MACKey");
            builder.Property(e => e.EncKeyId).HasColumnName("ENCKeyId");
            builder.Property(e => e.EncKey).HasColumnName("ENCKey");
            builder.Property(e => e.OlisVersion).HasColumnName("OlisVersion");
        }
    }
}
