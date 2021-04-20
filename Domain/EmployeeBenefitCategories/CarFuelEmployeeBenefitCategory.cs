using System;

namespace Domain.EmployeeBenefitCategories
{
    public class CarFuelEmployeeBenefitCategory : EmployeeBenefitCategory
    {
        public virtual CarEmployeeBenefitCategory Car { get; set; }
        
        public virtual DateTime? AvailableFromDate { get; set; }
        public virtual DateTime? AvailableToDate { get; set; }
    }
}