using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Responses
{
    public class TransactionResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// TransactionId property for DTO.
        /// </summary>
        public String? TransactionId { get; set; }
        /// <summary>
        /// TransactionDate property for DTO.
        /// </summary>
        public DateTime TransactionDate { get; set; }
        /// <summary>
        /// Amount property for DTO.
        /// </summary>
        public Decimal Amount { get; set; }
        /// <summary>
        /// TransactionType property for DTO.
        /// </summary>
        public String? TransactionType { get; set; }
        /// <summary>
        /// PaymentMethod property for DTO.
        /// </summary>
        public String? PaymentMethod { get; set; }
        /// <summary>
        /// TransactionStatus property for DTO.
        /// </summary>
        public String? TransactionStatus { get; set; }
        /// <summary>
        /// ReferenceNumber property for DTO.
        /// </summary>
        public String? ReferenceNumber { get; set; }
        /// <summary>
        /// Notes property for DTO.
        /// </summary>
        public String? Notes { get; set; }
        /// <summary>
        /// OrderId property for DTO.
        /// </summary>
        public String? OrderId { get; set; }
        /// <summary>
        /// OperationId property for DTO.
        /// </summary>
        public String? OperationId { get; set; }
        /// <summary>
        /// UserId property for DTO.
        /// </summary>
        public String? UserId { get; set; }
        /// <summary>
        /// BankReference property for DTO.
        /// </summary>
        public String? BankReference { get; set; }
        /// <summary>
        /// CardLastFour property for DTO.
        /// </summary>
        public String? CardLastFour { get; set; }
        /// <summary>
        /// SettledAt property for DTO.
        /// </summary>
        public Nullable<DateTime> SettledAt { get; set; }
        public OrderResponseBuildDto? Order { get; set; }
        public OperationResponseBuildDto? Operation { get; set; }
        public UserResponseBuildDto? User { get; set; }
    }
}