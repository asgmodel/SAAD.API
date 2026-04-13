using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// CategoryMedia  property for VM Output.
    /// </summary>
    public class CategoryMediaOutputVM : ITVM
    {
        ///
        public String? CategoryMediaId { get; set; }
        ///
        public String? CategoryId { get; set; }
        ///
        public String? MediaUrl { get; set; }
        ///
        public String? MediaType { get; set; }
        ///
        public String? Title { get; set; }
        ///
        public Int32 DisplayOrder { get; set; }
        public CategoryOutputVM? Category { get; set; }
    }
}