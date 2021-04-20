using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using FluentValidation;

namespace InheritancePattern.Installers
{
    public class ValidatorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Types.FromThisAssembly()
                .BasedOn(typeof (IValidator<>))
                .WithService.AllInterfaces()
                .Configure(x=>x.LifestyleSingleton())); // These were once configured as transient, but validators can be cached by MVC so changed to singleton
        }
    }
}