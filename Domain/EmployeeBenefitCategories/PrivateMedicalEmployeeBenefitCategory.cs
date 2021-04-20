namespace Domain.EmployeeBenefitCategories
{
    public class PrivateMedicalEmployeeBenefitCategory : EmployeeBenefitCategory
    {
        public virtual decimal AmountForegone { get; set; }
        public virtual decimal AmountMadeGood { get; set; }
    }
}