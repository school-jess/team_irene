using team_irene2.models;

namespace Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestInvalidBirthday()
    {
        irene model = new irene();
        Assert.ThrowsException<Exception>(() => model.birthDay = "03-30-2005");
    }

    [TestMethod]
    public void TestNoFirstName()
    {
        irene model = new irene();
        Assert.ThrowsException<Exception>(() => model.firstName = "");
    }

    [TestMethod]
    public void TestNoLastName()
    {
        irene model = new irene();
        Assert.ThrowsException<Exception>(() => model.lastName = "");
    }

    [TestMethod]
    public void TestNoBirthday()
    {
        irene model = new irene();
        Assert.ThrowsException<Exception>(() => model.birthDay = "");
    }

    [TestMethod]
    public void TestNoHouseNumber()
    {
        irene model = new irene();
        Assert.ThrowsException<Exception>(() => model.houseNumber = "");
    }

    [TestMethod]
    public void TestNoStreet()
    {
        irene model = new irene();
        Assert.ThrowsException<Exception>(() => model.street = "");
    }

    [TestMethod]
    public void TestNoBarangay()
    {
        irene model = new irene();
        Assert.ThrowsException<Exception>(() => model.barangay = "");
    }

    [TestMethod]
    public void TestNoCity()
    {
        irene model = new irene();
        Assert.ThrowsException<Exception>(() => model.city = "");
    }

    [TestMethod]
    public void TestNoProvince()
    {
        irene model = new irene();
        Assert.ThrowsException<Exception>(() => model.province = "");
    }

    [TestMethod]
    public void TestNoCountry()
    {
        irene model = new irene();
        Assert.ThrowsException<Exception>(() => model.country = "");
    }

    [TestMethod]
    public void TestNumberInFirstName()
    {
        irene model = new irene();
        // Assert.ThrowsException<Exception>(() => model.firstName = "");
    }

    [TestMethod]
    public void TestNumberInLastName()
    {
        irene model = new irene();
        // Assert.ThrowsException<Exception>(() => model.lastName = "");
    }

    [TestMethod]
    public void TestNumberInStreet()
    {
        irene model = new irene();
        // Assert.ThrowsException<Exception>(() => model.street = "");
    }

    [TestMethod]
    public void TestNumberInBarangay()
    {
        irene model = new irene();
        // Assert.ThrowsException<Exception>(() => model.barangay = "");
    }

    [TestMethod]
    public void TestNumberInCity()
    {
        irene model = new irene();
        // Assert.ThrowsException<Exception>(() => model.city = "");
    }

    [TestMethod]
    public void TestNumberInProvince()
    {
        irene model = new irene();
        // Assert.ThrowsException<Exception>(() => model.province = "");
    }

    [TestMethod]
    public void TestNumberInCountry()
    {
        irene model = new irene();
        // Assert.ThrowsException<Exception>(() => model.country = "");
    }
}