using Abp.Domain.Entities;
using Abp.EntityFramework.Repositories;

namespace Reporter.EntityFramework.Repositories
{
    public abstract class ReporterRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ReporterDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class ReporterRepositoryBase<TEntity> : ReporterRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
