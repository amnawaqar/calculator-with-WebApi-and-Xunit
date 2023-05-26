using Calculatorclass;
using FluentAssertions;
namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 1, 3)]
        [InlineData(3, 4, 7)]

        public void add(int num1, int num2, int result)
        =>  new Calculator().add(num1, num2).Should().Be(result);

        

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(4, 3, 1)]

        public void sub(int num1, int num2, int result)
        =>new Calculator().sub(num1, num2).Should().Be(result);






        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(4, 3, 12)]

        public void mul(int num1, int num2, int result)
        => new Calculator().multiply(num1, num2).Should().Be(result);





    }
}