using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// OrderItem  property for VM Output.
    /// </summary>
    public class OrderItemOutputVM : ITVM
    {
        ///
        public String? OrderItemId { get; set; }
        ///
        public String? OrderId { get; set; }
        ///
        public String? ProductId { get; set; }
        ///
        public Int32 Quantity { get; set; }
        ///
        public Decimal UnitPrice { get; set; }
        ///
        public Decimal Discount { get; set; }
        ///
        public Decimal TotalPrice { get; set; }
        //public OrderOutputVM? Order { get; set; }
        public ProductOutputVM? Product { get; set; }
    }
}