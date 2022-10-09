using System;
using UserGroupManager.Entities.Base;

namespace UserGroupManager.Entities
{
    public class UserGroupMember:BaseEntity
    {
        public String UserGroupId { get; set; } = null!;
        public String UserId { get; set; } = null!;
        public bool IsUserAdmin { get; set; }
        public DateTime JoinDate { get; set; }
       
    }
}

