using System;
using Xunit;

namespace RandomNumberGenerator
{
    public class GenerateRandomNumberTest
    {
        [Fact]
        public void GenerateRandomNumber_GenerateAndReturnRandomNumber_OnGivenInput()
        {
            // Arrange 
            var _sut = new RandomNumberGenerator(1, 40, 3641, 729);

            //Act
           var rndNumber = _sut.GenerateRandomNumber();

            //Assert 

            Assert.Equal(36, rndNumber);
        }
    }
}
