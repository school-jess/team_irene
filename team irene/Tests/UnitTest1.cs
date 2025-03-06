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
    public void TestNoHouseNumber()
    {
        irene model = new irene();
        Assert.ThrowsException<Exception>(() => model.houseNumber = "");
    }

    [TestMethod]
    public void TestNoBirthday()
    {
        irene model = new irene();
        Assert.ThrowsException<Exception>(() => model.birthDay = "");
    }
}