using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzGame.Test
{
    [TestClass]
    public class FizzTest
    {
        [DataTestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(15)]
        public void Should_be_return_true_when_receive_a_multiple_of_five(int value)
        {
            Fizz fizz = new Fizz();
            Assert.IsTrue(fizz.IsValid(value));
        }

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(8)]
        [DataRow(1)]
        public void Should_be_return_false_when_receive_a_not_multiple_of_five(int value)
        {
            Fizz fizz = new Fizz();
            Assert.IsFalse(fizz.IsValid(value));
        }

        [DataTestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(15)]
        public void Should_be_return_Fizz_text_when_value_is_multiple_of_five(int value)
        {
            var fizz = new Fizz();
            Assert.AreEqual(fizz.GetValue(value), "Fizz");
        }
        [DataTestMethod]
        [DataRow(3)]
        [DataRow(1)]
        [DataRow(4)]
        public void Should_be_return_a_empty_string_on_value_is_not_multiple_of_5(int value)
        {
            var fizz = new Fizz();
            Assert.AreEqual(fizz.GetValue(value), string.Empty);
        }
    }
}