using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Register.Domain.Entities;

namespace Register.Infrastructure.Helper
{
    public static class NHibernateHelper
    {
        private const string connectionString = @"Data Source=.\SQLEXPRESS;
                          AttachDbFilename=C:\Users\andre.cunha\Documents\Projetos\registerWithC-AndAngular\Register.App\Register.mdf;
                          Integrated Security=True;
                          Connect Timeout=30;
                          User Instance=True";
        
        public static ISession OpenSession()
        {
            var sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                  .ConnectionString(connectionString)
                              .ShowSql()
                )
               .Mappings(m =>
                          m.FluentMappings
                              .AddFromAssemblyOf<Person>())
                //.ExposeConfiguration(cfg => new SchemaExport(cfg)
                //                                .Create(true, false))
                .BuildSessionFactory();
            
            return sessionFactory.OpenSession();
        }
    }
}
