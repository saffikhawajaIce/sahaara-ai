using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Configurations;

public class OutreachMessageConfiguration : IEntityTypeConfiguration<OutreachMessage>
{
    public void Configure(EntityTypeBuilder<OutreachMessage> builder)
    {
        builder.ToTable("OutreachMessages");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Channel).HasConversion<int>();
        builder.Property(x => x.Status).HasConversion<int>();
        builder.Property(x => x.Body).IsRequired();
        builder.HasOne(x => x.Case)
            .WithMany(x => x.OutreachMessages)
            .HasForeignKey(x => x.CaseId);
        builder.HasOne(x => x.Ngo)
            .WithMany(x => x.OutreachMessages)
            .HasForeignKey(x => x.NgoId);
    }
}
