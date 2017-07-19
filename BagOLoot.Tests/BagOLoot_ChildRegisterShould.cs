using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class ChildRegisterShould
    {
        private readonly ChildRegister _register;

        public ChildRegisterShould()
        {
            _register = new ChildRegister();
        }
        // Should in thoery add children
        [Theory] // A fact with multiple inputs
        [InlineData("Sarah")] // runs unit test 3 times
        [InlineData("Jamal")]
        [InlineData("Kelly")]
        public void AddChildren(string child)
        {
            var result = _register.AddChild(child); 
            Assert.True(result);
        }

        [Fact]
        public void ReturnListOfChildren()
        {
            var result = _register.GetChildren();
            Assert.IsType<List<string>>(result);
        }
    }
}
