using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzGame.Test
{
    [TestClass]
    public class BuzzTest
    {
        [DataTestMethod]
        [DataRow(3)]
        [DataRow(6)]
        [DataRow(12)]
        public void Should_be_return_true_when_value_is_multiple_of_three(int value)
        {
            var buzz = new Buzz();
            Assert.IsTrue(buzz.IsValid(value));
        }

        [DataTestMethod]
        [DataRow(2)]
        [DataRow(1)]
        [DataRow(13)]
        public void Should_be_return_false_when_value_is_not_multiple_of_three(int value)
        {
            var buzz = new Buzz();
            Assert.IsFalse(buzz.IsValid(value));
        }

        [DataTestMethod]
        [DataRow(2)]
        [DataRow(1)]
        [DataRow(13)]
        public void Should_be_return_a_empty_when_value_is_not_multiple_of_three(int value)
        {
            var buzz = new Buzz();
            Assert.AreEqual(buzz.GetValue(value), string.Empty);
        }

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(6)]
        [DataRow(12)]
        public void Should_be_return_Buzz_when_value_is_not_multiple_of_three(int value)
        {
            var buzz = new Buzz();
            Assert.AreEqual(buzz.GetValue(value), "Buzz");
        }
    }
}