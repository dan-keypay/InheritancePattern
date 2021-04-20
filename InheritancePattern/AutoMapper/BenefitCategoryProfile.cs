using AutoMapper;
using Domain.BenefitCategories;
using InheritancePattern.Models.BenefitCategories;

namespace InheritancePattern.AutoMapper
{
    public class BenefitCategoryProfile : Profile
    {
        public BenefitCategoryProfile()
        {
            CreateMap<PrivateMedicalBenefitCategoryAddModel, PrivateMedicalBenefitCategory>()
                .IncludeBase<BenefitCategoryAddModel, BenefitCategory>();
            CreateMap<CarsAndCarFuelBenefitCategoryAddModel, CarsAndCarFuelBenefitCategory>()
                .IncludeBase<BenefitCategoryAddModel, BenefitCategory>();
            
            CreateMap<BenefitCategoryAddModel, BenefitCategory>();
            
            CreateMap<PrivateMedicalBenefitCategory, PrivateMedicalBenefitCategoryModel>()
                .IncludeBase<BenefitCategory, BenefitCategoryModel>();
            CreateMap<CarsAndCarFuelBenefitCategory, CarsAndCarFuelBenefitCategoryModel>()
                .IncludeBase<BenefitCategory, BenefitCategoryModel>();
            CreateMap<BenefitCategory, BenefitCategoryModel>();
        }
    }
}