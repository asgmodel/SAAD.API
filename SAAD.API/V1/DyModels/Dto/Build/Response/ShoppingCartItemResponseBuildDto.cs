using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Responses
{
    public class ShoppingCartItemResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// ShoppingCartItemId property for DTO.
        /// </summary>
        public String? ShoppingCartItemId { get; set; }
        /// <summary>
        /// UserId property for DTO.
        /// </summary>
        public String? UserId { get; set; }
        /// <summary>
        /// ProductId property for DTO.
        /// </summary>
        public String? ProductId { get; set; }
        /// <summary>
        /// Quantity property for DTO.
        /// </summary>
        public Int32 Quantity { get; set; }
        /// <summary>
        /// AddedAt property for DTO.
        /// </summary>
        public DateTime AddedAt { get; set; }
        public UserResponseBuildDto? User { get; set; }
        public ProductResponseBuildDto? Product { get; set; }
    }
}