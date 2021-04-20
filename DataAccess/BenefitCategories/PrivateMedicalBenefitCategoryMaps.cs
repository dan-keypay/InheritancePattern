using Domain.BenefitCategories;
using FluentNHibernate.Mapping;

namespace DataAccess.BenefitCategories
{
    public class PrivateMedicalBenefitCategoryMaps : SubclassMap<PrivateMedicalBenefitCategory>
    {
        public PrivateMedicalBenefitCategoryMaps()
        {
            KeyColumn("Id");
            Map(x => x.AmountForegone);
        }
    }
}