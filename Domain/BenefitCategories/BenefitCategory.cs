using System.Collections.Generic;
using Domain.EmployeeBenefitCategories;

namespace Domain.BenefitCategories
{
    public abstract class BenefitCategory : Entity
    {
        public virtual int Year { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<EmployeeBenefitCategory> LinkedEmployees { get; set; }
    }
}