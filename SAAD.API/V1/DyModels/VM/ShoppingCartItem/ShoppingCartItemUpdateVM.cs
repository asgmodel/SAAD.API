using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// ShoppingCartItem  property for VM Update.
    /// </summary>
    public class ShoppingCartItemUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public ShoppingCartItemCreateVM? Body { get; set; }
    }
}