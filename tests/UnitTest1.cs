using basic_information_library.models;
using basic_information_library;
using MySql.Data.MySqlClient;

namespace Tests;

[TestClass]
public class TestModel
{
    private BasicInformation model;

    [TestInitialize]
    public void Setup()
    {
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

    [ClassInitialize]
    public static void classSetup(TestContext ctx)
    {
    }

    [TestInitialize]
    public void Setup()
    {
        db = new Database();
        db.Connect("root");
        model = new BasicInformation();
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
        db.Insert(model);
        MySqlDataReader data = db.Select(model.firstName);
        BasicInformation newModel = new BasicInformation();
        while (data.Read())
        {
            newModel.firstName = (string)data["first_name"];
            string middleInitial = "";
            var dataMiddleInitial = data["middle_initial"];
            if (dataMiddleInitial.GetType().Name != "DBNull")
            {
                middleInitial = (string)dataMiddleInitial;
            }
            newModel.middleInitial = middleInitial;
            newModel.lastName = (string)data["last_name"];
            string suffix = "";
            var dataSuffix = data["suffix"];
            if (dataSuffix.GetType().Name != "DBNull")
            {
                suffix = (string)dataSuffix;
            }
            newModel.suffix = suffix;
            newModel.birthday = Convert.ToDateTime(data["birthday"]).ToString("yyyy-MM-dd");
            newModel.houseNumber = (string)data["house_number"];
            newModel.street = (string)data["street_name"];
            newModel.barangay = (string)data["barangay"];
            newModel.city = (string)data["city"];
            newModel.province = (string)data["province"];
            newModel.country = (string)data["country"];
        }
        db.CloseReader(data);
        db.Remove(model.firstName);
        Console.WriteLine($"{newModel.firstName} {newModel.middleInitial} {newModel.lastName} {newModel.fullName} {newModel.birthday} {newModel.age} {newModel.houseNumber} {newModel.street} {newModel.barangay} {newModel.city} {newModel.province} {newModel.country}");
        if (model.firstName != newModel.firstName)
        {
            Assert.Fail();
        }
        else if (model.middleInitial != newModel.middleInitial)
        {
            Assert.Fail();
        }
        else if (model.lastName != newModel.lastName)
        {
            Assert.Fail();
        }
        else if (model.suffix != newModel.suffix)
        {
            Assert.Fail();
        }
        else if (model.fullName != newModel.fullName)
        {
            Assert.Fail();
        }
        else if (model.birthday != newModel.birthday)
        {
            Assert.Fail();
        }
        else if (model.age != newModel.age)
        {
            Assert.Fail();
        }
        else if (model.houseNumber != newModel.houseNumber)
        {
            Assert.Fail();
        }
        else if (model.street != newModel.street)
        {
            Assert.Fail();
        }
        else if (model.barangay != newModel.barangay)
        {
            Assert.Fail();
        }
        else if (model.city != newModel.city)
        {
            Assert.Fail();
        }
        else if (model.province != newModel.province)
        {
            Assert.Fail();
        }
        else if (model.country != newModel.country)
        {
            Assert.Fail();
        }
    }

    [TestMethod]
    public void TestDatabaseSelect()
    {
        try
        {
            MySqlDataReader data = db.Select(null);
            while (data.Read())
            {
            }
            db.CloseReader(data);
        }
        catch
        {
            throw new Exception();
        }
    }
}