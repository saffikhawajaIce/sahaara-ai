using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Configurations;

public class ConsentRecordConfiguration : IEntityTypeConfiguration<ConsentRecord>
{
    public void Configure(EntityTypeBuilder<ConsentRecord> builder)
    {
        builder.ToTable("ConsentRecords");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ConsentText).IsRequired();
        builder.Property(x => x.Status).HasConversion<int>();
        builder.HasOne(x => x.Applicant)
            .WithMany(x => x.ConsentRecords)
            .HasForeignKey(x => x.ApplicantId);
    }
}
