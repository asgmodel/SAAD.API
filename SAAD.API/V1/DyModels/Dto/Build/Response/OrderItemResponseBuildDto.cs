using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Responses
{
    public class OrderItemResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// OrderItemId property for DTO.
        /// </summary>
        public String? OrderItemId { get; set; }
        /// <summary>
        /// OrderId property for DTO.
        /// </summary>
        public String? OrderId { get; set; }
        /// <summary>
        /// ProductId property for DTO.
        /// </summary>
        public String? ProductId { get; set; }
        /// <summary>
        /// Quantity property for DTO.
        /// </summary>
        public Int32 Quantity { get; set; }
        /// <summary>
        /// UnitPrice property for DTO.
        /// </summary>
        public Decimal UnitPrice { get; set; }
        /// <summary>
        /// Discount property for DTO.
        /// </summary>
        public Decimal Discount { get; set; }
        /// <summary>
        /// TotalPrice property for DTO.
        /// </summary>
        public Decimal TotalPrice { get; set; }
        public OrderResponseBuildDto? Order { get; set; }
        public ProductResponseBuildDto? Product { get; set; }
    }
}