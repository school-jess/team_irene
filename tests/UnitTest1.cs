using basic_information_library.models;

namespace Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestInvalidBirthday()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.birthDay = "03-30-2005");
    }

    [TestMethod]
    public void TestNoFirstName()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.firstName = "");
    }

    [TestMethod]
    public void TestNoLastName()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.lastName = "");
    }

    [TestMethod]
    public void TestNoBirthday()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.birthDay = "");
    }

    [TestMethod]
    public void TestNoHouseNumber()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.houseNumber = "");
    }

    [TestMethod]
    public void TestNoStreet()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.street = "");
    }

    [TestMethod]
    public void TestNoBarangay()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.barangay = "");
    }

    [TestMethod]
    public void TestNoCity()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.city = "");
    }

    [TestMethod]
    public void TestNoProvince()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.province = "");
    }

    [TestMethod]
    public void TestNoCountry()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.country = "");
    }

    [TestMethod]
    public void TestNumberInFirstName()
    {
        BasicInformation model = new BasicInformation();
        Console.WriteLine("todo");
        Assert.Fail();
    }

    [TestMethod]
    public void TestNumberInLastName()
    {
        BasicInformation model = new BasicInformation();
        Console.WriteLine("todo");
        Assert.Fail();
    }

    [TestMethod]
    public void TestNumberInStreet()
    {
        BasicInformation model = new BasicInformation();
        Console.WriteLine("todo");
        Assert.Fail();
    }

    [TestMethod]
    public void TestNumberInBarangay()
    {
        BasicInformation model = new BasicInformation();
        Console.WriteLine("todo");
        Assert.Fail();
    }

    [TestMethod]
    public void TestNumberInCity()
    {
        BasicInformation model = new BasicInformation();
        Console.WriteLine("todo");
        Assert.Fail();
    }

    [TestMethod]
    public void TestNumberInProvince()
    {
        BasicInformation model = new BasicInformation();
        Console.WriteLine("todo");
        Assert.Fail();
    }

    [TestMethod]
    public void TestNumberInCountry()
    {
        BasicInformation model = new BasicInformation();
        Console.WriteLine("todo");
        Assert.Fail();
    }
}