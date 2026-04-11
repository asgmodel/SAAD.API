using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Operation  property for VM Output.
    /// </summary>
    public class OperationOutputVM : ITVM
    {
        ///
        public String? OperationId { get; set; }
        ///
        public String? OperationName { get; set; }
        ///
        public DateTime ExecutionTime { get; set; }
        ///
        public Nullable<DateTime> CompletionTime { get; set; }
        ///
        public String? Status { get; set; }
        ///
        public String? LogDetails { get; set; }
        ///
        public Nullable<Int32> EventId { get; set; }
        ///
        public Nullable<Int32> UserId { get; set; }
        ///
        public Nullable<Int32> RetryCount { get; set; }
        ///
        public String? ErrorMessage { get; set; }
        public EventOutputVM? Event { get; set; }
        public UserOutputVM? User { get; set; }
        //
        public List<TransactionOutputVM>? Transactions { get; set; }
    }
}