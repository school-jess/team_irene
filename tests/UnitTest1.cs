using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using basic_information_library.models;
using System.Globalization;

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
        model.middle_initial = "p";
        Assert.AreEqual("P", model.middle_initial);
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
        model.middle_initial = "";
        model.last_name = "evangelista";
        model.suffix = "";
        Assert.AreEqual("Jess Mathew Evangelista", model.full_name);
        model.first_name = "jess mathew";
        model.middle_initial = "p";
        model.last_name = "evangelista";
        model.suffix = "";
        Assert.AreEqual("Jess Mathew P. Evangelista", model.full_name);
        model.first_name = "jess mathew";
        model.middle_initial = "";
        model.last_name = "evangelista";
        model.suffix = "II";
        Assert.AreEqual("Jess Mathew Evangelista II", model.full_name);
        model.first_name = "jess mathew";
        model.middle_initial = "p";
        model.last_name = "evangelista";
        model.suffix = "II";
        Assert.AreEqual("Jess Mathew P. Evangelista II", model.full_name);
    }

    [TestMethod]
    public void TestBirthday()
    {
        model.birthday = DateTime.ParseExact("2005-03-30", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        throw new Exception("todo");
    }

    [TestMethod]
    public void TestAge()
    {
        model.birthday = DateTime.ParseExact("2005-03-30", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        Assert.AreEqual(20, model.age);
    }

    [TestMethod]
    public void TestHouseNumber()
    {
        model.house_number = "239 F.";
        Assert.AreEqual("239 F.", model.house_number);
    }

    [TestMethod]
    public void TestStreet()
    {
        model.street_name = "daclan private road";
        Assert.AreEqual("Daclan Private Road", model.street_name);
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
        throw new Exception("todo");
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
        throw new Exception("todo");
    }

    [TestMethod]
    public void TestNoHouseNumber()
    {
        Assert.ThrowsException<Exception>(() => model.house_number = "");
    }

    [TestMethod]
    public void TestNoStreet()
    {
        Assert.ThrowsException<Exception>(() => model.street_name = "");
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
        Assert.ThrowsException<Exception>(() => model.middle_initial = "P.1");
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
        Assert.ThrowsException<Exception>(() => model.street_name = "Daclan Private Road1");
    }

    [TestMethod]
    public void TestNumberInBarangay()
    {
        Assert.ThrowsException<Exception>(() => model.barangay = "Punta Princessa1");
    }

    [TestMethod]
    public void TestNumberInCity()
    {
        Assert.ThrowsException<Exception>(() => model.city = "Cebu City1");
    }

    [TestMethod]
    public void TestNumberInProvince()
    {
        Assert.ThrowsException<Exception>(() => model.province = "Cebu1");
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
        Assert.ThrowsException<Exception>(() => model.middle_initial = "aaaaaaaaaaa");
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
        Assert.ThrowsException<Exception>(() => model.house_number = "aaaaaaaaaaa");
    }

    [TestMethod]
    public void TestStreetTooLong()
    {
        Assert.ThrowsException<Exception>(() => model.street_name = "aaaaaaaaaaaaaaaaaaaaa");
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
    private DatabaseCtx dbCtx;

    [TestInitialize]
    public void Setup()
    {
        model = new BasicInformation();
        var config = new ConfigurationBuilder().AddUserSecrets<TestDatabase>().Build();
        var options = new DbContextOptionsBuilder<DatabaseCtx>()
            .UseMySQL(config["MYSQL_TEST_CONN_STR"])
            .Options;
        dbCtx = new DatabaseCtx(options);
        dbCtx.Database.EnsureDeleted();
        dbCtx.Database.EnsureCreated();
    }

    [TestMethod]
    public void TestDatabaseInsert()
    {
        model.first_name = "random first`";
        model.middle_initial = "";
        model.last_name = "random last";
        model.suffix = "";
        model.birthday = DateTime.ParseExact("2005-03-30", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        model.house_number = "239 F.";
        model.street_name = "daclan private road";
        model.barangay = "punta princessa";
        model.city = "cebu city";
        model.province = "cebu";
        model.country = "philippines";
        dbCtx.first_table.Add(model);
        dbCtx.SaveChanges();
        var savedPersonalDetail = dbCtx.first_table.FirstOrDefault(personalDetail => personalDetail.id == model.id);
        Assert.IsNotNull(savedPersonalDetail);
        Assert.AreEqual(model.first_name, savedPersonalDetail.first_name);
        Assert.AreEqual(model.middle_initial, savedPersonalDetail.middle_initial);
        Assert.AreEqual(model.last_name, savedPersonalDetail.last_name);
        Assert.AreEqual(model.suffix, savedPersonalDetail.suffix);
        Assert.AreEqual(model.full_name, savedPersonalDetail.full_name);
        Assert.AreEqual(model.birthday, savedPersonalDetail.birthday);
        Assert.AreEqual(model.age, savedPersonalDetail.age);
        Assert.AreEqual(model.house_number, savedPersonalDetail.house_number);
        Assert.AreEqual(model.street_name, savedPersonalDetail.street_name);
        Assert.AreEqual(model.barangay, savedPersonalDetail.barangay);
        Assert.AreEqual(model.city, savedPersonalDetail.city);
        Assert.AreEqual(model.province, savedPersonalDetail.province);
        Assert.AreEqual(model.country, savedPersonalDetail.country);
    }

    [TestMethod]
    public void TestDatabaseSelect()
    {
        model.first_name = "jess mathew";
        model.middle_initial = "p";
        model.last_name = "evangelista";
        model.suffix = "";
        model.birthday = DateTime.ParseExact("2005-03-30", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        model.house_number = "239 F.";
        model.street_name = "daclan private road";
        model.barangay = "punta princessa";
        model.city = "cebu city";
        model.province = "cebu";
        model.country = "philippines";
        dbCtx.first_table.Add(model);
        dbCtx.SaveChanges();
        List<BasicInformation> models = dbCtx.first_table.ToList();
        var adults = (from model in models
                      where model.age >= 18
                      select model).Take(1).ToList();
        BasicInformation actualModel = adults[0];
        BasicInformation expectedModel = new BasicInformation();
        expectedModel.first_name = "jess mathew";
        expectedModel.middle_initial = "p";
        expectedModel.last_name = "evangelista";
        expectedModel.birthday = DateTime.ParseExact("2005-03-30", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        expectedModel.suffix = "";
        expectedModel.house_number = "239 F.";
        expectedModel.street_name = "daclan private road";
        expectedModel.barangay = "punta princessa";
        expectedModel.city = "cebu city";
        expectedModel.province = "cebu";
        expectedModel.country = "philippines";
        Assert.AreEqual(expectedModel.first_name, actualModel.first_name);
        Assert.AreEqual(expectedModel.middle_initial, actualModel.middle_initial);
        Assert.AreEqual(expectedModel.last_name, actualModel.last_name);
        Assert.AreEqual(expectedModel.suffix, actualModel.suffix);
        Assert.AreEqual(expectedModel.full_name, actualModel.full_name);
        Assert.AreEqual(expectedModel.birthday, actualModel.birthday);
        Assert.AreEqual(expectedModel.age, actualModel.age);
        Assert.AreEqual(expectedModel.house_number, actualModel.house_number);
        Assert.AreEqual(expectedModel.street_name, actualModel.street_name);
        Assert.AreEqual(expectedModel.barangay, actualModel.barangay);
        Assert.AreEqual(expectedModel.city, actualModel.city);
        Assert.AreEqual(expectedModel.province, actualModel.province);
        Assert.AreEqual(expectedModel.country, actualModel.country);
    }

    [TestCleanup]
    public void Clean()
    {
        dbCtx.Database.EnsureDeleted();
    }
}