using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeiDreamCore.Dependency
{
    /// <summary>
    /// 依赖注入管理器接口
    /// </summary>
    public interface IIocManager:IIocRegistrar,IIocResolver,IDisposable
    {
        /// <summary>
        /// 引用Autofac DI 容器
        /// </summary>
        IContainer IocContainer { get; }
    }
}
