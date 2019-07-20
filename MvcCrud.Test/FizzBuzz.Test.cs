using MvcCrud.BusinessLogic;
using System;
using Xunit;

namespace MvcCrud.Test
{
    public class FizzBuzzTests
    {
        [Fact]
        public void It_Should_Print_Text_For_Values_That_Are_Multiples_Of_3_And_5()
        {
            var fizzBuzzGenerator = new FizzBuzz();
            var result = fizzBuzzGenerator.Print(15);
            Assert.Equal("1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz", result);
        }
    }
}
