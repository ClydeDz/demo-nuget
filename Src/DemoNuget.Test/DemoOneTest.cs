using DemoNugetByClydeDSouza;
using Xunit;

namespace DemoNuget.Test
{
    public class DemoOneTest
    {
        [Fact]
        public void Add_Test()
        {
            int result = DemoOne.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
