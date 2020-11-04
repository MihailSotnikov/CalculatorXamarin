using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcultorTest.Screens;
using NUnit.Framework;

namespace CalcultorTest
{
    public class TestClass
    {
        [SetUp]
        public void BeforeEachTest()
        {
            AppInitializer.StartApp();
        }
        MainScreen _mainScreen = new MainScreen();
        [Test]
        public void Test()
        {
            _mainScreen.TapOnOne()
                .TapOnPlus()
                .TapOnOne()
                .TapOnEqual();
            Assert.AreEqual("2", _mainScreen.GetTextFromField());
        }
        

    }
}



