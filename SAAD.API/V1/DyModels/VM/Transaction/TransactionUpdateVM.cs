using AutoGenerator;
using AutoGenerator.Helper.Translation;
using SADA.API.Models;
using System;
using V1.BPR.Layers.Base;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Transaction  property for VM Update.
    /// </summary>
    public class TransactionUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public TransactionCreateVM? Body { get; set; }
    }
}