using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.Entityframework;
using System;
using System.Collections.Generic;

using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    //startup ta yaptığımızı burda yapıyoruz
    //IOC yapılandırması yaptık
    //program.cs->IHostBuilder da tanımladık burayı
    public class AutofacBusinessModule:Module
    {
        //uygulama çalıştığında bu çalışır.
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
