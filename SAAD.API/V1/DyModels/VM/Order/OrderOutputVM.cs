using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Order  property for VM Output.
    /// </summary>
    public class OrderOutputVM : ITVM
    {
        ///
        public String? OrderId { get; set; }
        ///
        public Int32 UserId { get; set; }
        ///
        public DateTime OrderDate { get; set; }
        ///
        public String? ShippingAddress { get; set; }
        ///
        public String? ShippingCity { get; set; }
        ///
        public String? ShippingCountry { get; set; }
        ///
        public String? ShippingZipCode { get; set; }
        ///
        public String? ShippingPhone { get; set; }
        ///
        public Decimal TotalAmount { get; set; }
        ///
        public Decimal ShippingCost { get; set; }
        ///
        public Decimal TaxAmount { get; set; }
        ///
        public Decimal DiscountAmount { get; set; }
        ///
        public String? OrderStatus { get; set; }
        ///
        public String? PaymentStatus { get; set; }
        ///
        public String? TrackingNumber { get; set; }
        ///
        public Nullable<DateTime> ShippedAt { get; set; }
        ///
        public Nullable<DateTime> DeliveredAt { get; set; }
        public UserOutputVM? User { get; set; }
        //
        public List<OrderItemOutputVM>? OrderItems { get; set; }
        //
        public List<TransactionOutputVM>? Transactions { get; set; }
    }
}