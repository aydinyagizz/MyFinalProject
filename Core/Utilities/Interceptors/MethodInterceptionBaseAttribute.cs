using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    //Attribute'ler class'larda veya method'larda kullanılabilir. birden çok oluşturalabilir demek.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }


}
