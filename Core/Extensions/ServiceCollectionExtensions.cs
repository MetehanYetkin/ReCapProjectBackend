using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
   public static class ServiceCollectionExtensions
    {
        //IServiceCollection tipinde yeni bir metot yazıyoruz extend ediyoruz.
        //this ile hangi metodu extend ediceğimizi gösterip ICoreModule[] parametresi gönderiyoruz ileride ICoreModule içinde başka moduller eklersek eklenmesi kolay olsun diye.

        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection,ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);
        }
    }
}
