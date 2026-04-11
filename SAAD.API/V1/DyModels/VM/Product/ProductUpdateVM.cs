using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Product  property for VM Update.
    /// </summary>
    public class ProductUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public ProductCreateVM? Body { get; set; }
    }
}