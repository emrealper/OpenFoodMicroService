using System;
using Xunit;

namespace OpenFood.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            Assert.Equal(1,1);
        }


   
        public void Test1Theory(decimal expected, decimal firstToAdd)
        {

            Assert.Equal(1, 1);
        }
    }
}
