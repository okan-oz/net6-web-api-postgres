using System;
using UserGroupManager.Models;

namespace UserGroupManager.Services.UserGroup
{
    public class UserGroupService : IUserGroupService
    {
        public CResponse<UserGroupModel> Create(CRequest<UserGroupModel> model)
        {
            throw new NotImplementedException();
        }

        public CResponse<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CResponse<IEnumerable<UserGroupModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public CResponse<UserGroupModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CResponse<UserGroupModel> Update(CRequest<UserGroupModel> model)
        {
            throw new NotImplementedException();
        }
    }
}

