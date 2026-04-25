using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Variant  property for VM Output.
    /// </summary>
    public class VariantOutputVM : ITVM
    {
        ///
        public String? VariantId { get; set; }
        ///
        public String? Name { get; set; }
        ///
        public Decimal Price { get; set; }
        ///
        public Nullable<Decimal> OriginalPrice { get; set; }
        ///
        public Int32 Stock { get; set; }
        ///
        public String? ProductId { get; set; }
        public ProductOutputVM? Product { get; set; }
    }
}