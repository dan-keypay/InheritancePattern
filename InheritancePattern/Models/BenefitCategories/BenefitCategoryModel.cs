using System;

namespace InheritancePattern.Models.BenefitCategories
{
    public abstract class BenefitCategoryModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
}