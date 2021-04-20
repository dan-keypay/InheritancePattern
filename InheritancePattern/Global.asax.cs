using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using Castle.Core;
using Castle.Windsor;
using FluentValidation;
using FluentValidation.Mvc;
using InheritancePattern.AutoMapper;
using InheritancePattern.Installers;
using Utility.Castle;

namespace InheritancePattern
{
    public class MvcApplication : HttpApplication
    {
        public static IWindsorContainer Container { get; set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            FluentValidationModelValidatorProvider.Configure();

            Container = new WindsorContainer();
            Container.Kernel.ComponentModelCreated += model => model.LifestyleType = LifestyleType.PerWebRequest;
            Container.Install(
                new ValidatorInstaller()
            );

            Mapper.Initialize(x =>
            {
                x.AddProfile<BenefitCategoryProfile>();
                x.AddProfile<EmployeeBenefitCategoryProfile>();
            });
            ValidatorOptions.CascadeMode = CascadeMode.Continue;
            ModelValidatorProviders.Providers.Add(new FluentValidationModelValidatorProvider(new WindsorFluentValidatorFactory(Container.Kernel)));
            DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;
        }
    }
}