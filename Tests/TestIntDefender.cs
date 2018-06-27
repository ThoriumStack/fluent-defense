using System;
using Xunit;
using MyBucks.Core.Defensive;
using Xunit.Sdk;

namespace Tests
{
    public class TestIntDefender
    {
        [Fact]
        public void TestNotZero()
        {
            Assert.Throws<Exception>(() => 0.Defend("test").NotZero().Throw());
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(3, 5)]
        public void TestMin(int num, int min)
        {
            Assert.Throws<Exception>(() => num.Defend("test").Min(min).Throw());
        }
        
        
        [Theory]
        [InlineData(0, -1, 5)]
        [InlineData(3, 1, 20)]
        public void TestRange(int num, int min, int max)
        {
             num.Defend("test").InRange(min, max).Throw();
        }
    }
}