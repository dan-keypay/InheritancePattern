using Domain.BenefitCategories;
using FluentNHibernate.Mapping;

namespace DataAccess.BenefitCategories
{
    public class CarsAndCarFuelBenefitCategoryMaps : SubclassMap<CarsAndCarFuelBenefitCategory>
    {
        public CarsAndCarFuelBenefitCategoryMaps()
        {
            KeyColumn("Id");
            
            Map(x => x.Registration);
            Map(x => x.ListPrice);
        }
    }
}