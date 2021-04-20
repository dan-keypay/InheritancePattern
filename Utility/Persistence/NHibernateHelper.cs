using DataAccess.BenefitCategories;
using Domain;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Utility.Persistence
{
    public class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(@"Data Source=(local);Database=InheritancePattern;UID=payroll;pwd=payroll;")
                    .ShowSql()
                )
                .Mappings(m =>
                {
                    m.FluentMappings.AddFromAssemblyOf<BenefitCategoryMaps>();
                    m.AutoMappings
                        .Add(
                            AutoMap.AssemblyOf<Entity>()
                                .UseOverridesFromAssemblyOf<BenefitCategoryMaps>()
                                .IgnoreBase<Entity>()
                        );
                })
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                    .Create(false, false))
                .BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}