using System;
using System.IO;
using Xunit;

namespace HolaUnitTests
{
    public class UnitTest
    {
        private const string Expected = "Hola Unit Tets!";
        [Fact]
        public void Test()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HolaConsoleApp.Program.Main();

                var result = sw.ToString().Trim();
                Assert.Equal(Expected, result);
            }
        }
    }
}
