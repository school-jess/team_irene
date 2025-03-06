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
}