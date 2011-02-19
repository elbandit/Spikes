using System.Web;
using Db40Spike.Domain;
using Db40Spike.Infrastructure;
using StructureMap;
using StructureMap.Configuration.DSL;

public class BootStrapper
{
    public static void RegisterDependencies()
    {
        ObjectFactory.Initialize(x =>
        {
            x.AddRegistry<RepositoryRegistry>();

        });
    }

    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {
            For<IRepository<Person>>().Use<Db4ORepository<Person>>();
            For<IObjectContainerFactory>().Singleton().Use<ObjectContainerFactory>()
                 .Ctor<string>("container_path")
                 .Is(HttpContext.Current.Server.MapPath("~/App_Data/people.db4o"));

            For<IDb4OSession>().HttpContextScoped().Use<Db4OSession>();

            For<IUnitOfWorkFactory>().Use<Db4OUnitOfWorkFactory >();                        
        }
    }
}