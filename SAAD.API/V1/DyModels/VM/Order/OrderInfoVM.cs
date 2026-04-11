using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Order  property for VM Info.
    /// </summary>
    public class OrderInfoVM : ITVM
    {
        ///
        public string? Id { get; set; }
    }
}