using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Event  property for VM Info.
    /// </summary>
    public class EventInfoVM : ITVM
    {
        ///
        public string? Id { get; set; }
    }
}