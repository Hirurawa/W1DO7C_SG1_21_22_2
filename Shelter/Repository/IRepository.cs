using System.Linq;

namespace Repository
{
  public interface IRepository<T>
      where T : class
  {
    /// <summary>
    /// Gets one entity.
    /// </summary>
    /// <param name="id">ID of the entity.</param>
    /// <returns>The specifited entity.</returns>
    T GetOne(int id);

    /// <summary>
    /// Gets all entity.
    /// </summary>
    /// <returns>All the entities.</returns>
    IQueryable<T> GetAll();

    // void Insert(T entity);
    // bool Remove(T entity / int id);
  }
}
