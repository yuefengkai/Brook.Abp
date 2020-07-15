using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;

namespace Brook.AbpConsole
{
    public class HelloAbpService: ITransientDependency //继承此接口自动注入
    {
        public void SayHello()
        {
            Console.WriteLine("Hello Abp");
        }
    }
}
