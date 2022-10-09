using System;
namespace UserGroupManager.Models.Base
{
    public class Error
    {
        public Error()
        {
        }

       public String? VisibleMessage { get; set; }
       public bool ShowVisibleMessage { get; set; }
       public Exception? Exception { get; set; }
       public String? ExceptionDescription { get; set; }
       public String? ExceptionSource { get; set; }
            
    }
}

