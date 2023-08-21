using NHibernate;
using NHibernate.Cfg;
using ISession = NHibernate.ISession;

namespace MySql_Crud
{
    public class NHibernateSessions
    {
        
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            configuration.Configure(@"D:\ASP.net\Mysql_Crud\MySql_Crud\Models\hibernate.config.xml");
            configuration.AddFile(@"D:\ASP.net\Mysql_Crud\MySql_Crud\Mappings\Student.hbm.xml");
            ISessionFactory iSessionFactory = configuration.BuildSessionFactory();
            return iSessionFactory.OpenSession();
        }

    }
}
