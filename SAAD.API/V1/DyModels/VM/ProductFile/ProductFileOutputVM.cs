using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// ProductFile  property for VM Output.
    /// </summary>
    public class ProductFileOutputVM : ITVM
    {
        ///
        public String? ProductFileId { get; set; }
        ///
        public Int32 ProductId { get; set; }
        ///
        public String? FileName { get; set; }
        ///
        public String? FileUrl { get; set; }
        ///
        public String? FileType { get; set; }
        ///
        public Int64 FileSize { get; set; }
        ///
        public Boolean IsMainImage { get; set; }
        ///
        public DateTime UploadedAt { get; set; }
        public ProductOutputVM? Product { get; set; }
    }
}