using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using Register.Infrastructure.Mappings;

//https://localhost:5001/api/persons

namespace Register.Infrastructure.Helper
{
    public static class NHibernateHelper
    {
        private const string connectionString = @"Server=10.0.0.67;Database=registro;User ID=registrousuario;Password=123456;";
        
        public static ISession OpenSession()
        {
            var sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                  .ConnectionString(connectionString)
                              .ShowSql()
                )
               .Mappings(m =>
                          m.FluentMappings
                              .AddFromAssemblyOf<PersonMap>())
               .BuildSessionFactory();
            //.ExposeConfiguration(cfg => new SchemaExport(cfg)
            //                                .Create(true, false))
            //.BuildSessionFactory();

            return sessionFactory.OpenSession();
        }
    }
}
