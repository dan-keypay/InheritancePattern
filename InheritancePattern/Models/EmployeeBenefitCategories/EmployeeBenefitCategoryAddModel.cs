using System;
using System.Web.Mvc;
using InheritancePattern.ModelBinder;

namespace InheritancePattern.Models.EmployeeBenefitCategories
{
    [ModelBinder(typeof(EmployeeBenefitCategoryAddModelBinder))]
    public class EmployeeBenefitCategoryAddModel
    {
        public string Type { get; set; }
        public Guid? BenefitCategoryId { get; set; }
        public Guid? EmployeeId { get; set; }
        public decimal? CashEquivalent { get; set; }
    }
}