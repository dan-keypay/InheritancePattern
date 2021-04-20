using System;
using System.Web.Mvc;
using Domain.BenefitCategories;
using InheritancePattern.Models.BenefitCategories;

namespace InheritancePattern.ModelBinder
{
    public class BenefitCategoryAddModelBinder : DefaultModelBinder
    {
        protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
        {
            var typeValue = (BenefitCategoryType)Enum.Parse(typeof(BenefitCategoryType), (string)bindingContext.ValueProvider.GetValue("Type").ConvertTo(typeof(string)));
            Type type;
            if (modelType == typeof(BenefitCategoryAddModel))
            {
                switch (typeValue)
                {
                    case BenefitCategoryType.CarsAndCarFuel:
                        type = typeof(CarsAndCarFuelBenefitCategoryAddModel);
                        break;
                    case BenefitCategoryType.PrivateMedical:
                        type = typeof(PrivateMedicalBenefitCategoryAddModel);
                        break;
                    default:
                        return base.CreateModel(controllerContext, bindingContext, modelType);
                }
            }
            else
            {
                return base.CreateModel(controllerContext, bindingContext, modelType);
            }
            
            var model = Activator.CreateInstance(type);
            bindingContext.ModelMetadata = ModelMetadataProviders.Current.GetMetadataForType(() => model, type);
            return model;
        }
    }
}