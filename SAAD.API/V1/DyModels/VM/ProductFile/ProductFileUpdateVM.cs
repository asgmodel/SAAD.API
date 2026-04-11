using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// ProductFile  property for VM Update.
    /// </summary>
    public class ProductFileUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public ProductFileCreateVM? Body { get; set; }
    }
}