using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Requests
{
    public class ProductRequestBuildDto : ITBuildDto
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
        /// Price property for DTO.
        /// </summary>
        public Decimal Price { get; set; }
        /// <summary>
        /// StockQuantity property for DTO.
        /// </summary>
        public Int32 StockQuantity { get; set; }
        /// <summary>
        /// SKU property for DTO.
        /// </summary>
        public String? SKU { get; set; }
        /// <summary>
        /// Brand property for DTO.
        /// </summary>
        public String? Brand { get; set; }
        /// <summary>
        /// CategoryId property for DTO.
        /// </summary>
        public Int32 CategoryId { get; set; }
        /// <summary>
        /// CreatedAt property for DTO.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// IsActive property for DTO.
        /// </summary>
        public Boolean IsActive { get; set; }
        public CategoryRequestBuildDto? Category { get; set; }
        public ICollection<ProductFileRequestBuildDto>? ProductFiles { get; set; }
        public ICollection<ProductReviewRequestBuildDto>? ProductReviews { get; set; }
    }
}