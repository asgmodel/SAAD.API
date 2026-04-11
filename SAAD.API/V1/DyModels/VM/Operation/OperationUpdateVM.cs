using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Operation  property for VM Update.
    /// </summary>
    public class OperationUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public OperationCreateVM? Body { get; set; }
    }
}