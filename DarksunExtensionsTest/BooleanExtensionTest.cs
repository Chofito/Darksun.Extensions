using System;
using Xunit;
using Xunit.Abstractions;

namespace DarksunExtensionsTest
{
    public class BooleanExtensionTest
    {
        private readonly ITestOutputHelper _output;

        public BooleanExtensionTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void IfTrueFalse()
        {
            var message1 = "This is ";
            var message2 = "a meesage";

            true.IfTrue(ThisIsTrue);
            false.IfFalse(ThisIsFalse);

            true.IfTrue(() => _output.WriteLine(message1));
            false.IfFalse(() => _output.WriteLine(message2));
        }

        public void ThisIsTrue()
            => _output.WriteLine("This is true");

        public void ThisIsFalse()
            => _output.WriteLine("This is false");
    }
}
