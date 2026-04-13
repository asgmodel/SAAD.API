using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using AutoGenerator.Config;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.Dto.Build.Requests
{
    public class ProductFileRequestBuildDto : ITBuildDto
    {
        /// <summary>
        /// ProductFileId property for DTO.
        /// </summary>
        public String? ProductFileId { get; set; }= "productfiled-" + Guid.NewGuid();
        /// <summary>
        /// ProductId property for DTO.
        /// </summary>
        public String? ProductId { get; set; }
        /// <summary>
        /// FileName property for DTO.
        /// </summary>
        public String? FileName { get; set; }
        /// <summary>
        /// FileUrl property for DTO.
        /// </summary>
        public String? FileUrl { get; set; }
        /// <summary>
        /// FileType property for DTO.
        /// </summary>
        public String? FileType { get; set; }
        /// <summary>
        /// FileSize property for DTO.
        /// </summary>
        public Int64 FileSize { get; set; }
        /// <summary>
        /// IsMainImage property for DTO.
        /// </summary>
        public Boolean IsMainImage { get; set; }
        /// <summary>
        /// UploadedAt property for DTO.
        /// </summary>
        public DateTime UploadedAt { get; set; }
        public ProductRequestBuildDto? Product { get; set; }
    }
}