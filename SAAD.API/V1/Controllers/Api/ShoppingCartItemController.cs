using AutoMapper;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using V1.Repositories.Builder;
using Microsoft.AspNetCore.Mvc;
using V1.DyModels.VMs;
using System.Linq.Expressions;
using V1.DyModels.Dto.Build.Requests;
using V1.DyModels.Dto.Build.Responses;
using AutoGenerator.Helper.Translation;
using System;
using V1.BPR.Layers.Base;

namespace V1.Controllers.Api
{
    //[ApiExplorerSettings(GroupName = "V1")]
    [Route("api/V1/[controller]")]
    [ApiController]
    public class ShoppingCartItemController : BaseBPRControllerLayer<ShoppingCartItemRequestBuildDto, ShoppingCartItemResponseBuildDto, ShoppingCartItemCreateVM, ShoppingCartItemOutputVM, ShoppingCartItemUpdateVM, ShoppingCartItemInfoVM, ShoppingCartItemDeleteVM, ShoppingCartItemFilterVM>
    {
        private readonly ShoppingCartItemBuilderRepository _service;
        public ShoppingCartItemController(IMapper mapper, ILoggerFactory logger, ShoppingCartItemBuilderRepository bPR) : base(mapper, logger, bPR)
        {
            _service = bPR;
        }
    }
}