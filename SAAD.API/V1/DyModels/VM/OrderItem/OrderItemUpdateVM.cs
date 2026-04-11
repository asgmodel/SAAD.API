using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// OrderItem  property for VM Update.
    /// </summary>
    public class OrderItemUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public OrderItemCreateVM? Body { get; set; }
    }
}