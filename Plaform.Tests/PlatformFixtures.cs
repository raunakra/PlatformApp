using PlatformApp;
using System;
using Xunit;

namespace Plaform.Tests
{
    public class PlatformFixtures
    {
 
        [Theory]
        [InlineData(KeyStore.Windows)]
        [InlineData(KeyStore.Android)]
        [InlineData(KeyStore.Ios)]
        public void User_Should_Get_Platform_Successfully_When_Passing_Valid_Platform(string platformName)
        {
            var platformFactory = new PlatformFactory();
            var platform = platformFactory.GetPlatform(platformName);
            Assert.Equal(platform.Message(), string.Format(KeyStore.Message, platformName));
        }

        [Fact]
        public void User_Should_Get_IPlatform_When_Passing_Valid_Platform()
        {
            var platformFactory = new PlatformFactory();
            var platform = platformFactory.GetPlatform(KeyStore.Ios);
            Assert.NotNull(platform);
        }

        [Fact]
        public void User_Should_Get_Exception_When_Passing_InValid_Platform()
        {
            var platformFactory = new PlatformFactory();
            Assert.Throws<Exception>(() => platformFactory.GetPlatform("InvalidPlatform"));
        }
    }

}
