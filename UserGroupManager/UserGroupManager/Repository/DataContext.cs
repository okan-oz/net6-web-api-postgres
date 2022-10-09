using System;
using Microsoft.EntityFrameworkCore;
using UserGroupManager.Entities;
using UserGroupManager.Helpers.Constants;

namespace UserGroupManager.Repository
{
    public class DataContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString(AppSettingsConstants.MofiUserGroupDb));
        }

        public DbSet<UserGroupEntity> UserGroup { get; set; }
    
        

    }
}

