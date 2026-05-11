using Microsoft.EntityFrameworkCore.Storage;
using SahaaraAI.Application.Common.Interfaces.Persistence;

namespace SahaaraAI.Infrastructure.Persistence;

public class UnitOfWork : IUnitOfWork
{
    private readonly SahaaraDbContext _dbContext;
    private IDbContextTransaction? _transaction;

    public UnitOfWork(SahaaraDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task SaveChangesAsync() => _dbContext.SaveChangesAsync();

    public async Task BeginTransactionAsync()
    {
        _transaction = await _dbContext.Database.BeginTransactionAsync();
    }

    public async Task CommitTransactionAsync()
    {
        if (_transaction is not null)
        {
            await _transaction.CommitAsync();
        }
    }

    public async Task RollbackTransactionAsync()
    {
        if (_transaction is not null)
        {
            await _transaction.RollbackAsync();
        }
    }
}
