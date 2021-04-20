using Domain.EmployeeBenefitCategories;
using FluentNHibernate.Mapping;

namespace DataAccess.EmployeeBenefitCategories
{
    public class PrivateMedicalEmployeeBenefitCategoryMaps : SubclassMap<PrivateMedicalEmployeeBenefitCategory>
    {
        public PrivateMedicalEmployeeBenefitCategoryMaps()
        {
            KeyColumn("Id");
            
            Map(x => x.AmountForegone);
            Map(x => x.AmountMadeGood);
        }
    }
}