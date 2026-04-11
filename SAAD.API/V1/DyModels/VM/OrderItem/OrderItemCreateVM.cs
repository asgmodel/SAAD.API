using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// OrderItem  property for VM Create.
    /// </summary>
    public class OrderItemCreateVM : ITVM
    {
        ///
        public String? OrderItemId { get; set; }
        ///
        public Int32 OrderId { get; set; }
        ///
        public Int32 ProductId { get; set; }
        ///
        public Int32 Quantity { get; set; }
        ///
        public Decimal UnitPrice { get; set; }
        ///
        public Decimal Discount { get; set; }
        ///
        public Decimal TotalPrice { get; set; }
    // public OrderCreateVM? Order { get; set; }
    // public ProductCreateVM? Product { get; set; }
    }
}