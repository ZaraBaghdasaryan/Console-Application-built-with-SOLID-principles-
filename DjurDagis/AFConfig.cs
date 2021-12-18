using Autofac;
using Autofac.Extensions.DependencyInjection;
using DjurDagis.Data;
using DjurDagis.Entities;
using DjurDagis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DjurDagis
{
    class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();

            //TODO: Remove later
            builder.RegisterType<MockData>().As<IMockData>();

            //Data
            builder.RegisterType<DatabaseUsingLists>().As<IDatabaseUsingLists>().SingleInstance(); //Always get the same database

            //Data Repository
            builder.RegisterType<DataRepository>().As<IDataRepository>();

            //Entities
            builder.RegisterType<Customer>().As<ICustomer>();
            builder.RegisterType<Animal>().As<IAnimal>();
            builder.RegisterType<DayCareService>().As<IDayCareService>();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
               .Where(i => i.Namespace.Contains("Menu"))
               .As(i => i.GetInterfaces()
               .FirstOrDefault(n => n.Name == "I" + i.Name)); //Look for the class first and then add I and find the interface for it

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
              .Where(i => i.Namespace.Contains("Customer"))
              .As(i => i.GetInterfaces()
              .FirstOrDefault(n => n.Name == "I" + i.Name));

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
              .Where(i => i.Namespace.Contains("DayCareService"))
              .As(i => i.GetInterfaces()
              .FirstOrDefault(n => n.Name == "I" + i.Name));

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
              .Where(i => i.Namespace.Contains("Animal"))
              .As(i => i.GetInterfaces()
              .FirstOrDefault(n => n.Name == "I" + i.Name));

            //builder.RegisterTyoe<DataRepository>().As<IDataRepository>().SingleInstance();

            return builder.Build(); 
             
        }

    }
}
 