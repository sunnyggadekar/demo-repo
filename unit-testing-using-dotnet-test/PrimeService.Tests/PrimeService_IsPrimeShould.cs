using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {

        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            bool result = PrimeService.IsPrime(1);
            Assert.False(result, "1 should not be prime");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = PrimeService.IsPrime(value);
            Assert.False(result, $"{value} should not be prime");
        }

        [Fact]
        public void Returns_the_input()
        {
            var input = "message";
            var result = PrimeService.Display(input);
            Assert.Equal(result, input);

        }
    }
}