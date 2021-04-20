namespace InheritancePattern.Models.EmployeeBenefitCategories
{
    public class PrivateMedicalEmployeeBenefitCategoryModel : EmployeeBenefitCategoryModel
    {
        public decimal AmountForegone { get; set; }
        public decimal? AmountMadeGood { get; set; }
    }
}