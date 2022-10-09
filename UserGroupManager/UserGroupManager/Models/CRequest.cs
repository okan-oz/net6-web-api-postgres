using System;
using UserGroupManager.Models.Base;

namespace UserGroupManager.Models
{
    public class CRequest<T>:BaseRequest<T>
    {
        public CRequest(T data):base(data)
        {
     
        }
    }
}

