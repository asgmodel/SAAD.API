using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Responses
{
    public class ProductResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// ProductId property for DTO.
        /// </summary>
        public String? ProductId { get; set; }
        /// <summary>
        /// Name property for DTO.
        /// </summary>
        public String? Name { get; set; }
        /// <summary>
        /// Description property for DTO.
        /// </summary>
        public String? Description { get; set; }
        /// <summary>
        /// Currency property for DTO.
        /// </summary>
        public String? Currency { get; set; }
        /// <summary>
        /// ImageUrl property for DTO.
        /// </summary>
        public String? ImageUrl { get; set; }
        public ICollection<String>? Images { get; set; }
        /// <summary>
        /// Category property for DTO.
        /// </summary>
        public String? Category { get; set; }
        /// <summary>
        /// CategoryId property for DTO.
        /// </summary>
        public String? CategoryId { get; set; }
        /// <summary>
        /// SKU property for DTO.
        /// </summary>
        public String? SKU { get; set; }
        /// <summary>
        /// Brand property for DTO.
        /// </summary>
        public String? Brand { get; set; }
        /// <summary>
        /// InteractionCount property for DTO.
        /// </summary>
        public Int32 InteractionCount { get; set; }
        /// <summary>
        /// OfferType property for DTO.
        /// </summary>
        public String? OfferType { get; set; }
        /// <summary>
        /// OfferEndDate property for DTO.
        /// </summary>
        public string? OfferEndDate { get; set; }
        /// <summary>
        /// IsActive property for DTO.
        /// </summary>
        public Boolean IsActive { get; set; }
        /// <summary>
        /// CreatedAt property for DTO.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        public ICollection<VariantResponseBuildDto>? Variants { get; set; }
        public ICollection<ProductFileResponseBuildDto>? ProductFiles { get; set; }
        public ICollection<ProductReviewResponseBuildDto>? ProductReviews { get; set; }
    }
}