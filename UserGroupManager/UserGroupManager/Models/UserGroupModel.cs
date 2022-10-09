using System;
namespace UserGroupManager.Models
{
    public class UserGroupModel
    {
        public string Name { get; set; } = null!;
        public string? ImagePath { get; set; }
        public bool IsActive { get; set; }

        public UserGroupModel(string name, string? imagePath,bool isActive )
        {
            this.ImagePath = imagePath;
            this.IsActive = isActive;
            this.Name = name;
        }
    }
}

