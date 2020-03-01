using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzGame.Test
{
    [TestClass]
    public class FizzBuzzTest
    {
        [DataTestMethod]
        [DataRow(15)]
        [DataRow(30)]
        [DataRow(60)]
        public void Should_be_return_true_when_value_is_multiple_of_three_and_five(int value)
        {
            var fizzBuzz = new FizzBuzz();
            Assert.IsTrue(fizzBuzz.IsValid(value));
        }

        [DataTestMethod]
        [DataRow(5)]
        [DataRow(3)]
        [DataRow(16)]
        public void Should_be_return_false_when_value_not_is_multiple_of_three_and_five(int value)
        {
            var fizzBuzz = new FizzBuzz();
            Assert.IsFalse(fizzBuzz.IsValid(value));
        }

        [DataTestMethod]
        [DataRow(15)]
        [DataRow(30)]
        [DataRow(60)]
        public void Should_be_return_FizzBuzz_when_value_is_multiple_of_three_and_five(int value)
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual(fizzBuzz.GetValue(value), "FizzBuzz");
        }

        [DataTestMethod]
        [DataRow(5)]
        [DataRow(3)]
        [DataRow(16)]
        public void Should_be_return_a_emptyString_when_value_not_is_multiple_of_three_and_five(int value)
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual(fizzBuzz.GetValue(value), string.Empty);
        }
    }
}