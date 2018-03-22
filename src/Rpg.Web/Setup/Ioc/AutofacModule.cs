using System.Reflection;
using Autofac;
using Rpg.Commands.Alchemy;
using Rpg.Logic.Alchemy;

namespace Rpg.Web.Setup.Ioc
{
    public class AutofacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(typeof(IPotionBuilderFactory).GetTypeInfo().Assembly).AsImplementedInterfaces();
            builder.RegisterModule(new MediatorModule());
        }
    }
}