using Domain.BenefitCategories;
using FluentNHibernate.Mapping;

namespace DataAccess.BenefitCategories
{
    public class BenefitCategoryMaps : ClassMap<BenefitCategory>
    {
        public BenefitCategoryMaps()
        {
            Id(x => x.Id)
                .Not.Nullable();
            
            HasMany(x => x.LinkedEmployees)
                .KeyColumn("BenefitCategoryId")
                .Cascade.All();

            Map(x => x.Name);
            Map(x => x.Year);
        }
    }
}