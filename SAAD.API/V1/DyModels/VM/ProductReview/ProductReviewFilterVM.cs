using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// ProductReview  property for VM Filter.
    /// </summary>
    public class ProductReviewFilterVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public string? Lg { get; set; }
    }
}