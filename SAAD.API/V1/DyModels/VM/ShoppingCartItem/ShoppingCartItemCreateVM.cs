using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// ShoppingCartItem  property for VM Create.
    /// </summary>
    public class ShoppingCartItemCreateVM : ITVM
    {
        ///
        //public String? ShoppingCartItemId { get; set; }
        ///
        public String? UserId { get; set; }
        ///
        public String? ProductId { get; set; }
        ///
        public Int32 Quantity { get; set; }
        ///
        public DateTime AddedAt { get; set; }
    // public UserCreateVM? User { get; set; }
    // public ProductCreateVM? Product { get; set; }
    }
}