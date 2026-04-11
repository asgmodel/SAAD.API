using AutoGenerator.Conditions;
using V1.Validators.Conditions;
using System;
using V1.BPR.Layers.Base;

namespace V1.Validators
{
    public interface IConditionChecker : IBaseConditionChecker
    {
        public ITFactoryInjector Injector { get; }
    }
}