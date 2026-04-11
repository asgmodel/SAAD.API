using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Transaction  property for VM Create.
    /// </summary>
    public class TransactionCreateVM : ITVM
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
        public Int32 OrderId { get; set; }
        ///
        public Nullable<Int32> OperationId { get; set; }
        ///
        public Int32 UserId { get; set; }
        ///
        public String? BankReference { get; set; }
        ///
        public String? CardLastFour { get; set; }
        ///
        public Nullable<DateTime> SettledAt { get; set; }
    // public OrderCreateVM? Order { get; set; }
    // public OperationCreateVM? Operation { get; set; }
    // public UserCreateVM? User { get; set; }
    }
}