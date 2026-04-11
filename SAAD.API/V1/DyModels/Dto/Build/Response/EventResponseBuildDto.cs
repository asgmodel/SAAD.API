using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Responses
{
    public class EventResponseBuildDto : ITBuildDto
    {
        /// <summary>
        /// EventId property for DTO.
        /// </summary>
        public String? EventId { get; set; }
        /// <summary>
        /// EventName property for DTO.
        /// </summary>
        public String? EventName { get; set; }
        /// <summary>
        /// EventType property for DTO.
        /// </summary>
        public String? EventType { get; set; }
        /// <summary>
        /// EventDateTime property for DTO.
        /// </summary>
        public DateTime EventDateTime { get; set; }
        /// <summary>
        /// Source property for DTO.
        /// </summary>
        public String? Source { get; set; }
        /// <summary>
        /// Description property for DTO.
        /// </summary>
        public String? Description { get; set; }
        /// <summary>
        /// TriggeredByUserId property for DTO.
        /// </summary>
        public Nullable<Int32> TriggeredByUserId { get; set; }
        /// <summary>
        /// TriggeredBySystem property for DTO.
        /// </summary>
        public String? TriggeredBySystem { get; set; }
        /// <summary>
        /// Severity property for DTO.
        /// </summary>
        public String? Severity { get; set; }
        public UserResponseBuildDto? TriggeredByUser { get; set; }
        public ICollection<OperationResponseBuildDto>? Operations { get; set; }
    }
}