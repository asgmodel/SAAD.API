using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Product  property for VM Output.
    /// </summary>
    public class ProductOutputVM : ITVM
    {
        ///
        public String? ProductId { get; set; }
        ///
        public String? Name { get; set; }
        ///
        public String? Description { get; set; }
        ///
        public String? Currency { get; set; }
        ///
        public String? ImageUrl { get; set; }
        //
        public List<String>? Images { get; set; }
        ///
        public String? Category { get; set; }
        ///
        public String? CategoryId { get; set; }
        ///
        public String? SKU { get; set; }
        ///
        public String? Brand { get; set; }
        ///
        public Int32 InteractionCount { get; set; }
        ///
        public String? OfferType { get; set; }
        ///
        public string? OfferEndDate { get; set; }
        ///
        public Boolean IsActive { get; set; }
        ///
        public DateTime CreatedAt { get; set; }
        //
        public List<VariantOutputVM>? Variants { get; set; }
        //
        public List<ProductFileOutputVM>? ProductFiles { get; set; }
        //
        public List<ProductReviewOutputVM>? ProductReviews { get; set; }
    }
}