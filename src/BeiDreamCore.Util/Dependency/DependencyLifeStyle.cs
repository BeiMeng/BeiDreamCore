using System;
using System.Collections.Generic;
using System.Text;

namespace BeiDreamCore.Dependency
{
    /// <summary>
    /// 对象实例生命周期枚举值
    /// </summary>
    public enum DependencyLifeStyle
    {
        /// <summary>
        /// 瞬时对象,每次解析都创建一个新对象
        /// </summary>
        Transient,
        /// <summary>
        /// 单例对象,第一次解析时创建一个单例对象,在整个应用程序周期内都使用这同一个实例
        /// </summary>
        Singleton,
        /// <summary>
        /// 生命周期同一实例对象,同一次请求(作用域)内使用一个相同的实例
        /// </summary>
        Scoped
    }
}
