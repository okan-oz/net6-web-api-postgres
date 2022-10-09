using System;
using AutoMapper;
using UserGroupManager.Entities;
using UserGroupManager.Models;

namespace UserGroupManager.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
   
            
            CreateMap<UserGroupModel, UserGroupEntity>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore both null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                      

                        return true;
                    }
                ));
        }
    }
}

