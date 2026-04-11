using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Responses
{
    public class OperationResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// OperationId property for DTO.
        /// </summary>
        public String? OperationId { get; set; }
        /// <summary>
        /// OperationName property for DTO.
        /// </summary>
        public String? OperationName { get; set; }
        /// <summary>
        /// ExecutionTime property for DTO.
        /// </summary>
        public DateTime ExecutionTime { get; set; }
        /// <summary>
        /// CompletionTime property for DTO.
        /// </summary>
        public Nullable<DateTime> CompletionTime { get; set; }
        /// <summary>
        /// Status property for DTO.
        /// </summary>
        public String? Status { get; set; }
        /// <summary>
        /// LogDetails property for DTO.
        /// </summary>
        public String? LogDetails { get; set; }
        /// <summary>
        /// EventId property for DTO.
        /// </summary>
        public Nullable<Int32> EventId { get; set; }
        /// <summary>
        /// UserId property for DTO.
        /// </summary>
        public Nullable<Int32> UserId { get; set; }
        /// <summary>
        /// RetryCount property for DTO.
        /// </summary>
        public Nullable<Int32> RetryCount { get; set; }
        /// <summary>
        /// ErrorMessage property for DTO.
        /// </summary>
        public String? ErrorMessage { get; set; }
        public EventResponseBuildDto? Event { get; set; }
        public UserResponseBuildDto? User { get; set; }
        public ICollection<TransactionResponseBuildDto>? Transactions { get; set; }
    }
}