using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Reporter.SitReps;

namespace Reporter.EntityFramework.Repositories
{
    /// <summary>
    /// Implements <see cref="ITaskRepository"/> for EntityFramework ORM.
    /// </summary>
    public class TaskRepository : ReporterRepositoryBase<SitRep, int>, ISitRepRepository
    {
        public List<SitRep> GetAllWithReporters(int? reporterId)
        {
            //In repository methods, we do not deal with create/dispose DB connections, DbContexes and transactions. ABP handles it.

            var query = GetAll(); //GetAll() returns IQueryable<T>, so we can query over it.
            //var query = Context.Tasks.AsQueryable(); //Alternatively, we can directly use EF's DbContext object.
            //var query = Table.AsQueryable(); //Another alternative: We can directly use 'Table' property instead of 'Context.Tasks', they are identical.

            //Add some Where conditions...

            if (reporterId.HasValue)
            {
                query = query.Where(task => task.Reporter.Id == reporterId.Value);
            }
            return query
                .OrderByDescending(task => task.CreationTime)
                .Include(task => task.Reporter) //Include reporter in a single query
                .ToList();
        }
    }
}
