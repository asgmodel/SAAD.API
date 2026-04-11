using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Category  property for VM Update.
    /// </summary>
    public class CategoryUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public CategoryCreateVM? Body { get; set; }
    }
}