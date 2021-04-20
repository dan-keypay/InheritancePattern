using System;

namespace InheritancePattern.Models.EmployeeBenefitCategories
{
    public class CarFuelEmployeeBenefitCategoryModel : EmployeeBenefitCategoryModel
    {
        public Guid CarEmployeeBenefitCategoryId { get; set; }
        public DateTime? AvailableFromDate { get; set; }
        public DateTime? AvailableToDate { get; set; }
    }
}