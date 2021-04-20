using AutoMapper;
using Domain.BenefitCategories;
using Domain.EmployeeBenefitCategories;
using InheritancePattern.Models;
using InheritancePattern.Models.BenefitCategories;
using InheritancePattern.Models.EmployeeBenefitCategories;

namespace InheritancePattern.AutoMapper
{
    public class EmployeeBenefitCategoryProfile : Profile
    {
        public EmployeeBenefitCategoryProfile()
        {
            CreateMap<PrivateMedicalEmployeeBenefitCategoryAddModel, PrivateMedicalEmployeeBenefitCategory>()
                .IncludeBase<EmployeeBenefitCategoryAddModel, EmployeeBenefitCategory>();
            CreateMap<CarEmployeeBenefitCategoryAddModel, CarEmployeeBenefitCategory>()
                .IncludeBase<EmployeeBenefitCategoryAddModel, EmployeeBenefitCategory>();
            CreateMap<CarFuelEmployeeBenefitCategoryAddModel, CarFuelEmployeeBenefitCategory>()
                .IncludeBase<EmployeeBenefitCategoryAddModel, EmployeeBenefitCategory>();
            
            CreateMap<EmployeeBenefitCategoryAddModel, EmployeeBenefitCategory>();
            
            CreateMap<PrivateMedicalEmployeeBenefitCategory, PrivateMedicalEmployeeBenefitCategoryModel>()
                .IncludeBase<EmployeeBenefitCategory, EmployeeBenefitCategoryModel>();
            CreateMap<CarEmployeeBenefitCategory, CarEmployeeBenefitCategoryModel>()
                .IncludeBase<EmployeeBenefitCategory, EmployeeBenefitCategoryModel>();
            CreateMap<CarFuelEmployeeBenefitCategory, CarFuelEmployeeBenefitCategoryModel>()
                .IncludeBase<EmployeeBenefitCategory, EmployeeBenefitCategoryModel>();
            
            CreateMap<EmployeeBenefitCategory, EmployeeBenefitCategoryModel>()
                .ForMember(d => d.Name, opts => opts.MapFrom(s => s.BenefitCategory.Name));
        }
    }
}