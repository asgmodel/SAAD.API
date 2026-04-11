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
    /// Category class property for BuilderRepository.
    /// </summary>
     //
    public class CategoryBuilderRepository : BaseBuilderRepository<Category, CategoryRequestBuildDto, CategoryResponseBuildDto>, ICategoryBuilderRepository<CategoryRequestBuildDto, CategoryResponseBuildDto>, ITBuilder
    {
        /// <summary>
        /// Constructor for CategoryBuilderRepository.
        /// </summary>
        public CategoryBuilderRepository(LahjaDataContext dbContext, IMapper mapper, ILoggerFactory logger) : base(dbContext, mapper, logger) // Initialize  constructor.
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