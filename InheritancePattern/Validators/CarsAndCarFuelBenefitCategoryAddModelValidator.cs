using FluentValidation;
using InheritancePattern.Models;
using InheritancePattern.Models.BenefitCategories;

namespace InheritancePattern.Validators
{
    public class CarsAndCarFuelBenefitCategoryAddModelValidator : AbstractValidator<CarsAndCarFuelBenefitCategoryAddModel>
    {
        public CarsAndCarFuelBenefitCategoryAddModelValidator()
        {
            Include(new BenefitCategoryAddModelValidator());
            
            RuleFor(x => x.Registration)
                .NotEmpty();
            
            RuleFor(x => x.ListPrice)
                .NotEmpty()
                .GreaterThan(1000);
        }
    }
}