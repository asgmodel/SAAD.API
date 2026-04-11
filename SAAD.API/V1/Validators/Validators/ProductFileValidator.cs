using AutoGenerator;
using AutoGenerator.Helper.Translation;
using AutoGenerator.Conditions;
using V1.Validators.Conditions;
using SADA.API.Models;
using V1.Validators.Conditions;
using WasmAI.ConditionChecker.Base;
using System;
using V1.BPR.Layers.Base;

namespace V1.Validators
{
    public class ProductFileValidatorContext : ValidatorContext<ProductFile, ProductFileValidatorStates>, ITValidator
    {
        public ProductFileValidatorContext(IConditionChecker checker) : base(checker)
        {
        }

        protected override void InitializeConditions()
        {
        }
    } //
    //  Base
    public  enum  ProductFileValidatorStates //
    { IsActive ,  IsFull ,  IsValid ,  //
    }

}