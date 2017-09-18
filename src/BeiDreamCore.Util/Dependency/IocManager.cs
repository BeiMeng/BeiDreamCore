using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Builder;

namespace BeiDreamCore.Dependency
{
    /// <summary>
    /// 依赖注入管理器
    /// </summary>
    public class IocManager : IIocManager
    {
        public IContainer IocContainer { get; private set; }
        private ContainerBuilder builder;

        public IocManager()
        {
            builder = new ContainerBuilder();
        }

        public void Register<T>(DependencyLifeStyle lifeStyle = DependencyLifeStyle.Transient) where T : class
        {          
            ApplyLifestyle(builder.RegisterType<T>(), lifeStyle);
            IocContainer = builder.Build();
        }

        public T Resolve<T>()
        {
            return IocContainer.Resolve<T>();
        }

        public void Dispose()
        {
            IocContainer.Dispose();
        }
        private static IRegistrationBuilder<T, ConcreteReflectionActivatorData, SingleRegistrationStyle> ApplyLifestyle<T>(IRegistrationBuilder<T, ConcreteReflectionActivatorData, SingleRegistrationStyle> registration, DependencyLifeStyle lifeStyle)
            where T : class
        {
            switch (lifeStyle)
            {
                case DependencyLifeStyle.Scoped:
                    return registration.InstancePerLifetimeScope();
                case DependencyLifeStyle.Singleton:
                    return registration.SingleInstance();
                default:
                    return registration;
            }
        }
    }
}
