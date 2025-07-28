using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class BlackListTypesConfiguration : IEntityTypeConfiguration<BlackListTypes>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<BlackListTypes> builder)
        {
            builder.ToTable("_sctBLACKLISTTYPES");

            builder.HasKey(b => b.Oid);

            builder.Property(b => b.Oid).HasColumnName("OID");
            builder.Property(b => b.Id).HasColumnName("ID");
            builder.Property(b => b.Name).HasColumnName("NAME");
            builder.Property(b => b.IId).HasColumnName("IID");
            builder.Property(b => b.ClsId).HasColumnName("CLSID");
        }

        #endregion Public Methods
    }
}