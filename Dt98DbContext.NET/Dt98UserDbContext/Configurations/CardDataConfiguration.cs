using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class CardDataConfiguration : IEntityTypeConfiguration<CardData>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<CardData> builder)
        {
            builder.ToTable("CARDDATA");

            builder.HasKey(e => e.Pan);
            builder.Property(e => e.Pan).HasColumnName("PAN");
            builder.Property(e => e.PinMode).HasColumnName("PINMode");
            builder.Property(e => e.Pin).HasColumnName("PIN");
            builder.Property(e => e.MileageMode).HasColumnName("MileageMode");
            builder.Property(e => e.Mileage).HasColumnName("Mileage");
            builder.Property(e => e.ServiceCode).HasColumnName("ServiceCode");
            builder.Property(e => e.FuelLimit).HasColumnName("FuelLimit");
            builder.Property(e => e.PosDateElapse).HasColumnName("PosDateElapse");
            builder.Property(e => e.ErrorCountMax).HasColumnName("ErrorCountMax");
            builder.Property(e => e.ErrorCountCur).HasColumnName("ErrorCountCur");
            builder.Property(e => e.RecordState).HasColumnName("RecordState");
        }

        #endregion Public Methods
    }
}