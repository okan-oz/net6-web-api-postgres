using System;
namespace UserGroupManager.Entities.Base
{
    public class BaseEntity :IEntity
    {
        public BaseEntity()
        {
        }

        public string Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
    }
}

