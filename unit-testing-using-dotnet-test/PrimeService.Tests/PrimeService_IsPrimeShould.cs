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

    }
}