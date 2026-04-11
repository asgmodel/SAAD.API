using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// ProductReview  property for VM Update.
    /// </summary>
    public class ProductReviewUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public ProductReviewCreateVM? Body { get; set; }
    }
}