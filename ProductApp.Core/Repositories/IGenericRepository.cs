using System.Linq.Expressions;

namespace ProductApp.Core.Repositories;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    
    //   productRepository.where(x=>x.id>5).OrderBy.ToListAsync();  (TOLIST dediğimizde db'ye yazacak ancak IQueryable yaparsak db'ye gitmeden işlemi sağlarız.)
    IQueryable<T> GetAll(Expression<Func<T,bool>> expression); 
    IQueryable<T> Where(Expression<Func<T,bool>> expression);
    Task<bool> AnyAsync(Expression<Func<T,bool>> expression);
    Task AddAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);
    void Update(T entity);
    void Remove(T entity);
    void RemoveRange (IEnumerable<T> entities);

}
