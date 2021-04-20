using System;

namespace Domain.EmployeeBenefitCategories
{
    public class CarEmployeeBenefitCategory : EmployeeBenefitCategory
    {
        public virtual DateTime AvailableFromDate { get; set; }
        public virtual DateTime? AvailableToDate { get; set; }
        public virtual bool EmployerProvidesFuel { get; set; }
        
        public virtual CarFuelEmployeeBenefitCategory Fuel { get; set; }
    }
}