using System;

namespace InheritancePattern.Models.EmployeeBenefitCategories
{
    public class CarFuelEmployeeBenefitCategoryAddModel : EmployeeBenefitCategoryAddModel
    {
        public Guid? CarEmployeeBenefitCategoryId { get; set; }
        public DateTime? AvailableFromDate { get; set; }
        public DateTime? AvailableToDate { get; set; }
    }
}