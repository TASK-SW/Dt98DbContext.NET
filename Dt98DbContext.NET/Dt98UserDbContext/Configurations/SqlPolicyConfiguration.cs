
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class SqlPolicyConfiguration : IEntityTypeConfiguration<SqlPolicy>
    {
        public void Configure(EntityTypeBuilder<SqlPolicy> builder)
        {
            builder.ToTable("SQLPOLICY");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.PolType).HasColumnName("POLTYPE");
            builder.Property(e => e.Server).HasColumnName("SERVER");
            builder.Property(e => e.User).HasColumnName("USER");
            builder.Property(e => e.Pwd).HasColumnName("PWD");
            builder.Property(e => e.DataBase).HasColumnName("DATABASE");
            builder.Property(e => e.Directory).HasColumnName("DIRECTORY");
            builder.Property(e => e.Option).HasColumnName("OPTION");
            builder.Property(e => e.AddData).HasColumnName("ADDDATA");
        }
    }
}
