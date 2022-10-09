using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UserGroupManager.Models;
using UserGroupManager.Services.UserGroupService;

namespace UserGroupManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateRequestController : ControllerBase
    {
      
        public CreateRequestController()
        {
 
        }

        [HttpGet]
        public IActionResult CreateGroupRequest( )
        {
            UserGroupModel userGroupModel = new UserGroupModel("GroupName", "imagePath",true);
  
            CRequest<UserGroupModel>  cModel = new CRequest<UserGroupModel>(data:userGroupModel  );

            
            return Ok(cModel);
 
        }
    }
    
    
}
