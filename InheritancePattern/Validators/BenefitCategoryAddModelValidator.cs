using FluentValidation;
using InheritancePattern.Models.BenefitCategories;

namespace InheritancePattern.Validators
{
    public class BenefitCategoryAddModelValidator : AbstractValidator<BenefitCategoryAddModel>
    {
        public BenefitCategoryAddModelValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(10);
        }
    }
}