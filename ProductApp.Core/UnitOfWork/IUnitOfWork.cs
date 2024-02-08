namespace ProductApp.Core.UnitOfWork;

public interface IUnitOfWork
{
    Task CommitAsync();
    void Commit();
}
