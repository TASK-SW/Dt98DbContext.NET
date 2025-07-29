
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class EniErrorConfiguration : IEntityTypeConfiguration<EniError>
    {
        public void Configure(EntityTypeBuilder<EniError> builder)
        {
            builder.ToTable("ENI_ERROR");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.Service).HasColumnName("Service");
            builder.Property(e => e.MessageId).HasColumnName("MessageId");
            builder.Property(e => e.MessageType).HasColumnName("MessageType");
            builder.Property(e => e.MessageNumber).HasColumnName("MessageNumber");
            builder.Property(e => e.MessageText).HasColumnName("MessageText");
            builder.Property(e => e.HostDeliveryState).HasColumnName("HostDeliveryState");
            builder.Property(e => e.DateTime).HasColumnName("DateTime");
        }
    }
}
