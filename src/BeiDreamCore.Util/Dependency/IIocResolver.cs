using System;
using System.Collections.Generic;
using System.Text;

namespace BeiDreamCore.Dependency
{
    /// <summary>
    /// 依赖主任---解析接口定义
    /// </summary>
    public interface IIocResolver
    {
        /// <summary>
        /// 根据对象解析获取一个对象
        /// </summary>
        /// <typeparam name="T">待解析对象</typeparam>
        /// <returns></returns>
        T Resolve<T>();
    }
}
