using API.Controllers;

namespace Test
{
    [TestFixture]
    public class WeatherForecastControllerTests
    {
        private WeatherForecastController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new WeatherForecastController(null);
        }

        [Test]
        public void Get_ShouldReturn_ArrayOfWeatherForecasts()
        {
            var result = _controller.Get();

            Assert.IsNotNull(result, "Result should not be null");
            Assert.IsTrue(result.Any(), "Result should contain at least one forecast");
        }
    }
}
