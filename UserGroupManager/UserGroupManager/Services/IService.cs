using System;
using UserGroupManager.Models;

namespace Services
{
    public interface IService<T>
    {
       CResponse< IEnumerable<T>> GetAll();
       CResponse<T> GetById(int id);
       CResponse<T> Create(CRequest<T> model);
       CResponse<T> Update(CRequest<T> model);
       CResponse<bool> Delete(int id);
    }
}

