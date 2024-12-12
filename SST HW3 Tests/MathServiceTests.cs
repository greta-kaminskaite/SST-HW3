using SST_HW3;

namespace SST_HW3_Tests
{
    public class Tests
    {
        private MathService _mathService;

        [SetUp]
        public void Setup()
        {
            _mathService = new MathService();
        }

        [TestCase(0, false)]
        [TestCase(2, true)]
        [TestCase(19, true)]
        [TestCase(63, false)]

        public void IsPrimeNumber_OriginalCode(int number, bool expectedResult)
        {
            var actualResult = _mathService.IsPrimeNumber(number);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(0, false)]
        [TestCase(2, true)]
        [TestCase(19, true)]
        [TestCase(63, false)]

        public void IsPrimeNumber_Mutant1(int number, bool expectedResult)
        {
            var actualResult = _mathService.IsPrimeNumber_Mutation1(number);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(0, false)]
        [TestCase(2, true)]
        [TestCase(19, true)]
        [TestCase(63, false)]

        public void IsPrimeNumber_Mutant2(int number, bool expectedResult)
        {
            var actualResult = _mathService.IsPrimeNumber_Mutation2(number);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(0, false)]
        [TestCase(2, true)]
        [TestCase(19, true)]
        [TestCase(63, false)]

        public void IsPrimeNumber_Mutant3(int number, bool expectedResult)
        {
            var actualResult = _mathService.IsPrimeNumber_Mutation3(number);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(0, false)]
        [TestCase(2, true)]
        [TestCase(19, true)]
        [TestCase(63, false)]

        public void IsPrimeNumber_Mutant4(int number, bool expectedResult)
        {
            var actualResult = _mathService.IsPrimeNumber_Mutation4(number);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(0, false)]
        [TestCase(2, true)]
        [TestCase(19, true)]
        [TestCase(63, false)]

        public void IsPrimeNumber_Mutant5(int number, bool expectedResult)
        {
            var actualResult = _mathService.IsPrimeNumber_Mutation5(number);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}