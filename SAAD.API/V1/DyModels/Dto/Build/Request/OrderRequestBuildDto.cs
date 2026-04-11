using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Requests
{
    public class OrderRequestBuildDto : ITBuildDto
    {
        /// <summary>
        /// OrderId property for DTO.
        /// </summary>
        public String? OrderId { get; set; }
        /// <summary>
        /// UserId property for DTO.
        /// </summary>
        public Int32 UserId { get; set; }
        /// <summary>
        /// OrderDate property for DTO.
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// ShippingAddress property for DTO.
        /// </summary>
        public String? ShippingAddress { get; set; }
        /// <summary>
        /// ShippingCity property for DTO.
        /// </summary>
        public String? ShippingCity { get; set; }
        /// <summary>
        /// ShippingCountry property for DTO.
        /// </summary>
        public String? ShippingCountry { get; set; }
        /// <summary>
        /// ShippingZipCode property for DTO.
        /// </summary>
        public String? ShippingZipCode { get; set; }
        /// <summary>
        /// ShippingPhone property for DTO.
        /// </summary>
        public String? ShippingPhone { get; set; }
        /// <summary>
        /// TotalAmount property for DTO.
        /// </summary>
        public Decimal TotalAmount { get; set; }
        /// <summary>
        /// ShippingCost property for DTO.
        /// </summary>
        public Decimal ShippingCost { get; set; }
        /// <summary>
        /// TaxAmount property for DTO.
        /// </summary>
        public Decimal TaxAmount { get; set; }
        /// <summary>
        /// DiscountAmount property for DTO.
        /// </summary>
        public Decimal DiscountAmount { get; set; }
        /// <summary>
        /// OrderStatus property for DTO.
        /// </summary>
        public String? OrderStatus { get; set; }
        /// <summary>
        /// PaymentStatus property for DTO.
        /// </summary>
        public String? PaymentStatus { get; set; }
        /// <summary>
        /// TrackingNumber property for DTO.
        /// </summary>
        public String? TrackingNumber { get; set; }
        /// <summary>
        /// ShippedAt property for DTO.
        /// </summary>
        public Nullable<DateTime> ShippedAt { get; set; }
        /// <summary>
        /// DeliveredAt property for DTO.
        /// </summary>
        public Nullable<DateTime> DeliveredAt { get; set; }
        public UserRequestBuildDto? User { get; set; }
        public ICollection<OrderItemRequestBuildDto>? OrderItems { get; set; }
        public ICollection<TransactionRequestBuildDto>? Transactions { get; set; }
    }
}