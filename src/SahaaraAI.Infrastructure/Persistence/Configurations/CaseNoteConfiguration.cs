using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Configurations;

public class CaseNoteConfiguration : IEntityTypeConfiguration<CaseNote>
{
    public void Configure(EntityTypeBuilder<CaseNote> builder)
    {
        builder.ToTable("CaseNotes");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Note).IsRequired();
        builder.HasOne(x => x.Case)
            .WithMany(x => x.Notes)
            .HasForeignKey(x => x.CaseId);
    }
}
