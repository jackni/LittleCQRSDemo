using Autofac;
using Autofac.Integration.WebApi;
using SanBox.MessageBus;
using SandBox.Command;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace SanBoxApi
{
    public class AutoFacConfig
    {
        public static void Config(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            //builder.RegisterGeneric(typeof(CommandBus)).As(typeof(ICommandBus<DispatchCommand>)).InstancePerRequest();
            

            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

        }
    }
}