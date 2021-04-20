using Domain.EmployeeBenefitCategories;
using FluentNHibernate.Mapping;

namespace DataAccess.EmployeeBenefitCategories
{
    public class CarFuelEmployeeBenefitCategoryMaps : SubclassMap<CarFuelEmployeeBenefitCategory>
    {
        public CarFuelEmployeeBenefitCategoryMaps()
        {
            KeyColumn("Id");
            
            Map(x => x.AvailableFromDate);
            Map(x => x.AvailableToDate);

            HasOne(x => x.Car)
                .ForeignKey("CarFuelEmployeeBenefitCategoryId")
                .Cascade.None();
        }
    }
}