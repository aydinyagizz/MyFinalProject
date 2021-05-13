using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstrack;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstrack;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module //artık bir autofac modülüsün diyoruz.
    {
        protected override void Load(ContainerBuilder builder)
        {
            //startup'da yaptığımızın karşılığını yazıyoruz, aynısını yapıyoruz.
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance(); //birisi senden IProductService isterse ona ProductManager'i register et, ProductManager örneği ver anlamında. Onları new'le demek.
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance(); //birisi senden IProductDal isterse ona EfProductDal'i register et, EfProductDal örneği ver anlamında. Onları new'le demek.



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
