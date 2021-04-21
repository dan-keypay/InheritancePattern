using System;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Domain;
using Domain.BenefitCategories;
using Domain.EmployeeBenefitCategories;
using InheritancePattern.Models.BenefitCategories;
using InheritancePattern.Models.EmployeeBenefitCategories;
using Utility.Persistence;

namespace InheritancePattern.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                ViewBag.Models = session.QueryOver<SimpleDomain>()
                    .List();

                ViewBag.BenefitCategories = session.QueryOver<BenefitCategory>()
                    .List()
                    .Select(Mapper.Map<BenefitCategory, BenefitCategoryModel>);

                var employeeBenefitCategories = session.QueryOver<EmployeeBenefitCategory>()
                    .Fetch(e => e.BenefitCategory).Eager
                    .List();
                var employeeBenefitCategoryModels = employeeBenefitCategories
                    .Select(Mapper.Map<EmployeeBenefitCategory, EmployeeBenefitCategoryModel>);
                var employeeBenefitCategoryModelsList = employeeBenefitCategoryModels.ToList();
                ViewBag.EmployeeBenefitCategories = employeeBenefitCategoryModelsList;

                return View();
            }
        }

        [HttpPost]
        public ActionResult Add(BenefitCategoryAddModel model)
        {
            if (!ModelState.IsValid)
            {
                return JsonError(ModelErrors);
            }


            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var benefitCategory = Mapper.Map<BenefitCategoryAddModel, BenefitCategory>(model);

                    // Get specific add command
                    session.Save(benefitCategory);
                    session.Flush();

                    transaction.Commit();

                    return JsonSuccess(Mapper.Map<BenefitCategory, BenefitCategoryModel>(benefitCategory));
                }
            }
        }

        [HttpPost]
        public ActionResult AddEmployee(EmployeeBenefitCategoryAddModel model)
        {
            if (!ModelState.IsValid)
            {
                return JsonError(ModelErrors);
            }


            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    // Get specific add command
                    var employeeBenefitCategory = Mapper.Map<EmployeeBenefitCategoryAddModel, EmployeeBenefitCategory>(model);

                    var benefitCategory = session.QueryOver<BenefitCategory>()
                        .Where(x => x.Id == model.BenefitCategoryId)
                        .SingleOrDefault();

                    if (benefitCategory == null)
                    {
                        throw new ArgumentException("Invalid benefit category");
                    }

                    employeeBenefitCategory.BenefitCategory = benefitCategory;

                    if (employeeBenefitCategory is CarEmployeeBenefitCategory carEmployeeBenefitCategory && carEmployeeBenefitCategory.EmployerProvidesFuel)
                    {
                        carEmployeeBenefitCategory.Fuel.BenefitCategory = benefitCategory;
                        carEmployeeBenefitCategory.Fuel.Car = carEmployeeBenefitCategory;
                    }

                    session.Save(employeeBenefitCategory);
                    session.Flush();

                    transaction.Commit();

                    return JsonSuccess(Mapper.Map<EmployeeBenefitCategory, EmployeeBenefitCategoryModel>(employeeBenefitCategory));
                }
            }
        }

        [HttpGet]
        public ActionResult Delete(Guid benefitCategoryId)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var benefitCategory = session.QueryOver<BenefitCategory>()
                        .Where(b => b.Id == benefitCategoryId)
                        .SingleOrDefault();

                    session.Delete(benefitCategory);
                    session.Flush();

                    transaction.Commit();

                    return JsonSuccess(true);
                }
            }
        }

        [HttpGet]
        public ActionResult DeleteEmployee(Guid employeeBenefitCategoryId)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var employeeBenefitCategory = session.QueryOver<EmployeeBenefitCategory>()
                        .Where(b => b.Id == employeeBenefitCategoryId)
                        .SingleOrDefault();

                    session.Delete(employeeBenefitCategory);

                    session.Flush();

                    transaction.Commit();

                    return JsonSuccess(true);
                }
            }
        }
    }
}