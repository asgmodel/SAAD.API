using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Responses
{
    public class CategoryMediaResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// CategoryMediaId property for DTO.
        /// </summary>
        public String? CategoryMediaId { get; set; }
        /// <summary>
        /// CategoryId property for DTO.
        /// </summary>
        public Int32 CategoryId { get; set; }
        /// <summary>
        /// MediaUrl property for DTO.
        /// </summary>
        public String? MediaUrl { get; set; }
        /// <summary>
        /// MediaType property for DTO.
        /// </summary>
        public String? MediaType { get; set; }
        /// <summary>
        /// Title property for DTO.
        /// </summary>
        public String? Title { get; set; }
        /// <summary>
        /// DisplayOrder property for DTO.
        /// </summary>
        public Int32 DisplayOrder { get; set; }
        public CategoryResponseBuildDto? Category { get; set; }
    }
}