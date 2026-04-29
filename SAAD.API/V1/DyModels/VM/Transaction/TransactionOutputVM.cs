using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Transaction  property for VM Output.
    /// </summary>
    public class TransactionOutputVM : ITVM
    {
        ///
        public String? TransactionId { get; set; }
        ///
        public DateTime TransactionDate { get; set; }
        ///
        public Decimal Amount { get; set; }
        ///
        public String? TransactionType { get; set; }
        ///
        public String? PaymentMethod { get; set; }
        ///
        public String? TransactionStatus { get; set; }
        ///
        public String? ReferenceNumber { get; set; }
        ///
        public String? Notes { get; set; }
        ///
        public String? OrderId { get; set; }
        ///
        public String? OperationId { get; set; }
        ///
        public String? UserId { get; set; }
        ///
        public String? BankReference { get; set; }
        ///
        public String? CardLastFour { get; set; }
        ///
        public Nullable<DateTime> SettledAt { get; set; }
        //public OrderOutputVM? Order { get; set; }
        //public OperationOutputVM? Operation { get; set; }
        //public UserOutputVM? User { get; set; }
    }
}