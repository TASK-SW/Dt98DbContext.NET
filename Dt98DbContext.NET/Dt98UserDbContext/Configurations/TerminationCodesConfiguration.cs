
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class TerminationCodesConfiguration : IEntityTypeConfiguration<TerminationCodes>
    {
        public void Configure(EntityTypeBuilder<TerminationCodes> builder)
        {
            builder.ToTable("_sptTERMINATIONCODES");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Code01).HasColumnName("CODE01");
            builder.Property(e => e.Code02).HasColumnName("CODE02");
            builder.Property(e => e.Code03).HasColumnName("CODE03");
            builder.Property(e => e.Code04).HasColumnName("CODE04");
            builder.Property(e => e.Code05).HasColumnName("CODE05");
            builder.Property(e => e.Code06).HasColumnName("CODE06");
            builder.Property(e => e.Code07).HasColumnName("CODE07");
            builder.Property(e => e.Code08).HasColumnName("CODE08");
            builder.Property(e => e.Code09).HasColumnName("CODE09");
            builder.Property(e => e.Code10).HasColumnName("CODE10");
            builder.Property(e => e.Code11).HasColumnName("CODE11");
            builder.Property(e => e.Code12).HasColumnName("CODE12");
            builder.Property(e => e.Code13).HasColumnName("CODE13");
            builder.Property(e => e.Code14).HasColumnName("CODE14");
            builder.Property(e => e.Code15).HasColumnName("CODE15");
            builder.Property(e => e.Code16).HasColumnName("CODE16");
            builder.Property(e => e.Code17).HasColumnName("CODE17");
            builder.Property(e => e.Code18).HasColumnName("CODE18");
            builder.Property(e => e.Code19).HasColumnName("CODE19");
            builder.Property(e => e.Code20).HasColumnName("CODE20");
        }
    }
}
