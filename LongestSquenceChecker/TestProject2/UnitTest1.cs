namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var checker = new SequenceChecker.SequenceChecker();
            Assert.AreEqual(checker.CheckLongestSequence("6 1 5 9 2"), "1 5 9");
        }

        [TestMethod]
        public void TestMethod2()
        {
            string inputString = File.ReadAllText(@"Input1.txt");
            var checker = new SequenceChecker.SequenceChecker();
            Assert.AreEqual(checker.CheckLongestSequence(inputString), "1710 2461 9288 10195 10431 12485");
        }

        [TestMethod]
        public void TestMethod3()
        {
            string inputString = File.ReadAllText(@"Input2.txt");
            var checker = new SequenceChecker.SequenceChecker();
            Assert.AreEqual(checker.CheckLongestSequence(inputString), "10298 10897 12291 15037 18446 23435 25333 27266");
        }

        [TestMethod]
        public void TestMethod4()
        {
            string inputString = File.ReadAllText(@"Input3.txt");
            var checker = new SequenceChecker.SequenceChecker();
            Assert.AreEqual(checker.CheckLongestSequence(inputString), "3862 16353 22813 28735");
        }       

        [TestMethod]
        public void TestMethod6()
        {
            string inputString = File.ReadAllText(@"Input5.txt");
            var checker = new SequenceChecker.SequenceChecker();
            Assert.AreEqual(checker.CheckLongestSequence(inputString), "11084 11970 24975 30922");
        }

        [TestMethod]
        public void TestMethod7()
        {
            string inputString = File.ReadAllText(@"Input6.txt");
            var checker = new SequenceChecker.SequenceChecker();
            Assert.AreEqual(checker.CheckLongestSequence(inputString), "3808 3908 10386 19306");
        }

        [TestMethod]
        public void TestMethod8()
        {
            string inputString = File.ReadAllText(@"Input7.txt");
            var checker = new SequenceChecker.SequenceChecker();
            Assert.AreEqual(checker.CheckLongestSequence(inputString), "125 1841 5882 18464 28317 31497");
        }

        [TestMethod]
        public void TestMethod9()
        {
            string inputString = File.ReadAllText(@"Input8.txt");
            var checker = new SequenceChecker.SequenceChecker();
            Assert.AreEqual(checker.CheckLongestSequence(inputString), "9139 17687 25106 26202 27592 30937");
        }

        [TestMethod]
        public void TestMethod10()
        {
            string inputString = File.ReadAllText(@"Inputt9.txt");
            var checker = new SequenceChecker.SequenceChecker();
            Assert.AreEqual(checker.CheckLongestSequence(inputString), "918 1089 5133 7725 18035 24605 26716 27095");
        }

        [TestMethod]
        public void TestMethod11()
        {
            var checker = new SequenceChecker.SequenceChecker();
            Assert.AreEqual(checker.CheckLongestSequence("6 2 4 6 1 5 9 2"), "2 4 6");
        }
            
        [TestMethod]
        public void TestMethod12()
        {
            var checker = new SequenceChecker.SequenceChecker();
            Assert.AreEqual(checker.CheckLongestSequence("6 2 4 3 1 5 9"), "1 5 9");
        }
    }
}