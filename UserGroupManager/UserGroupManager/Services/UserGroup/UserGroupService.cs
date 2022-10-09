using System;
using AutoMapper;
using Services;
using UserGroupManager.Models;
using UserGroupManager.Repository;
using Microsoft.EntityFrameworkCore;

namespace UserGroupManager.Services.UserGroupService
{
    public class UserGroupService: IUserGroupService
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public UserGroupService(
        DataContext context,
        IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public CResponse<IEnumerable<UserGroupModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public CResponse<UserGroupModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

     
        public CResponse<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        CResponse<IEnumerable<Models.UserGroupModel>> IService<Models.UserGroupModel>.GetAll()
        {
            throw new NotImplementedException();
        }

        CResponse<Models.UserGroupModel> IService<Models.UserGroupModel>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CResponse<Models.UserGroupModel> Create(CRequest<Models.UserGroupModel> model)
        {
            throw new NotImplementedException();
        }

        public CResponse<Models.UserGroupModel> Update(CRequest<Models.UserGroupModel> model)
        {
            throw new NotImplementedException();
        }
    }
}

 