namespace InheritancePattern.Models.BenefitCategories
{
    public class CarsAndCarFuelBenefitCategoryModel : BenefitCategoryModel
    {
        public virtual string Registration { get; set; }
        public virtual decimal ListPrice { get; set; }
    }
}