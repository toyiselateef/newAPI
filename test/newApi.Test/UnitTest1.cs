using System;
using Xunit;
using newApi.Controllers;
namespace newApi.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
         [Fact]
        public void Test1()
        {

            var returnValue=controller.Get();
            Assert.Equal("", returnValue.ToString());
        }
    }
}
