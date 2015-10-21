using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yatzhee;

namespace YathzeeTesting
{
  [TestClass]
  public class TeerlingTest
  {

    private Teerling testTeerling;

    [TestInitialize]
    public void initialiazeTeerling()
    {
      testTeerling = new Teerling();
    }

    [TestMethod]
    public void TestProperties()
    {
      Assert.IsTrue(testTeerling.getAantalOgen >= 1 && testTeerling.getAantalOgen <= 6);
    }

    [TestMethod]
    public void TestWerp()
    {
      int[] tellers = new int[6];
     
      for(int i = 0; i < 6; i++)
      {
      tellers[i] = 0;
      }

      for(int i = 0; i < 1000;i++)
      {
        testTeerling.werp();
        Assert.IsTrue(testTeerling.getAantalOgen >= 1 && testTeerling.getAantalOgen <= 6);
        tellers[testTeerling.getAantalOgen -1]++;

      }
       for(int i = 0; i < 6; i++)
      {
Assert.IsTrue(tellers[i] >= 100, "Teerling is niet eerlijk: " + i + " komt te weinig voor");
      }

    }


    [TestMethod]
    public void TestVast()
    {
      testTeerling.werp();
      int aantalOgen = testTeerling.getAantalOgen;
      testTeerling.zetVast();

      for (int i = 0; i < 1000; i++)
      {
        testTeerling.werp();
        Assert.AreEqual(aantalOgen, testTeerling.getAantalOgen);

      }
    }
  }
}
