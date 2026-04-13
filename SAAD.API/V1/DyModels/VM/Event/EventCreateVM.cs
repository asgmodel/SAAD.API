using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Event  property for VM Create.
    /// </summary>
    public class EventCreateVM : ITVM
    {
        ///
        //public String? EventId { get; set; }
        ///
        public String? EventName { get; set; }
        ///
        public String? EventType { get; set; }
        ///
        public DateTime EventDateTime { get; set; }
        ///
        public String? Source { get; set; }
        ///
        public String? Description { get; set; }
        ///
        public Nullable<Int32> TriggeredByUserId { get; set; }
        ///
        public String? TriggeredBySystem { get; set; }
        ///
        public String? Severity { get; set; }
        // public UserCreateVM? TriggeredByUser { get; set; }
        //
        //public List<OperationCreateVM>? Operations { get; set; }
    }
}