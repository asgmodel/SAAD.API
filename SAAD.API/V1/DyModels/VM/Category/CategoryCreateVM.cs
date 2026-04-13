using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Category  property for VM Create.
    /// </summary>
    public class CategoryCreateVM : ITVM
    {
        ///
        
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
      
    }
}