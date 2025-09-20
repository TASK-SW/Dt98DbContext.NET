using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class CardTrxCount002Configuration : IEntityTypeConfiguration<CardTrxCount002>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<CardTrxCount002> builder)
        {
            builder.ToTable("CARDTRXCOUNT002");

            builder.HasKey(e => e.Pan);
            builder.Property(e => e.Pan).HasColumnName("PAN");
            builder.Property(e => e.Count).HasColumnName("COUNT");
            builder.Property(e => e.EditDate).HasColumnName("EDITDATE");
        }

        #endregion Public Methods
    }
}