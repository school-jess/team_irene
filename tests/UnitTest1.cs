using basic_information_library.models;

namespace Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestFirstName()
    {
        BasicInformation model = new BasicInformation();
        model.firstName = "jess";
        Assert.AreEqual("Jess", model.firstName);
    }

    [TestMethod]
    public void TestMiddleInitial()
    {
        BasicInformation model = new BasicInformation();
        model.middleInitial = "p";
        Assert.AreEqual("P", model.middleInitial);
    }

    [TestMethod]
    public void TestLastName()
    {
        BasicInformation model = new BasicInformation();
        model.lastName = "evangelista";
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
        model.firstName = "jess mathew";
        model.middleInitial = "";
        model.lastName = "evangelista";
        model.suffix = "";
        Assert.AreEqual("Jess Mathew Evangelista", model.fullName);
        model.firstName = "jess mathew";
        model.middleInitial = "p";
        model.lastName = "evangelista";
        model.suffix = "";
        Assert.AreEqual("Jess Mathew P. Evangelista", model.fullName);
        model.firstName = "jess mathew";
        model.middleInitial = "";
        model.lastName = "evangelista";
        model.suffix = "II";
        Assert.AreEqual("Jess Mathew Evangelista II", model.fullName);
        model.firstName = "jess mathew";
        model.middleInitial = "p";
        model.lastName = "evangelista";
        model.suffix = "II";
        Assert.AreEqual("Jess Mathew P. Evangelista II", model.fullName);
    }

    [TestMethod]
    public void TestBirthday()
    {
        BasicInformation model = new BasicInformation();
        model.birthDay = "2005-03-30";
        Assert.AreEqual("2005-03-30", model.birthDay);
    }

    [TestMethod]
    public void TestAge()
    {
        BasicInformation model = new BasicInformation();
        model.birthDay = "2005-03-30";
        Assert.AreEqual(19, model.age);
    }

    [TestMethod]
    public void TestHouseNumber()
    {
        BasicInformation model = new BasicInformation();
        model.houseNumber = "239 F.";
        Assert.AreEqual("239 F.", model.houseNumber);
    }

    [TestMethod]
    public void TestStreet()
    {
        BasicInformation model = new BasicInformation();
        model.street = "daclan private road";
        Assert.AreEqual("Daclan Private Road", model.street);
    }

    [TestMethod]
    public void TestBarangay()
    {
        BasicInformation model = new BasicInformation();
        model.barangay = "punta princessa";
        Assert.AreEqual("Punta Princessa", model.barangay);
    }

    [TestMethod]
    public void TestCity()
    {
        BasicInformation model = new BasicInformation();
        model.city = "cebu city";
        Assert.AreEqual("Cebu City", model.city);
    }

    [TestMethod]
    public void TestProvince()
    {
        BasicInformation model = new BasicInformation();
        model.province = "cebu";
        Assert.AreEqual("Cebu", model.province);
    }

    [TestMethod]
    public void TestCountry()
    {
        BasicInformation model = new BasicInformation();
        model.country = "philippines";
        Assert.AreEqual("Philippines", model.country);
    }

    [TestMethod]
    public void TestInvalidBirthday()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<FormatException>(() => model.birthDay = "03-30-2005");
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
    public void TestNumberInStreet()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.street = "Daclan Private Road1");
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

    [TestMethod]
    public void TestFirstNameTooLong()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.firstName = "aaaaaaaaaaaaaaaaaaaaa");
    }

    [TestMethod]
    public void TestMiddleInitialTooLong()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.middleInitial = "aaaaaaaaaaa");
    }

    [TestMethod]
    public void TestLastNameTooLong()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.lastName = "aaaaaaaaaaaaaaaaaaaaa");
    }

    [TestMethod]
    public void TestSuffixTooLong()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.suffix = "aaaaaaaaaaa");
    }

    [TestMethod]
    public void TestHouseNumberTooLong()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.houseNumber = "aaaaaaaaaaa");
    }

    [TestMethod]
    public void TestStreetTooLong()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.street = "aaaaaaaaaaaaaaaaaaaaa");
    }

    [TestMethod]
    public void TestBarangayTooLong()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.barangay = "aaaaaaaaaaaaaaaaaaaaa");
    }

    [TestMethod]
    public void TestCityTooLong()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.city = "aaaaaaaaaaaaaaaaaaaaa");
    }

    [TestMethod]
    public void TestProvinceTooLong()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.province = "aaaaaaaaaaaaaaaaaaaaa");
    }

    [TestMethod]
    public void TestTooLongCountry()
    {
        BasicInformation model = new BasicInformation();
        Assert.ThrowsException<Exception>(() => model.country = "aaaaaaaaaaaaaaaaaaaaa");
    }
}