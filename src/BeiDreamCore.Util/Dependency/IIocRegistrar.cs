using System;
using System.Collections.Generic;
using System.Text;

namespace BeiDreamCore.Dependency
{
    /// <summary>
    /// 依赖注入---注册接口定义
    /// </summary>
    public interface IIocRegistrar
    {
        /// <summary>
        /// 根据对象进行IOC注册,默认是以瞬时模式注册
        /// </summary>
        /// <typeparam name="T">待注册对象</typeparam>
        /// <param name="lifeStyle">生命周期枚举</param>
        void Register<T>(DependencyLifeStyle lifeStyle = DependencyLifeStyle.Transient)where T : class;
    }
}
