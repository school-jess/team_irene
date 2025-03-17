using basic_information_library.models;

namespace Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestFirstName()
    {
        BasicInformation model = new BasicInformation();
        model.firstName = "Jess";
        Assert.AreEqual("Jess", model.firstName);
    }

    [TestMethod]
    public void TestMiddleInitial()
    {
        BasicInformation model = new BasicInformation();
        model.middleInitial = "P.";
        Assert.AreEqual("P.", model.firstName);
    }

    [TestMethod]
    public void TestLastName()
    {
        BasicInformation model = new BasicInformation();
        model.lastName = "Evangelista";
        Assert.AreEqual("Evangelista", model.lastName);
    }

    [TestMethod]
    public void TestSuffix()
    {
        BasicInformation model = new BasicInformation();
        model.suffix = "II";
        Assert.AreEqual("II", model.suffix);
    }

    [TestMethod]
    public void TestFullName()
    {
        BasicInformation model = new BasicInformation();
        model.firstName = "Jess Mathew";
        model.middleInitial = "";
        model.lastName = "Evangelista";
        model.suffix = "";
        Assert.AreEqual("Jess Mathew Evangelista", model.fullName);
        model.firstName = "Jess Mathew";
        model.middleInitial = "P.";
        model.lastName = "Evangelista";
        model.suffix = "";
        Assert.AreEqual("Jess Mathew P. Evangelista", model.fullName);
        model.firstName = "Jess Mathew";
        model.middleInitial = "";
        model.lastName = "Evangelista";
        model.suffix = "II";
        Assert.AreEqual("Jess Mathew Evangelista II", model.fullName);
        model.firstName = "Jess Mathew";
        model.middleInitial = "P.";
        model.lastName = "Evangelista";
        model.suffix = "II";
        Assert.AreEqual("Jess Mathew P. Evangelista II", model.fullName);
    }

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
        Assert.ThrowsException<Exception>(() => model.country = "Jess1");
    }

    [TestMethod]
    public void TestNumberInMiddleInitial()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.middleInitial = "P.1");
    }

    [TestMethod]
    public void TestNumberInLastName()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.country = "Evangelista1");
    }

    [TestMethod]
    public void TestNumberInSuffix()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.suffix = "II1");
    }

    [TestMethod]
    public void TestNumberInBarangay()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.country = "Punta Princessa1");
    }

    [TestMethod]
    public void TestNumberInCity()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.country = "Cebu City1");
    }

    [TestMethod]
    public void TestNumberInProvince()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.country = "Cebu1");
    }

    [TestMethod]
    public void TestNumberInCountry()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.country = "Phillipines1");
    }
}