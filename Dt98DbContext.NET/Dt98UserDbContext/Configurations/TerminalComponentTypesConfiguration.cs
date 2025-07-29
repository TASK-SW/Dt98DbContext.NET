
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class TerminalComponentTypesConfiguration : IEntityTypeConfiguration<TerminalComponentTypes>
    {
        public void Configure(EntityTypeBuilder<TerminalComponentTypes> builder)
        {
            builder.ToTable("_sctTERMINALCOMPONENTTYPES");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Name).HasColumnName("NAME");
        }
    }
}
