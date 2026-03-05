using Abc.Soft.Movie.Models;

namespace Abc.Tests.Aids
{
    [TestClass] public sealed class MovieTests {
        private Movie movie;
        [TestInitialize] public void TestInitialize() => movie = new Movie();
        [TestMethod] public void CanCreateTest() => Assert.IsNotNull(movie);
    }
}
