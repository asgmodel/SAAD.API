using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Category  property for VM Info.
    /// </summary>
    public class CategoryInfoVM : ITVM
    {
        ///
        public String? CategoryId { get; set; }
        ///
        public String? Name { get; set; }
        ///
        public String? Description { get; set; }
        ///
        public String? ImageUrl { get; set; }
        ///
        public String? VideoUrl { get; set; }
        ///
        public DateTime CreatedAt { get; set; }
        ///
        public Boolean IsActive { get; set; }
        //
        public List<CategoryMediaOutputVM>? CategoryMedia { get; set; }
        //
        public List<ProductOutputVM>? Products { get; set; }
    }
}