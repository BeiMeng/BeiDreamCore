using BeiDreamCore.Dependency;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Autofac;

namespace BeiDreamCore.Util.Tests.Dependency
{
    public class IocManager_Tests: TestBaseWithLocalIocManager
    {
        public IocManager_Tests()
        {

        }
        [Fact]
        public void Test_Object_Transient()
        {
            LocalIocManager.Register<TestClassObject>(DependencyLifeStyle.Transient);
            var c = LocalIocManager.Resolve<TestClassObject>();
            var d = LocalIocManager.Resolve<TestClassObject>();
            c.ShouldNotBeSameAs(d);
        }
        [Fact]
        public void Test_Object_Singleton()
        {
            LocalIocManager.Register<TestClassObject>(DependencyLifeStyle.Singleton);
            var c = LocalIocManager.Resolve<TestClassObject>();
            var d = LocalIocManager.Resolve<TestClassObject>();
            c.ShouldBeSameAs(d);
        }
        [Fact]
        public void Test_Object_Scoped()
        {
            LocalIocManager.Register<TestClassObject>(DependencyLifeStyle.Scoped);
            using (var scope = LocalIocManager.IocContainer.BeginLifetimeScope())
            {
                var c = scope.Resolve<TestClassObject>();
                var d = scope.Resolve<TestClassObject>();
                c.ShouldBeSameAs(d);
            }
        }
        [Fact]
        public void Test_Object_NotScoped()
        {
            TestClassObject c;
            TestClassObject d;
            LocalIocManager.Register<TestClassObject>(DependencyLifeStyle.Scoped);
            using (var scope = LocalIocManager.IocContainer.BeginLifetimeScope())
            {
                c = scope.Resolve<TestClassObject>();
            }
            using (var scope = LocalIocManager.IocContainer.BeginLifetimeScope())
            {
                d = scope.Resolve<TestClassObject>();
            }
            c.ShouldNotBeSameAs(d);
        }

    }
    public class TestClassObject
    {
        public static int number=2;
        public TestClassObject()
        {
            number++;
        }
    }
}
