using Brook.AbpConsole;
using System;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

namespace Brook.Abp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var application = AbpApplicationFactory.Create<AppModule>())
            {
                application.Initialize();

                //获取注入
                var helloAbpService = application.ServiceProvider.GetService<HelloAbpService>();
                helloAbpService.SayHello();

                Console.WriteLine("按任意键退出...");

                Console.ReadLine();
            }
        }
    }
}
