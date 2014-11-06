using System.Data.Entity;
using Abp.EntityFramework;
using Reporter.Users;
using Reporter.SitReps;


namespace Reporter.EntityFramework
{
    public class ReporterDbContext : AbpDbContext
    {
        public virtual IDbSet<SitRep> SitReps { get; set; }

        public virtual IDbSet<User> Users { get; set; }

        /// <summary>
        /// </summary>
        /// <remarks>
        /// Setting "Default" to base class helps us when working migration commands on Package Manager Console.
        /// But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
        /// pass connection string name to base classes. ABP works either way.
        /// </remarks>
        public ReporterDbContext()
            : base("Default")
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameOrConnectionString"></param>
        /// <remarks>
        /// This constructor is used by ABP to pass connection string defined in ReporterDataModule.PreInitialize.
        /// Notice that, actually you will not directly create an instance of ReporterDbContext since ABP automatically handles it.
        /// </remarks>
        public ReporterDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
