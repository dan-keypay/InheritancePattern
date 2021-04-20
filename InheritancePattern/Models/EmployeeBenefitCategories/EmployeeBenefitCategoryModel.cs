using System;

namespace InheritancePattern.Models.EmployeeBenefitCategories
{
    public class EmployeeBenefitCategoryModel
    {
        public Guid Id { get; set; }
        public Guid BenefitCategoryId { get; set; }
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public decimal CashEquivalent { get; set; }
    }
}