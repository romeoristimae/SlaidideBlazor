using System.ComponentModel.DataAnnotations;

namespace Abc.Data.Common
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual DateTime? ValidFrom { get; set; }
        public virtual DateTime? ValidUntil { get; set; }
        [Timestamp] public virtual byte[] Timestamp { get; set; } = [];
    }
}
