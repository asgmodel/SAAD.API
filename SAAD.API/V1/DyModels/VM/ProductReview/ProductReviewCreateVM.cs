using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// ProductReview  property for VM Create.
    /// </summary>
    public class ProductReviewCreateVM : ITVM
    {
        ///
        //public String? ProductReviewId { get; set; }
        ///
        public String? UserId { get; set; }
        ///
        public Int32 Rating { get; set; }
        ///
        public String? Comment { get; set; }
        ///
        public String? UserName { get; set; }
        ///
        public Boolean IsApproved { get; set; }
        ///
        public DateTime CreatedAt { get; set; }
        ///
        public String? ProductId { get; set; }
    // public ProductCreateVM? Product { get; set; }
    }
}