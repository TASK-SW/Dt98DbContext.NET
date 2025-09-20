using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class persFuelIngPointsConfiguration : IEntityTypeConfiguration<persFuelIngPoints>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<persFuelIngPoints> builder)
        {
            builder.ToTable("_persFUELINGPOINTS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidFuelSale).HasColumnName("OID_FUELSALE");
            builder.Property(e => e.ControlState).HasColumnName("CONTROLSTATE");
            builder.Property(e => e.LastError).HasColumnName("LASTERROR");
            builder.Property(e => e.ErrorCount).HasColumnName("ERRORCOUNT");
            builder.Property(e => e.CurrentNozzle).HasColumnName("CURRENTNOZZLE");
            builder.Property(e => e.LtNummeRateUr).HasColumnName("LT_NUMMERATEUR");
            builder.Property(e => e.LtVolume).HasColumnName("LT_VOLUME");
            builder.Property(e => e.LtAmount).HasColumnName("LT_AMOUNT");
            builder.Property(e => e.LtNozzle).HasColumnName("LT_NOZZLE");
            builder.Property(e => e.PsState).HasColumnName("PS_STATE");
            builder.Property(e => e.PsError).HasColumnName("PS_ERROR");
            builder.Property(e => e.PsCountEr1).HasColumnName("PS_COUNTER1");
            builder.Property(e => e.PsCountEr2).HasColumnName("PS_COUNTER2");
            builder.Property(e => e.PsCountEr3).HasColumnName("PS_COUNTER3");
            builder.Property(e => e.PsCountEr4).HasColumnName("PS_COUNTER4");
            builder.Property(e => e.PsNummeRateUr).HasColumnName("PS_NUMMERATEUR");
        }

        #endregion Public Methods
    }
}