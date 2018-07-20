using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SecondABP.EntityFramework.Repositories
{
    public abstract class SecondABPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SecondABPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SecondABPRepositoryBase(IDbContextProvider<SecondABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SecondABPRepositoryBase<TEntity> : SecondABPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SecondABPRepositoryBase(IDbContextProvider<SecondABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
