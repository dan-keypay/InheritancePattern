using Domain.EmployeeBenefitCategories;
using FluentNHibernate.Mapping;

namespace DataAccess.EmployeeBenefitCategories
{
    public class CarEmployeeBenefitCategoryMaps : SubclassMap<CarEmployeeBenefitCategory>
    {
        public CarEmployeeBenefitCategoryMaps()
        {
            KeyColumn("Id");
            
            Map(x => x.AvailableFromDate);
            Map(x => x.AvailableToDate);
            Map(x => x.EmployerProvidesFuel);
            
            References(x => x.Fuel)
                .Column("CarFuelEmployeeBenefitCategoryId")
                .Cascade.All();
        }
    }
}