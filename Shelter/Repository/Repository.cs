using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Repository
{
  public abstract class Repository<T> : IRepository<T>
          where T : class
  {
    /// <summary>
    /// Dbcontext.
    /// </summary>
    protected DbContext ctx;

    /// <summary>
    /// Initializes a new instance of the <see cref="Repository{T}"/> class.
    /// </summary>
    /// <param name="ctx">Dbcontext.</param>
    protected Repository(DbContext ctx)
    {
      this.ctx = ctx;
    }

    /// <inheritdoc/>
    public IQueryable<T> GetAll()
    {
      return this.ctx.Set<T>();
    }

    /// <inheritdoc/>
    public abstract T GetOne(int id);
  }
}
