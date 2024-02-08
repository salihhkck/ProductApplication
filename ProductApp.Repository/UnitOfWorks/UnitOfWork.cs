using ProductApp.Core.UnitOfWork;
using ProductApp.Repository.Context;

namespace ProductApp.Repository.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly ProductAppDbContext _context;

    public UnitOfWork(ProductAppDbContext context)
    {
        _context = context;
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }
}
