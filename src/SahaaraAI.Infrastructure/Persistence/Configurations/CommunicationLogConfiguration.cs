using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Configurations;

public class CommunicationLogConfiguration : IEntityTypeConfiguration<CommunicationLog>
{
    public void Configure(EntityTypeBuilder<CommunicationLog> builder)
    {
        builder.ToTable("CommunicationLogs");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Channel).HasConversion<int>();
        builder.Property(x => x.Action).IsRequired().HasMaxLength(100);
    }
}
