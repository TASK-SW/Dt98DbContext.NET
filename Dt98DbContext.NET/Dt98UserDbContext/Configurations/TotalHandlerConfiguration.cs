
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class TotalHandlerConfiguration : IEntityTypeConfiguration<TotalHandler>
    {
        public void Configure(EntityTypeBuilder<TotalHandler> builder)
        {
            builder.ToTable("_sptTOTALHANDLER");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.ClsId).HasColumnName("CLSID");
        }
    }
}
