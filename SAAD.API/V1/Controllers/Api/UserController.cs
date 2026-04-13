using AutoGenerator.Helper.Translation;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Saad.API;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using V1.BPR.Layers.Base;
using V1.DyModels.Dto.Build.Requests;
using V1.DyModels.Dto.Build.Responses;
using V1.DyModels.VMs;
using V1.Repositories.Builder;

namespace V1.Controllers.Api
{
    //[ApiExplorerSettings(GroupName = "V1")]
    [Route("api/V1/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : BaseBPRControllerLayer<UserRequestBuildDto, UserResponseBuildDto, UserCreateVM, UserOutputVM, UserUpdateVM, UserInfoVM, UserDeleteVM, UserFilterVM>
    {
        private readonly IClientFactory _clientFactory;
        private readonly UserBuilderRepository _service;
        public UserController(IMapper mapper, ILoggerFactory logger, UserBuilderRepository bPR, IClientFactory clientFactory) : base(mapper, logger, bPR)
        {
            _service = bPR;
            _clientFactory = clientFactory ?? throw new ArgumentNullException(nameof(clientFactory));
        }
        [Authorize]
        [HttpGet("token")]
     
        public async Task<IActionResult> GetToken()
        {
            var result = await _clientFactory.gettoken();

            return Ok(result);
        }
    }
}