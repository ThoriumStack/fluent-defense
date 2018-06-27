﻿using Xunit;
using MyBucks.Core.Defensive;

namespace Tests
{
    public class TestStringDefender
    {
        [Fact]
        public void TestMinLength()
        {
            Assert.True("12345".Defend("test").MinLength(5).IsValid);
        }

        [Fact]
        public void TestEmail()
        {
            Assert.Equal(2, "12345".Defend("test").ValidEmail().Errors.Count);
        }
        
        [Fact]
        public void TestEmailValid()
        {
            Assert.True("john@doe.com".Defend("test").ValidEmail().IsValid);
        }
        
        [Fact]
        public void TestUriValid()
        {
            Assert.True("http://www.google.com".Defend("test").ValidUri().IsValid);
        }
    }
}