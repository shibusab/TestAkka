using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace TestAkka
{
    public class ConfigureService
    {
        internal static void Configure()
        {
            HostFactory.Run(configure =>
            {
                configure.Service<GamingBackgroundService>(service =>
                {
                    service.ConstructUsing(s => new GamingBackgroundService());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });
                //Setup Account that window service use to run.  
                configure.RunAsLocalSystem();
                configure.SetServiceName("GamingBackgroundService");
                configure.SetDisplayName("GamingBackgroundService");
                configure.SetDescription("Gaming Background Service");
            });
        }
    }
}
