using Autofac;
using DjurDagis.Menu;
using System;
using System.Drawing;
using System.Threading;

namespace DjurDagis
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainMenu = new MainMenu();

            var container = AFConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();


            }

        }

    }
}
