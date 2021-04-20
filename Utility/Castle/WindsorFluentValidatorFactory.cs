using System;
using Castle.MicroKernel;
using FluentValidation;

namespace Utility.Castle
{
    public class WindsorFluentValidatorFactory : ValidatorFactoryBase
    {
        private readonly IKernel kernel;

        public WindsorFluentValidatorFactory(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public override IValidator CreateInstance(Type validatorType)
        {
            return kernel.HasComponent(validatorType) ? kernel.Resolve(validatorType) as IValidator : null;
        }
    }
}