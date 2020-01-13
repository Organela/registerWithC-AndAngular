using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using Register.Domain.Entities;

namespace Register.Infrastructure.Helper
{
    public static class NHibernateHelper
    {
        private static void CreateSessionFactory()
        {
            var a = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString("").ShowSql)
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Person>())
               .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))
            .BuildSessionFactory();
        }
    }
}
