using BeiDreamCore.Dependency;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeiDreamCore.Util.Tests.Dependency
{
    public abstract class TestBaseWithLocalIocManager : IDisposable
    {
        protected IIocManager LocalIocManager;

        protected TestBaseWithLocalIocManager()
        {
            LocalIocManager = new IocManager();
        }

        public virtual void Dispose()
        {
            LocalIocManager.Dispose();
        }
    }
}
