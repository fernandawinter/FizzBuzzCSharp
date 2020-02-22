using Fizzbuzz.Src.Services;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        FizzbuzzExecuter executer;

        [SetUp]
        public void Setup()
        {
            executer = new FizzbuzzExecuter();
        }

        [Test]
        public void CalculateFizzbuzz_1_1() //o que eu envio, o que eu espero
        {
            string result = executer.CalculateFizzbuzz(1);

            Assert.AreEqual("1", result);
        }

        [Test]
        public void CalculateFizzbuzz_3_Fizz()
        {
            string result = executer.CalculateFizzbuzz(3);

            Assert.AreEqual("Fizz", result);
        }
    }
}