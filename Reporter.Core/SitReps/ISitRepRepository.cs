using System.Collections.Generic;
using Abp.Domain.Repositories;

namespace Reporter.SitReps
{
    /// <summary>
    /// Defines a repository to perform database operations for <see cref="SitRep"/> Entities.
    /// 
    /// Extends <see cref="IRepository{TEntity, TPrimaryKey}"/> to inherit base repository functionality. 
    /// </summary>
    public interface ISitRepRepository : IRepository<SitRep, int>
    {
        /// <summary>
        /// Gets all sit-reps with <see cref="SitRep.Reporter"/> is retrived (Include for EntityFramework, Fetch for NHibernate)
        /// filtered by given conditions.
        /// </summary>
        /// <param name="reporterId">Optional reporter filter. If it's null, not filtered.</param>
        /// <returns>List of found sit-reps</returns>
        List<SitRep> GetAllWithReporters(int? reporterId);
    }
}
