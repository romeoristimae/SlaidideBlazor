using Abc.Aids;
using System.Linq;
using System.Reflection;

namespace Abc.Tests.Aids;

public abstract class BaseTests <TClass> where TClass : class, new(){
     private TClass obj;
    private const BindingFlags publicDeclared = BindingFlags.Public
        | BindingFlags.DeclaredOnly
        | BindingFlags.Instance
        | BindingFlags.Static;
     [TestInitialize] public void TestInitialize() => obj = new TClass();
     [TestMethod] public void CanCreateTest() => Assert.IsNotNull(obj);
     [TestMethod] public void IsClassCorrectTest(){
        var className = typeof(TClass).Name;
        var testClassName = GetType().Name;
        Assert.AreEqual(testClassName.Replace("Tests", ""), className);
    }
    [TestMethod] public void IsClassTestedTest(){
        var testMethods = GetType().GetMethods().Select(x => x.Name);
        var membersToTest = getProperties().Concat(getMethods());
        foreach (var m in membersToTest) {
           if ( !testMethods.Contains(m + "Test"))
                Assert.Inconclusive($"{m} is not tested");
        }
    }
    private static IEnumerable<string> getProperties()
        => global::Abc.Aids.GetType.PropertyNames<TClass>(publicDeclared);

    private static IEnumerable<string> getMethods()
        => global::Abc.Aids.GetType.MethodNames<TClass>(publicDeclared, false);
}

