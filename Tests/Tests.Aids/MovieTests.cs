using Abc.Soft.Movie.Models;

namespace Abc.Tests.Aids
{
    [TestClass] public sealed class MovieTests : BaseTests<Movie>{}
    [TestClass] public sealed class CountryTests : BaseTests<Country> { }
    [TestClass] public sealed class CurrencyTests : BaseTests<Currency> { }
    public abstract class BaseTests <TClass> where TClass : class, new()
    {
        private TClass obj;
        [TestInitialize] public void TestInitialize() => obj = new TClass();
        [TestMethod] public void CanCreateTest() => Assert.IsNotNull(obj);
    }
}
