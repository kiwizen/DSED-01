using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSED_01_App;

namespace UnitTestDSED_01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BombInBoxGame game = new BombInBoxGame();
            game.NewGame();
            int expected = 1;
            int actual = game.CurrentBoxID;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            BombInBoxGame game = new BombInBoxGame();
            game.NewGame();
            int expected = game.SecretBoxID;
            int actual = game.CurrentBoxID;

            Assert.AreEqual(expected, actual);
        }
    }
}
