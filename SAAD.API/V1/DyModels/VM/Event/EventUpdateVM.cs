using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Event  property for VM Update.
    /// </summary>
    public class EventUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public EventCreateVM? Body { get; set; }
    }
}