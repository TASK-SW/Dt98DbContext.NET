
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class CardDlyTotal002Configuration : IEntityTypeConfiguration<CardDlyTotal002>
    {
        public void Configure(EntityTypeBuilder<CardDlyTotal002> builder)
        {
            builder.ToTable("CARDDLYTOTAL002");

            builder.HasKey(e => e.Pan);
            builder.Property(e => e.Pan).HasColumnName("PAN");
            builder.Property(e => e.Amount).HasColumnName("AMOUNT");
            builder.Property(e => e.OutdoorAmount).HasColumnName("OUTDOORAMOUNT");
            builder.Property(e => e.EditDate).HasColumnName("EDITDATE");
            builder.Property(e => e.DopIndoorAmt).HasColumnName("DOP_INDOOR_AMT");
            builder.Property(e => e.DopIndoorCnt).HasColumnName("DOP_INDOOR_CNT");
            builder.Property(e => e.DopOutdoorAmt).HasColumnName("DOP_OUTDOOR_AMT");
            builder.Property(e => e.DopOutdoorCnt).HasColumnName("DOP_OUTDOOR_CNT");
        }
    }
}
