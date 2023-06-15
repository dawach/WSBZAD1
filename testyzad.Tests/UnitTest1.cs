using Xunit;

namespace testyzad.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, -4, 4, 1)]  // 1 pierwiastek (delta = 0)
        [InlineData(1, -3, 2, 2)]  // 2 pierwiastki (delta > 0)
        [InlineData(1, 2, 3, 0)]   // brak pierwiastków (delta < 0)
        public void ObliczaniePierwiastkow_RoznePrzypadki(double a, double b, double c, int expected)
        {
            int result = Program.ObliczaniePierwiastkow(a, b, c);
            Assert.Equal(expected, result);
        }
    }
}
