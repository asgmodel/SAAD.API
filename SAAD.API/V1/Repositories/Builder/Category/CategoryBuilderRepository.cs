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
using Microsoft.EntityFrameworkCore;
using AutoGenerator.Helper;

namespace V1.Repositories.Builder
{
    /// <summary>
    /// Category class property for BuilderRepository.
    /// </summary>
     //
    public class CategoryBuilderRepository : BaseBuilderRepository<Category, CategoryRequestBuildDto, CategoryResponseBuildDto>, ICategoryBuilderRepository<CategoryRequestBuildDto, CategoryResponseBuildDto>, ITBuilder
    {
        private readonly LahjaDataContext _context;
        public CategoryBuilderRepository(LahjaDataContext dbContext, IMapper mapper, ILoggerFactory logger) : base(dbContext, mapper, logger) // Initialize  constructor.
        {
            // Initialize necessary fields or call base constructor.
            ///
            /// 
            _context = dbContext;
            /// 
        }

        public override IQueryable<CategoryResponseBuildDto> GetQueryable()
        {
            return base.GetQueryable();
        }
        public override async Task<CategoryResponseBuildDto?> UpdateAsync(CategoryRequestBuildDto dto)
        {
            var category = await _context.Categories
                .FirstOrDefaultAsync(c => c.CategoryId == dto.CategoryId);

            if (category == null)
                return null;

            //  ÕœÌÀ «·»Ì«‰« 
            category.Name = dto.Name;
            category.Description = dto.Description;
            // ﬂ„· »«ﬁÌ «·Œ’«∆’

            await _context.SaveChangesAsync();

            //  ÕÊÌ· ≈·Ï DTO
            return new CategoryResponseBuildDto
            {
                CategoryId = category.CategoryId,
                Name = category.Name,
                Description = category.Description
            };
        }
    }
}