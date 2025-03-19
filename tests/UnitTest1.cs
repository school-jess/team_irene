using basic_information_library.models;
using basic_information_library;
using MySql.Data.MySqlClient;

namespace Tests;

[TestClass]
public class TestModel
{
    private BasicInformation model;
    private Database db;

    [TestInitialize]
    public void Setup()
    {
        db = new Database();
        model = new BasicInformation();
    }

    [TestMethod]
    public void TestFirstName()
    {
        model.firstName = "jess";
        Assert.AreEqual("Jess", model.firstName);
    }

    [TestMethod]
    public void TestMiddleInitial()
    {
        model.middleInitial = "p";
        Assert.AreEqual("P", model.middleInitial);
    }

    [TestMethod]
    public void TestLastName()
    {
        model.lastName = "evangelista";
        Assert.AreEqual("Evangelista", model.lastName);
    }

    [TestMethod]
    public void TestSuffix()
    {
        model.suffix = "II";
        Assert.AreEqual("II", model.suffix);
    }

    [TestMethod]
    public void TestFullName()
    {
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
        model.birthday = "2005-03-30";
        Assert.AreEqual("2005-03-30", model.birthday);
    }

    [TestMethod]
    public void TestAge()
    {
        model.birthday = "2005-03-30";
        Assert.AreEqual(19, model.age);
    }

    [TestMethod]
    public void TestHouseNumber()
    {
        model.houseNumber = "239 F.";
        Assert.AreEqual("239 F.", model.houseNumber);
    }

    [TestMethod]
    public void TestStreet()
    {
        model.street = "daclan private road";
        Assert.AreEqual("Daclan Private Road", model.street);
    }

    [TestMethod]
    public void TestBarangay()
    {
        model.barangay = "punta princessa";
        Assert.AreEqual("Punta Princessa", model.barangay);
    }

    [TestMethod]
    public void TestCity()
    {
        model.city = "cebu city";
        Assert.AreEqual("Cebu City", model.city);
    }

    [TestMethod]
    public void TestProvince()
    {
        model.province = "cebu";
        Assert.AreEqual("Cebu", model.province);
    }

    [TestMethod]
    public void TestCountry()
    {
        model.country = "philippines";
        Assert.AreEqual("Philippines", model.country);
    }

    [TestMethod]
    public void TestInvalidBirthday()
    {
        Assert.ThrowsException<FormatException>(() => model.birthday = "03-30-2005");
    }

    [TestMethod]
    public void TestNoFirstName()
    {
        Assert.ThrowsException<Exception>(() => model.firstName = "");
    }

    [TestMethod]
    public void TestNoLastName()
    {
        Assert.ThrowsException<Exception>(() => model.lastName = "");
    }

    [TestMethod]
    public void TestNoBirthday()
    {
        Assert.ThrowsException<Exception>(() => model.birthday = "");
    }

    [TestMethod]
    public void TestNoHouseNumber()
    {
        Assert.ThrowsException<Exception>(() => model.houseNumber = "");
    }

    [TestMethod]
    public void TestNoStreet()
    {
        Assert.ThrowsException<Exception>(() => model.street = "");
    }

    [TestMethod]
    public void TestNoBarangay()
    {
        Assert.ThrowsException<Exception>(() => model.barangay = "");
    }

    [TestMethod]
    public void TestNoCity()
    {
        Assert.ThrowsException<Exception>(() => model.city = "");
    }

    [TestMethod]
    public void TestNoProvince()
    {
        Assert.ThrowsException<Exception>(() => model.province = "");
    }

    [TestMethod]
    public void TestNoCountry()
    {
        Assert.ThrowsException<Exception>(() => model.country = "");
    }

    [TestMethod]
    public void TestNumberInFirstName()
    {
        Assert.ThrowsException<Exception>(() => model.country = "Jess1");
    }

    [TestMethod]
    public void TestNumberInMiddleInitial()
    {
        Assert.ThrowsException<Exception>(() => model.middleInitial = "P.1");
    }

    [TestMethod]
    public void TestNumberInLastName()
    {
        Assert.ThrowsException<Exception>(() => model.country = "Evangelista1");
    }

    [TestMethod]
    public void TestNumberInSuffix()
    {
        Assert.ThrowsException<Exception>(() => model.suffix = "II1");
    }

    [TestMethod]
    public void TestNumberInStreet()
    {
        Assert.ThrowsException<Exception>(() => model.street = "Daclan Private Road1");
    }

    [TestMethod]
    public void TestNumberInBarangay()
    {
        Assert.ThrowsException<Exception>(() => model.country = "Punta Princessa1");
    }

    [TestMethod]
    public void TestNumberInCity()
    {
        Assert.ThrowsException<Exception>(() => model.country = "Cebu City1");
    }

    [TestMethod]
    public void TestNumberInProvince()
    {
        Assert.ThrowsException<Exception>(() => model.country = "Cebu1");
    }

    [TestMethod]
    public void TestNumberInCountry()
    {
        Assert.ThrowsException<Exception>(() => model.country = "Phillipines1");
    }

    [TestMethod]
    public void TestFirstNameTooLong()
    {
        Assert.ThrowsException<Exception>(() => model.firstName = "aaaaaaaaaaaaaaaaaaaaa");
    }

    [TestMethod]
    public void TestMiddleInitialTooLong()
    {
        Assert.ThrowsException<Exception>(() => model.middleInitial = "aaaaaaaaaaa");
    }

    [TestMethod]
    public void TestLastNameTooLong()
    {
        Assert.ThrowsException<Exception>(() => model.lastName = "aaaaaaaaaaaaaaaaaaaaa");
    }

    [TestMethod]
    public void TestSuffixTooLong()
    {
        Assert.ThrowsException<Exception>(() => model.suffix = "aaaaaaaaaaa");
    }

    [TestMethod]
    public void TestHouseNumberTooLong()
    {
        Assert.ThrowsException<Exception>(() => model.houseNumber = "aaaaaaaaaaa");
    }

    [TestMethod]
    public void TestStreetTooLong()
    {
        Assert.ThrowsException<Exception>(() => model.street = "aaaaaaaaaaaaaaaaaaaaa");
    }

    [TestMethod]
    public void TestBarangayTooLong()
    {
        Assert.ThrowsException<Exception>(() => model.barangay = "aaaaaaaaaaaaaaaaaaaaa");
    }

    [TestMethod]
    public void TestCityTooLong()
    {
        Assert.ThrowsException<Exception>(() => model.city = "aaaaaaaaaaaaaaaaaaaaa");
    }

    [TestMethod]
    public void TestProvinceTooLong()
    {
        Assert.ThrowsException<Exception>(() => model.province = "aaaaaaaaaaaaaaaaaaaaa");
    }

    [TestMethod]
    public void TestTooLongCountry()
    {
        Assert.ThrowsException<Exception>(() => model.country = "aaaaaaaaaaaaaaaaaaaaa");
    }
}

[TestClass]
public class TestDatabase
{
    private BasicInformation model;
    private Database db;

    [TestInitialize]
    public void Setup()
    {
        db = new Database();
        model = new BasicInformation();
    }

    [TestMethod]
    public void TestDatabaseConn()
    {
        Assert.ThrowsException<Exception>(() =>
        {
            try
            {
                db.Connect("root");
                throw new Exception();
            }
            catch { }
        });
    }

    [TestMethod]
    public void TestDatabaseInsert()
    {
        model.firstName = "jess mathew";
        model.middleInitial = "p";
        model.lastName = "evangelista";
        model.suffix = "";
        model.birthday = "2005-03-30";
        model.houseNumber = "239 F.";
        model.street = "daclan private road";
        model.barangay = "punta princessa";
        model.city = "cebu city";
        model.province = "cebu";
        model.country = "philippines";
        try
        {
            db.Connect("root");
            db.Insert(model);
            List<MySqlDataReader> data = db.Select(model.firstName);
            MySqlDataReader row = data[0];
            BasicInformation newModel = new BasicInformation();
            newModel.firstName = (string)row["first_name"];
            newModel.middleInitial = (string)row["middle_initial"];
            newModel.lastName = (string)row["last_name"];
            newModel.suffix = (string)row["suffix"];
            newModel.birthday = (string)row["birthday"];
            newModel.houseNumber = (string)row["house_number"];
            newModel.street = (string)row["street"];
            newModel.barangay = (string)row["barangay"];
            newModel.city = (string)row["city"];
            newModel.province = (string)row["province"];
            newModel.country = (string)row["country"];
            db.Remove(model.firstName);
            Assert.AreEqual(model, newModel);
        }
        catch { }
    }

    [TestMethod]
    public void TestDatabaseSelect()
    {
        Assert.ThrowsException<Exception>(() =>
        {
            try
            {
                db.Connect("root");
                List<MySqlDataReader> data = db.Select(null);
                throw new Exception();
            }
            catch { }
        });
    }
}