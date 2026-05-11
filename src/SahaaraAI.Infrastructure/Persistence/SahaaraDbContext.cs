using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence;

public class SahaaraDbContext : IdentityDbContext<ApplicationUser>
{
    public SahaaraDbContext(DbContextOptions<SahaaraDbContext> options) : base(options)
    {
    }

    public DbSet<Applicant> Applicants => Set<Applicant>();
    public DbSet<ConsentRecord> ConsentRecords => Set<ConsentRecord>();
    public DbSet<AssistanceCase> AssistanceCases => Set<AssistanceCase>();
    public DbSet<CaseNote> CaseNotes => Set<CaseNote>();
    public DbSet<Ngo> Ngos => Set<Ngo>();
    public DbSet<NgoService> NgoServices => Set<NgoService>();
    public DbSet<AssistanceCategory> AssistanceCategories => Set<AssistanceCategory>();
    public DbSet<AssistanceSubcategory> AssistanceSubcategories => Set<AssistanceSubcategory>();
    public DbSet<CaseNgoMatch> CaseNgoMatches => Set<CaseNgoMatch>();
    public DbSet<OutreachMessage> OutreachMessages => Set<OutreachMessage>();
    public DbSet<CommunicationLog> CommunicationLogs => Set<CommunicationLog>();
    public DbSet<FollowUp> FollowUps => Set<FollowUp>();
    public DbSet<AuditEntry> AuditEntries => Set<AuditEntry>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(SahaaraDbContext).Assembly);
    }
}
