namespace InheritancePattern.Models.EmployeeBenefitCategories
{
    public class PrivateMedicalEmployeeBenefitCategoryAddModel : EmployeeBenefitCategoryAddModel
    {
        public decimal? AmountForegone { get; set; }
        public decimal? AmountMadeGood { get; set; }
    }
}