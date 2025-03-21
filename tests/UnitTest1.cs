using basic_information_library.models;

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
        model.first_name = "jess";
        Assert.AreEqual("Jess", model.first_name);
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
        model.last_name = "evangelista";
        Assert.AreEqual("Evangelista", model.last_name);
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
        model.first_name = "jess mathew";
        model.middleInitial = "";
        model.last_name = "evangelista";
        model.suffix = "";
        Assert.AreEqual("Jess Mathew Evangelista", model.fullName);
        model.first_name = "jess mathew";
        model.middleInitial = "p";
        model.last_name = "evangelista";
        model.suffix = "";
        Assert.AreEqual("Jess Mathew P. Evangelista", model.fullName);
        model.first_name = "jess mathew";
        model.middleInitial = "";
        model.last_name = "evangelista";
        model.suffix = "II";
        Assert.AreEqual("Jess Mathew Evangelista II", model.fullName);
        model.first_name = "jess mathew";
        model.middleInitial = "p";
        model.last_name = "evangelista";
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
        Assert.ThrowsException<Exception>(() => model.first_name = "");
    }

    [TestMethod]
    public void TestNoLastName()
    {
        Assert.ThrowsException<Exception>(() => model.last_name = "");
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
        Assert.ThrowsException<Exception>(() => model.first_name = "aaaaaaaaaaaaaaaaaaaaa");
    }

    [TestMethod]
    public void TestMiddleInitialTooLong()
    {
        Assert.ThrowsException<Exception>(() => model.middleInitial = "aaaaaaaaaaa");
    }

    [TestMethod]
    public void TestLastNameTooLong()
    {
        Assert.ThrowsException<Exception>(() => model.last_name = "aaaaaaaaaaaaaaaaaaaaa");
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
        model.first_name = "random first`";
        model.middleInitial = "";
        model.last_name = "random last";
        model.suffix = "";
        model.birthday = "2005-03-30";
        model.houseNumber = "239 F.";
        model.street = "daclan private road";
        model.barangay = "punta princessa";
        model.city = "cebu city";
        model.province = "cebu";
        model.country = "philippines";
        db.Insert(model);
        MySqlDataReader data = db.Select(model.fullName);
        BasicInformation newModel = new BasicInformation();
        while (data.Read())
        {
            newModel.first_name = (string)data["first_name"];
            string middleInitial = "";
            var dataMiddleInitial = data["middle_initial"];
            if (dataMiddleInitial.GetType().Name != "DBNull")
            {
                middleInitial = (string)dataMiddleInitial;
            }
            newModel.middleInitial = middleInitial;
            newModel.last_name = (string)data["last_name"];
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
        db.Remove(model.fullName);
        Assert.AreEqual(model.first_name, newModel.first_name);
        Assert.AreEqual(model.middleInitial, newModel.middleInitial);
        Assert.AreEqual(model.last_name, newModel.last_name);
        Assert.AreEqual(model.suffix, newModel.suffix);
        Assert.AreEqual(model.fullName, newModel.fullName);
        Assert.AreEqual(model.birthday, newModel.birthday);
        Assert.AreEqual(model.age, newModel.age);
        Assert.AreEqual(model.houseNumber, newModel.houseNumber);
        Assert.AreEqual(model.street, newModel.street);
        Assert.AreEqual(model.barangay, newModel.barangay);
        Assert.AreEqual(model.city, newModel.city);
        Assert.AreEqual(model.province, newModel.province);
        Assert.AreEqual(model.country, newModel.country);
    }

    [TestMethod]
    public void TestDatabaseSelect()
    {
        try
        {
            List<BasicInformation> models = new List<BasicInformation>();
            MySqlDataReader data = db.Select(null);
            while (data.Read())
            {
                BasicInformation model = new BasicInformation();
                model.first_name = (string)data["first_name"];
                string middleInitial = "";
                var dataMiddleInitial = data["middle_initial"];
                if (dataMiddleInitial.GetType().Name != "DBNull")
                {
                    middleInitial = (string)dataMiddleInitial;
                }
                model.middleInitial = middleInitial;
                model.last_name = (string)data["last_name"];
                string suffix = "";
                var dataSuffix = data["suffix"];
                if (dataSuffix.GetType().Name != "DBNull")
                {
                    suffix = (string)dataSuffix;
                }
                model.suffix = suffix;
                model.birthday = Convert.ToDateTime(data["birthday"]).ToString("yyyy-MM-dd");
                model.houseNumber = (string)data["house_number"];
                model.street = (string)data["street_name"];
                model.barangay = (string)data["barangay"];
                model.city = (string)data["city"];
                model.province = (string)data["province"];
                model.country = (string)data["country"];
                models.Add(model);
            }
            db.CloseReader(data);
            var adults = (from model in models
                          where model.age >= 18
                          select model).Take(1).ToList();
            BasicInformation actualModel = models[0];
            BasicInformation expectedModel = new BasicInformation();
            expectedModel.first_name = "jess mathew";
            expectedModel.middleInitial = "p";
            expectedModel.last_name = "evangelista";
            expectedModel.birthday = "2005-03-30";
            expectedModel.suffix = "";
            expectedModel.houseNumber = "239 F.";
            expectedModel.street = "daclan private road";
            expectedModel.barangay = "punta princessa";
            expectedModel.city = "cebu city";
            expectedModel.province = "cebu";
            expectedModel.country = "philippines";
            Assert.AreEqual(expectedModel.first_name, actualModel.first_name);
            Assert.AreEqual(expectedModel.middleInitial, actualModel.middleInitial);
            Assert.AreEqual(expectedModel.last_name, actualModel.last_name);
            Assert.AreEqual(expectedModel.suffix, actualModel.suffix);
            Assert.AreEqual(expectedModel.fullName, actualModel.fullName);
            Assert.AreEqual(expectedModel.birthday, actualModel.birthday);
            Assert.AreEqual(expectedModel.age, actualModel.age);
            Assert.AreEqual(expectedModel.houseNumber, actualModel.houseNumber);
            Assert.AreEqual(expectedModel.street, actualModel.street);
            Assert.AreEqual(expectedModel.barangay, actualModel.barangay);
            Assert.AreEqual(expectedModel.city, actualModel.city);
            Assert.AreEqual(expectedModel.province, actualModel.province);
            Assert.AreEqual(expectedModel.country, actualModel.country);
        }
        catch
        {
            throw new Exception();
        }
    }
}