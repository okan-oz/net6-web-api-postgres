using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserGroupManager.Entities;
using UserGroupManager.Models;
using UserGroupManager.Services.UserGroupService;

namespace UserGroupManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGroupController : ControllerBase
    {
        private IUserGroupService _userGroupService;
        private IMapper _mapper;

        public UserGroupController(IUserGroupService userService, IMapper mapper)
        {
            _userGroupService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Create(CRequest<UserGroupModel> model)
        {
            _userGroupService.Create(model);
            return Ok(new { message = "User created" });
        }
    }
}
