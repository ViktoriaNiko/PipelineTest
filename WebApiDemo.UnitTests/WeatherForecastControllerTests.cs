using System.Linq;
using Moq;
using Xunit;
using Microsoft.Extensions.Logging;
using WebAppDemo.Controllers;


namespace WebApiDemo.UnitTests
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void Ge_Weather_Test()
        {
            // Arrange
            var mockRepo = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(mockRepo.Object);

            // Act
            var result = controller.Get();

            // Assert
          Assert.Equal(5,result.Count());
        }
    }
}
