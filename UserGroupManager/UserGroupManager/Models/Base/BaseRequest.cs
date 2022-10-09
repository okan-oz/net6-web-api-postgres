
using System;
using Newtonsoft.Json;

namespace UserGroupManager.Models.Base
{
    public class BaseRequest<T>
    {
        public BaseRequest(T data)
        {
            this.Data = data;
            this.RequestId = Guid.NewGuid().ToString();
        }

 
      public T Data { get; set; }
 
      public  String RequestId { get; set; }
    }
}

