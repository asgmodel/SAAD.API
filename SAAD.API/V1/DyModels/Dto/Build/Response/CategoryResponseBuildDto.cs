using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Responses
{
    public class CategoryResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// CategoryId property for DTO.
        /// </summary>
        public String? CategoryId { get; set; }
        /// <summary>
        /// Name property for DTO.
        /// </summary>
        public String? Name { get; set; }
        /// <summary>
        /// Description property for DTO.
        /// </summary>
        public String? Description { get; set; }
        /// <summary>
        /// ImageUrl property for DTO.
        /// </summary>
        public String? ImageUrl { get; set; }
        /// <summary>
        /// VideoUrl property for DTO.
        /// </summary>
        public String? VideoUrl { get; set; }
        /// <summary>
        /// CreatedAt property for DTO.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// IsActive property for DTO.
        /// </summary>
        public Boolean IsActive { get; set; }
        public ICollection<CategoryMediaResponseBuildDto>? CategoryMedia { get; set; }
        public ICollection<ProductResponseBuildDto>? Products { get; set; }
    }
}