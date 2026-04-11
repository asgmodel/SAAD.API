using AutoGenerator;
using AutoGenerator.Conditions;
using AutoMapper;
using LAHJA.API.Data;
using System;
using V1.BPR.Layers.Base;

namespace V1.Validators.Conditions
{
    public interface ITFactoryInjector : ITBaseFactoryInjector
    {
        public LahjaDataContext Context { get; }
    }
}