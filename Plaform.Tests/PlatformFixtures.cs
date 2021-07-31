using PlatformApp;
using System;
using Xunit;

namespace Plaform.Tests
{
    public class PlatformFixtures
    {
        [Fact]
        public void User_Should_Get_Android_When_Passing_Android()
        {
            var platformFactory = new PlatformFactory();
            var platform = platformFactory.GetPlatform(KeyStore.Android);
            platform.Message().Equals(string.Format(KeyStore.Message, KeyStore.Android));
        }

        [Fact]
        public void User_Should_Get_Windows_When_Passing_Windows()
        {
            var platformFactory = new PlatformFactory();
            var platform = platformFactory.GetPlatform(KeyStore.Windows);
            platform.Message().Equals(string.Format(KeyStore.Message, KeyStore.Windows));
        }

        [Fact]
        public void User_Should_Get_Ios_When_Passing_Ios()
        {
            var platformFactory = new PlatformFactory();
            var platform = platformFactory.GetPlatform(KeyStore.Ios);
            platform.Message().Equals(string.Format(KeyStore.Message, KeyStore.Ios));
        }

        [Fact]
        public void User_Should_Get_IPlatform_When_Passing_Valid_Platfrom()
        {
            var platformFactory = new PlatformFactory();
            var platform = platformFactory.GetPlatform(KeyStore.Ios);
            Assert.NotNull(platform);

        }

        [Fact]
        public void User_Should_Get_Exception_When_Passing_InValid_Platfrom()
        {
            var platformFactory = new PlatformFactory();
            Assert.Throws(typeof(Exception), () => platformFactory.GetPlatform("InvalidPlatform"));
        }
    }

}
