using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// User  property for VM Delete.
    /// </summary>
    public class UserDeleteVM : ITVM
    {
        ///
        public string? Id { get; set; }
    }
}