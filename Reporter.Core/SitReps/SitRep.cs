using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Reporter.Users;

namespace Reporter.SitReps
{
    /// <summary>
    /// Represents a SitRep entity.
    /// 
    /// Inherits from <see cref="Entity{TPrimaryKey}"/> class (Optionally can implement <see cref="IEntity{TPrimaryKey}"/> directly).
    /// 
    /// An Entity's primary key is assumed as <see cref="int"/> as default.
    /// If it's different, we must declare it as generic parameter (as done here for <see cref="long"/>).
    /// 
    /// Implements <see cref="IHasCreationTime"/>, thus ABP sets CreationTime automatically while saving to database.
    /// Also, this helps us to use standard naming and functionality for 'creation time' of entities.
    /// </summary>
    [Table("SitReps")]
    public class SitRep : Entity, IHasCreationTime
    {
        /// <summary>
        /// A reference (navigation property) to assigned <see cref="User"/> for this sit-rep.
        /// We declare <see cref="ForeignKeyAttribute"/> for EntityFramework here.
        /// </summary>
        [ForeignKey("ReporterId")]
        public virtual User Reporter { get; set; }

        /// <summary>
        /// Database field for Reporter reference.
        /// </summary>
        public virtual int? ReporterId { get; set; }

        /// <summary>
        /// Describes the sit-rep.
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// The time when this sit-rep is created.
        /// </summary>
        public virtual DateTime CreationTime { get; set; }

        /// <summary>
        /// Default costructor.
        /// Assigns some default values to properties.
        /// </summary>
        public SitRep()
        {
            CreationTime = DateTime.Now;
        }
    }
}
