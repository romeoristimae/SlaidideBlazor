using System.ComponentModel;
using System.Reflection;
using System.Xml.Linq;

namespace Abc.Tests.Aids;

public abstract class TestAids<TClass> where TClass : class, new() {
    protected TClass obj;
    protected const BindingFlags publicDeclared = BindingFlags.Public
        | BindingFlags.DeclaredOnly
        | BindingFlags.Instance
        | BindingFlags.Static;
    protected static IEnumerable<string> getProperties()
        => global::Abc.Aids.GetType.PropertyNames<TClass>(publicDeclared);

    protected static IEnumerable<string> getMethods()
        => global::Abc.Aids.GetType.MethodNames<TClass>(publicDeclared, false);
    protected void isProperty<T>(string name) {
        var p = typeof(TClass).GetProperty(name);
        Assert.IsNotNull(p, noProperty(name));
        Assert.AreEqual(typeof(T), p.PropertyType, wrongType<T>(name, p));
    }

    private string wrongType<T>(string name, PropertyInfo p)
        => $"Property '{name}' in class '{typeof(TClass).Name}' is of type '{p.PropertyType.Name}', expected ' {typeof(T).Name}'.";

    private string noProperty(string name)
        => $"Property '{name}' not found in class '{typeof(TClass).Name}'.";
}
