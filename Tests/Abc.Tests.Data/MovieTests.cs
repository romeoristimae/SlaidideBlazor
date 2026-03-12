using Abc.Data;
namespace Abc.Tests.Aids;

[TestClass] public sealed class MovieTests : BaseTests<Movie> {
    [TestMethod] public void IdTest() => isProperty<int>(nameof(Movie.Id));
    [TestMethod] public void TitleTest() => isProperty<string>(nameof(Movie.Title));
    [TestMethod] public void ReleaseDateTest() => isProperty<DateOnly>(nameof(Movie.ReleaseDate));
    [TestMethod] public void GenreTest() => isProperty<string>(nameof(Movie.Genre));
    [TestMethod] public void PriceTest() => isProperty<decimal>(nameof(Movie.Price));
}

