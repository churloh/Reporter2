using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace Reporter.Users
{
    /// <summary>
    /// Represents a User entity.
    /// 
    /// It inherits from <see cref="Entity"/> class (Optionally can implement <see cref="IEntity"/> directly).
    /// </summary>
    [Table("Users")]
    public class User : Entity
    {
        /// <summary>
        /// A property (database field) for a User to store his/her name.
        /// </summary>
        public virtual string Name { get; set; }
    }
}