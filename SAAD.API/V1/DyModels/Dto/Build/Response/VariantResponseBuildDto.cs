using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Responses
{
    public class VariantResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// VariantId property for DTO.
        /// </summary>
        public String? VariantId { get; set; }
        /// <summary>
        /// Name property for DTO.
        /// </summary>
        public String? Name { get; set; }
        /// <summary>
        /// Price property for DTO.
        /// </summary>
        public Decimal Price { get; set; }
        /// <summary>
        /// OriginalPrice property for DTO.
        /// </summary>
        public Nullable<Decimal> OriginalPrice { get; set; }
        /// <summary>
        /// Stock property for DTO.
        /// </summary>
        public Int32 Stock { get; set; }
        /// <summary>
        /// ProductId property for DTO.
        /// </summary>
        public String? ProductId { get; set; }
        public ProductResponseBuildDto? Product { get; set; }
    }
}