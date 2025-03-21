using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestDrivenDev;

[TestClass]
public class HerniPostavaTests
{
    [TestMethod]
    public void NameTest_Valid()
    {
        var postava = new HerniPostava("Jmeno");
        postava.Jmeno = "ValidName";
        Assert.AreEqual("ValidName", postava.Jmeno);
    }

    [TestMethod]
    public void NameTest_NameIsTooLong_Invalid()
    {
        var postava = new HerniPostava("Jmeno");
        postava.Jmeno = "ThisIsTooLongName";
        Assert.AreNotEqual("Jmeno", postava.Jmeno);
    }

    [TestMethod]
    public void NameTest_Empty_Invalid()
    {
        var postava = new HerniPostava("Jmeno");
        postava.Jmeno = "";
        Assert.AreNotEqual("", postava.Jmeno);
    }

    [TestMethod]
    public void PositionTests_Valid()
    {
        var postava = new HerniPostava("Jmeno");
        Assert.AreEqual(0, postava.PoziceX);
        Assert.AreEqual(0, postava.PoziceY);
    }

    [TestMethod]
    public void PositionChangeTest_Positive_Valid()
    {
        var postava = new HerniPostava("Jmeno");
        postava.ZmenaPozice(10, 20);
        Assert.AreEqual(10, postava.PoziceX);
        Assert.AreEqual(20, postava.PoziceY);
    }

    [TestMethod]
    public void PositionChangeTest_Negative_Valid()
    {
        var postava = new HerniPostava("Jmeno");
        postava.ZmenaPozice(-5, -10);
        Assert.AreEqual(-5, postava.PoziceX);
        Assert.AreEqual(-10, postava.PoziceY);
    }

    [TestMethod]
    public void PositionChangeTest_Extreme_Valid()
    {
        var postava = new HerniPostava("Jmeno");
        postava.ZmenaPozice(-1000, 2000);
        Assert.AreEqual(-1000, postava.PoziceX);
        Assert.AreEqual(2000, postava.PoziceY);
    }

    [TestMethod]
    public void TestToString_Valid()
    {
        var postava = new HerniPostava("Jmeno");
        var result = postava.ToString();
        Assert.AreEqual("Jméno: Jmeno, Level: 1, Pozice X: 0, Pozice Y: 0", result);
    }

    [TestMethod]
    public void TestToString_Updated_Valid()
    {
        var postava = new HerniPostava("Jmeno");
        postava.ZmenaPozice(5, 10);
        var result = postava.ToString();
        Assert.AreEqual("Jméno: Jmeno, Level: 1, Pozice X: 5, Pozice Y: 10", result);
    }
}





[TestClass]
public class HracTests
{
    [TestMethod]
    public void SpecialTest_Valid()
    {
        var hrac = new Hrac("Hrac", "Kouzelník");
        hrac.Specializace = "Inženýr";
        Assert.AreEqual("Inženýr", hrac.Specializace);
    }

    [TestMethod]
    public void SpecialTest_NotOneOfClasses_Invalid()
    {
        var hrac = new Hrac("Hrac", "Kouzelník");
        hrac.Specializace = "Invalid";
        Assert.AreNotEqual("Kouzelník", hrac.Specializace);
    }

    [TestMethod]
    public void SpecialTest_Empty_Invalid()
    {
        var hrac = new Hrac("Hrac", "Kouzelník");
        hrac.Specializace = "";
        Assert.AreNotEqual("Kouzelník", hrac.Specializace);
    }






    [TestMethod]
    public void XpInitTest_Valid()
    {
        var hrac = new Hrac("Hrac", "Berserker");
        Assert.AreEqual(0, hrac.XP);
    }

    public void XpInitTest_Invalid()
    {
        var hrac = new Hrac("Hrac", "Berserker");
        Assert.AreNotEqual(1, hrac.XP);
    }





    [TestMethod]
    public void XpIncreaseTest_Valid()
    {
        var hrac = new Hrac("Hrac", "Kouzelník");
        hrac.XP = 100;
        Assert.AreEqual(100, hrac.XP);
    }

    [TestMethod]
    public void XpDecreaseTest_Valid()
    {
        var hrac = new Hrac("Hrac", "Berserker");
        hrac.XP = 50;
        hrac.XP = 30;
        Assert.AreEqual(30, hrac.XP);
    }






    [TestMethod]
    public void TestOblicej_InitialValue_ShouldBeVelkyNos()
    {
        var hrac = new Hrac("Hrac", "Inženýr");
        Assert.AreEqual(Oblicej.VelkyNos, hrac.oblicej);
    }

    [TestMethod]
    public void TestVlasy_InitialValue_ShouldBeDrdol()
    {
        var hrac = new Hrac("Hrac", "Inženýr");
        Assert.AreEqual(Vlasy.Drdol, hrac.vlasy);
    }

    [TestMethod]
    public void TestBarvaVlasu_InitialValue_ShouldBeKastanova()
    {
        var hrac = new Hrac("Hrac", "Inženýr");
        Assert.AreEqual(BarvaVlasu.Kastanova, hrac.barvaVlasu);
    }





    [TestMethod]
    public void TestToString_ShouldReturnCorrectStringIncludingSpecializaceXP()
    {
        var hrac = new Hrac("Hrac", "Kouzelník");
        var result = hrac.ToString();
        Assert.AreEqual("Jméno: Hrac, Level: 1, Pozice X: 0, Pozice Y: 0, Specializace: Kouzelník, Obličej: VelkýNos, Vlasy: Drdol, Barva Vlasů: Kaštanová, XP: 0", result);
    }

    [TestMethod]
    public void TestToString_AfterChangingPositionAndXP_ShouldReflectChanges()
    {
        var hrac = new Hrac("Hrac", "Kouzelník");
        hrac.ZmenaPozice(15, 25);
        hrac.XP = 100;
        var result = hrac.ToString();
        Assert.AreEqual("Jméno: Hrac, Level: 1, Pozice X: 15, Pozice Y: 25, Specializace: Kouzelník, Obličej: VelkýNos, Vlasy: Drdol, Barva Vlasů: Kaštanová, XP: 100", result);
    }

    [TestMethod]
    public void TestSpecializace_Kouzelnik_ShouldBeAccepted()
    {
        var hrac = new Hrac("Hrac", "Kouzelník");
        hrac.Specializace = "Kouzelník";
        Assert.AreEqual("Kouzelník", hrac.Specializace);
    }

    [TestMethod]
    public void TestSpecializace_Berserker_ShouldBeAccepted()
    {
        var hrac = new Hrac("Hrac", "Berserker");
        hrac.Specializace = "Berserker";
        Assert.AreEqual("Berserker", hrac.Specializace);
    }

    [TestMethod]
    public void TestSpecializace_Cizak_ShouldBeAccepted()
    {
        var hrac = new Hrac("Hrac", "Cizák");
        hrac.Specializace = "Cizák";
        Assert.AreEqual("Cizák", hrac.Specializace);
    }

    [TestMethod]
    public void TestSpecializace_Inzenyr_ShouldBeAccepted()
    {
        var hrac = new Hrac("Hrac", "Inženýr");
        hrac.Specializace = "Inženýr";
        Assert.AreEqual("Inženýr", hrac.Specializace);
    }
}