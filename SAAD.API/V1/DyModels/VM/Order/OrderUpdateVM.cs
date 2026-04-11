using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Order  property for VM Update.
    /// </summary>
    public class OrderUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public OrderCreateVM? Body { get; set; }
    }
}