using System;
namespace UserGroupManager.Models.Base
{
    public class BaseResponse<T>
    {
        public BaseResponse ()
        {
        }

        public  T? Data { get; set; }
        public bool IsSuccess { get; set; } 
        public string RequestId { get; set; } = null!;
        public CError? Error { get; set; }

    }
}

