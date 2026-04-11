using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// User  property for VM Update.
    /// </summary>
    public class UserUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public UserCreateVM? Body { get; set; }
    }
}