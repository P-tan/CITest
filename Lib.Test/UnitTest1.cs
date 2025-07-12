
using Lib;
namespace Lib.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ReturnsSum()
        {
            var sample = new Sample();
            int result = sample.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
