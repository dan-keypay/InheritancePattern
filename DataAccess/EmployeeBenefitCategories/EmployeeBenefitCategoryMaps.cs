using Domain.EmployeeBenefitCategories;
using FluentNHibernate.Mapping;

namespace DataAccess.EmployeeBenefitCategories
{
    public class EmployeeBenefitCategoryMaps : ClassMap<EmployeeBenefitCategory>
    {
        public EmployeeBenefitCategoryMaps()
        {
            Id(x => x.Id)
                .Not.Nullable();

            Map(x => x.EmployeeId);
            Map(x => x.CashEquivalent);
            
            References(x => x.BenefitCategory)
                .Column("BenefitCategoryId");
        }
    }
}