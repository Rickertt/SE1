using GitHubTestApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for woordOmdraaien
        ///</summary>
        [TestMethod()]
        public void woordOmdraaienTest()
        {
            string input = "fiets";
            string expected = "steif";
            string actual;
            actual = Program.woordOmdraaien(input);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for somDerCijfers
        ///</summary>
        [TestMethod()]
        public void somDerCijfersTest()
        {
            int input = 12345;
            int expected = 6;
            int actual;
            actual = Program.somDerCijfers(input);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for somDerCijfers
        ///</summary>
        [TestMethod()]
        public void somDerCijfersTest2()
        {
            int input = 4;
            int expected = 4;
            int actual;
            actual = Program.somDerCijfers(input);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for vermenigvuldigen
        ///</summary>
        [TestMethod()]
        public void vermenigvuldigenTest()
        {
            int a = 2;
            int b = 3;
            int expected = 6;
            int actual;
            actual = Program.vermenigvuldigen(a, b);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for optellen
        ///</summary>
        [TestMethod()]
        public void optellenTest()
        {
            int a = 10;
            int b = 5;
            int expected = 15;
            int actual;
            actual = Program.optellen(a, b);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for kwadrateren
        ///</summary>
        [TestMethod()]
        public void kwadraterenTest()
        {
            int a = 5;
            int expected = 25;
            int actual;
            actual = Program.kwadrateren(a);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for aftrekken
        ///</summary>
        [TestMethod()]
        public void aftrekkenTest()
        {
            int a = 28;
            int b = 7;
            int expected = 21;
            int actual;
            actual = Program.aftrekken(a, b);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for machtsverheffen
        ///</summary>
        [TestMethod()]
        public void machtsverheffenTest()
        {
            int a = 2;
            int b = 5;
            int expected = 32;
            int actual;
            actual = Program.machtsverheffen(a, b);
            Assert.AreEqual(expected, actual);
        }



        /// <summary>
        ///A test for aantalLettersInWoord
        ///</summary>
        [TestMethod()]
        public void aantalLettersInWoordTest()
        {
            string input = "hottentottententententoonstellingstereinen";
            char letter = 't';
            int expected = 11;
            int actual;
            actual = Program.aantalLettersInWoord(input, letter);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for aantalWoordenInZin
        ///</summary>
        [TestMethod()]
        public void aantalWoordenInZinTest()
        {
            string inputString = "Omdat ik boos ben";
            int expected = 4;
            int actual;
            actual = Program.aantalWoordenInZin(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
}
