using System.Web.Mvc;
using InheritancePattern.ModelBinder;

namespace InheritancePattern.Models.BenefitCategories
{
    [ModelBinder(typeof(BenefitCategoryAddModelBinder))]
    public abstract class BenefitCategoryAddModel
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }
}