namespace SahaaraAI.Application.Common.Interfaces.Persistence;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}
