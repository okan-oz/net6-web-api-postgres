using System;
namespace UserGroupManager.Entities
{
    interface   IEntity
    {
       //Entity unique id 
       public string Id {get; set; }
       public DateTime CreatedTime { get; set; }
       public string CreatedBy { get; set; }
    }
}

