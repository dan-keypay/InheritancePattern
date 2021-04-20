using System;
using Domain.BenefitCategories;

namespace Domain.EmployeeBenefitCategories
{
    public class EmployeeBenefitCategory : Entity
    {
        public virtual BenefitCategory BenefitCategory { get; set; }
        
        public virtual Guid EmployeeId { get; set; }
        public virtual decimal CashEquivalent { get; set; }
    }
}