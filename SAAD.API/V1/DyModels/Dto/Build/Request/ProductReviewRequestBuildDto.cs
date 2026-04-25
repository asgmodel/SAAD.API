using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Requests
{
    public class ProductReviewRequestBuildDto : ITBuildDto
    {
        /// <summary>
        /// ProductReviewId property for DTO.
        /// </summary>
        public String? ProductReviewId { get; set; } = $"ProductReview_{Guid.NewGuid().ToString()}";
        /// <summary>
        /// UserId property for DTO.
        /// </summary>
        public String? UserId { get; set; }
        /// <summary>
        /// Rating property for DTO.
        /// </summary>
        public Int32 Rating { get; set; }
        /// <summary>
        /// Comment property for DTO.
        /// </summary>
        public String? Comment { get; set; }
        /// <summary>
        /// UserName property for DTO.
        /// </summary>
        public String? UserName { get; set; }
        /// <summary>
        /// IsApproved property for DTO.
        /// </summary>
        public Boolean IsApproved { get; set; }
        /// <summary>
        /// CreatedAt property for DTO.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// ProductId property for DTO.
        /// </summary>
        public String? ProductId { get; set; }
        public ProductRequestBuildDto? Product { get; set; }
    }
}