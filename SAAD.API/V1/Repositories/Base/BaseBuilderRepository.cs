using LAHJA.API.Data;
using SADA.API.Models;
using AutoMapper;
using AutoGenerator;
using AutoGenerator.Repositories.Builder;
using System;
using V1.BPR.Layers.Base;

namespace V1.Repositories.Base
{
    /// <summary>
    /// BaseRepository class for ShareRepository.
    /// </summary>
    public abstract class BaseBuilderRepository<TModel, TBuildRequestDto, TBuildResponseDto> : BaseBPRLayer<TBuildRequestDto, TBuildResponseDto, TModel, TModel, ITBase, ITModel>, IBPRLayer<TBuildRequestDto, TBuildResponseDto>, ITBuildRepository, IBaseBuilderRepository<TBuildRequestDto, TBuildResponseDto> where TModel : class where TBuildRequestDto : class where TBuildResponseDto : class
    {
        protected BaseBuilderRepository(LahjaDataContext dbContext, IMapper mapper, ILoggerFactory logger) : this(dbContext, mapper, logger, new BaseBPRRepository<TModel>(dbContext, logger))
        {
        }

        protected BaseBuilderRepository(LahjaDataContext dbContext, IMapper mapper, ILoggerFactory logger, BaseBPRRepository<TModel> bpr) : base(mapper, logger, bpr)
        {
        }
    }
}