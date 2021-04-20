using FluentValidation;
using InheritancePattern.Models;
using InheritancePattern.Models.BenefitCategories;

namespace InheritancePattern.Validators
{
    public class PrivateMedicalBenefitCategoryAddModelValidator : AbstractValidator<PrivateMedicalBenefitCategoryAddModel>
    {
        public PrivateMedicalBenefitCategoryAddModelValidator()
        {
            Include(new BenefitCategoryAddModelValidator());
            
            RuleFor(x => x.AmountForegone)
                .GreaterThan(10);
        }
    }
}