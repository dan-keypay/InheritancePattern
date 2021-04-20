using System;

namespace InheritancePattern.Models.EmployeeBenefitCategories
{
    public class CarEmployeeBenefitCategoryModel : EmployeeBenefitCategoryModel
    {
        public DateTime AvailableFromDate { get; set; }
        public DateTime? AvailableToDate { get; set; }

        public bool EmployerProvidesFuel { get; set; }
    }
}