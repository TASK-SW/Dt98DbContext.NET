
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class JournalJobsConfiguration : IEntityTypeConfiguration<JournalJobs>
    {
        public void Configure(EntityTypeBuilder<JournalJobs> builder)
        {
            builder.ToTable("JOURNALJOBS");

            builder.HasKey(e => new { e.OidJournal, e.ProviderId, e.JobId });
            builder.Property(e => e.OidJournal).HasColumnName("OID_JOURNAL");
            builder.Property(e => e.ProviderId).HasColumnName("ProviderId");
            builder.Property(e => e.JobId).HasColumnName("JobId");
            builder.Property(e => e.LastUpdate).HasColumnName("LastUpdate");
            builder.Property(e => e.ResultCode).HasColumnName("ResultCode");
            builder.Property(e => e.JobStatus).HasColumnName("JobStatus");
        }
    }
}
