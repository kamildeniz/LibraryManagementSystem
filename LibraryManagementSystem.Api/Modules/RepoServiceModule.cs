using Autofac;
using LibraryManagementSystem.Core.Repositories;
using LibraryManagementSystem.Core.Services;
using LibraryManagementSystem.Core.UnitOfWorks;
using LibraryManagementSystem.Repository.Repositories;
using LibraryManagementSystem.Repository.UnitOfWorks;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Service.Mappings;
using LibraryManagementSystem.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace LibraryManagementSystem.Api.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();


            var apiAssembly = Assembly.GetExecutingAssembly();

            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));


            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerDependency().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerDependency().InstancePerLifetimeScope();
        }
    }
}