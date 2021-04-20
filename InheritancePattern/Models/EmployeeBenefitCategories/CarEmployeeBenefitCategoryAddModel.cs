using System;

namespace InheritancePattern.Models.EmployeeBenefitCategories
{
    public class CarEmployeeBenefitCategoryAddModel : EmployeeBenefitCategoryAddModel
    {
        public DateTime? AvailableFromDate { get; set; }
        public DateTime? AvailableToDate { get; set; }

        public bool EmployerProvidesFuel { get; set; }

        public CarFuelEmployeeBenefitCategoryAddModel Fuel { get; set; }
    }
}