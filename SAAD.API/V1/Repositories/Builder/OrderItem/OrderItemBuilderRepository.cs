using AutoMapper;
using LAHJA.API.Data;
using SADA.API.Models;
using V1.Repositories.Base;
using AutoGenerator.Repositories.Builder;
using V1.DyModels.Dto.Build.Requests;
using V1.DyModels.Dto.Build.Responses;
using AutoGenerator;
using AutoGenerator.Repositories.Base;
using System;
using V1.BPR.Layers.Base;

namespace V1.Repositories.Builder
{
    /// <summary>
    /// OrderItem class property for BuilderRepository.
    /// </summary>
     //
    public class OrderItemBuilderRepository : BaseBuilderRepository<OrderItem, OrderItemRequestBuildDto, OrderItemResponseBuildDto>, IOrderItemBuilderRepository<OrderItemRequestBuildDto, OrderItemResponseBuildDto>, ITBuilder
    {
        /// <summary>
        /// Constructor for OrderItemBuilderRepository.
        /// </summary>
        public OrderItemBuilderRepository(LahjaDataContext dbContext, IMapper mapper, ILoggerFactory logger) : base(dbContext, mapper, logger) // Initialize  constructor.
        {
        // Initialize necessary fields or call base constructor.
        ///
        /// 
         
        /// 
        }
    //
    // Add additional methods or properties as needed.
    }
}