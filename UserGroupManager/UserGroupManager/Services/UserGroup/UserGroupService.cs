using System;
using AutoMapper;
using Services;
using UserGroupManager.Models;
using UserGroupManager.Repository;
using Microsoft.EntityFrameworkCore;
using UserGroupManager.Entities;

namespace UserGroupManager.Services.UserGroupService
{
    public class UserGroupService : IUserGroupService
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
            try
            {
                var userGroupEntity = _mapper.Map<UserGroupEntity>(model.Data);
                userGroupEntity.Id = Guid.NewGuid().ToString();
                userGroupEntity.CreatedTime = DateTime.Now;
                userGroupEntity.CreatedBy = "CreatedBy todo";
                _context.UserGroup.Add(userGroupEntity);
                _context.SaveChanges();

                return new CResponse<UserGroupModel>
                {
                    Data = model.Data,
                    IsSuccess = true,
                    RequestId = model.RequestId
                };
            }
            catch (Exception ex)
            {

                return new CResponse<UserGroupModel>
                {
                    Data = model.Data,
                    IsSuccess = false,
                    RequestId = model.RequestId,
                    Error = new Models.Base.Error
                    {
                        Exception = ex,
                        ExceptionDescription = $"User Grup eklenirken hata oldu.Eklenmek istenen User Group ismi :{model.Data.Name}, hata detayı:{ex.Message}",
                        ExceptionSource = "UserGroupService.Create",
                        ShowVisibleMessage = true,
                        VisibleMessage = "Beklenmedik bir hata oldu, daha sonra tekrar deneyiniz!"
                    }
                };
            }

        }

        public CResponse<Models.UserGroupModel> Update(CRequest<Models.UserGroupModel> model)
        {
            throw new NotImplementedException();
        }
    }
}

