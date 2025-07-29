
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.ToTable("SCHEDULE");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.Mode).HasColumnName("MODE");
            builder.Property(e => e.Interval).HasColumnName("INTERVAL");
            builder.Property(e => e.DayOffSet).HasColumnName("DAYOFFSET");
            builder.Property(e => e.TimeOffSet).HasColumnName("TIMEOFFSET");
            builder.Property(e => e.LastDate).HasColumnName("LASTDATE");
            builder.Property(e => e.NextDate).HasColumnName("NEXTDATE");
            builder.Property(e => e.FileName).HasColumnName("FILENAME");
            builder.Property(e => e.Command).HasColumnName("COMMAND");
            builder.Property(e => e.ComSvr).HasColumnName("COMSVR");
        }
    }
}
