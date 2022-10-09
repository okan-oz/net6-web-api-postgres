using System;
using UserGroupManager.Entities.Base;

namespace UserGroupManager.Entities
{
    public class UserGroup: BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? ImagePath { get; set; }
        public bool IsActive { get; set; }
    }
}

