using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// CategoryMedia  property for VM Update.
    /// </summary>
    public class CategoryMediaUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public CategoryMediaCreateVM? Body { get; set; }
    }
}