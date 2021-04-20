namespace Domain.BenefitCategories
{
    public class CarsAndCarFuelBenefitCategory : BenefitCategory
    {
        public virtual string Registration { get; set; }
        public virtual decimal ListPrice { get; set; }
    }
}