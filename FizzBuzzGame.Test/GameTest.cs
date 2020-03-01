using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Reflection;

namespace FizzBuzzGame.Test
{
    [TestClass]
    public class GameTest
    {
        private MethodInfo _findResponse;

        private string InvokeFindResponse(int value)
        {
            Type type = typeof(Game);
            var game = Activator.CreateInstance(type);
            _findResponse = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.Name == "FindResponse" && x.IsPrivate).First();
            return (string)_findResponse.Invoke(game, new object[] { value });
        }

        [TestMethod]
        public void Should_be_return_Fizz_when_i_pass_a_multiple_of_three()
        {
            var result = InvokeFindResponse(3);

            Assert.AreEqual(result, "Buzz");
        }

        [TestMethod]
        public void Should_be_return_Buzz_when_i_pass_a_multiple_of_five()
        {
            var result = InvokeFindResponse(5);

            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void Should_be_return_FizzBuzz_when_i_pass_a_multiple_of_three_and_five()
        {
            var result = InvokeFindResponse(15);

            Assert.AreEqual(result, "FizzBuzz");
        }

        [TestMethod]
        public void Should_be_return_a_emptyString_when_i_pass_a_not_multiple_of_three_and_five()
        {
            var result = InvokeFindResponse(1);

            Assert.AreEqual(result, string.Empty);
        }
    }
}