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
    public class CategoryValidatorContext : ValidatorContext<Category, CategoryValidatorStates>, ITValidator
    {
        public CategoryValidatorContext(IConditionChecker checker) : base(checker)
        {
        }

        protected override void InitializeConditions()
        {
        }
    } //
    //  Base
    public  enum  CategoryValidatorStates //
    { IsActive ,  IsFull ,  IsValid ,  //
    }

}