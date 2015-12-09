using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Northwind.Infrastructure.Mapping.Customers;

namespace Northwind.Infrastructure
{
    public class NHibernateUtils
    {
        public static ISessionFactory GetFactory()
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;
            var cfg = Fluently.Configure()
                .Database(FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2012.ConnectionString(connectionString).ShowSql())
                .Mappings(t => t.FluentMappings.AddFromAssemblyOf<CustomersMap>())
                .BuildConfiguration();
            //var exporter = new SchemaExport(cfg);
            //exporter.Execute(true, true, false);

            var sessionFactory = cfg.BuildSessionFactory();
            return sessionFactory;
        }
    }
}
