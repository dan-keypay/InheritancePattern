namespace InheritancePattern.Models.BenefitCategories
{
    public class CarsAndCarFuelBenefitCategoryAddModel : BenefitCategoryAddModel
    {
        public string Registration { get; set; }
        public decimal? ListPrice { get; set; }
    }
}