
using System;
namespace UserGroupManager.Models.Base
{
    public class BaseRequest<T>
    {
        public BaseRequest(T? data)
        {
            this.data = data;
        }

        T? data;
        String requestId;
    }
}

