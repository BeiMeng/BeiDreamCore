using System;
using System.Collections.Generic;
using Xunit;

namespace BeiDreamCore.Util.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Class1 cls = new Class1();
            Assert.Equal(5, cls.Add(2, 3));
        }
        [Fact]
        public void Test2()
        {
            Class1 cls = new Class1();
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(8);
            list.Add(19);
            list.Add(13);
            list.Add(3);
            Assert.Equal(19, cls.Max(list));
        }
    }
}
