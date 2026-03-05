namespace Abc.Tests.Aids;

public abstract class BaseTests <TClass> where TClass : class, new(){
     private TClass obj;
     [TestInitialize] public void TestInitialize() => obj = new TClass();
     [TestMethod] public void CanCreateTest() => Assert.IsNotNull(obj);
     [TestMethod] public void IsClassTestedTest() {
        var className = typeof(TClass).Name;
        var testClassName = GetType().Name;
        Assert.AreEqual(testClassName.Replace("Tests", ""), className);
    }
    [TestMethod]
    public void IsClassCorrectTest()
    {
        var testMethods = GetType().GetMethods();
        var classMembers = typeof(TClass).GetMembers();
        Assert.Inconclusive("Not all members are tested");
    }
}

