using Abc.Aids;

namespace Abc.Tests.Aids;

[TestClass]
public sealed class GetRandomTests
{
    private const int IntMin = int.MinValue;
    private const int IntMax = int.MaxValue;

    private const long LongMin = long.MinValue;
    private const long LongMax = long.MaxValue;

    private static readonly double DoubleMin = -1e150;
    private static readonly double DoubleMax = 1e150;

    private const sbyte SByteMin = sbyte.MinValue;
    private const sbyte SByteMax = sbyte.MaxValue;

    private const short ShortMin = short.MinValue;
    private const short ShortMax = short.MaxValue;

    private const byte ByteMin = byte.MinValue;
    private const byte ByteMax = byte.MaxValue;

    private const ushort UShortMin = ushort.MinValue;
    private const ushort UShortMax = ushort.MaxValue;

    private const uint UIntMin = uint.MinValue;
    private const uint UIntMax = uint.MaxValue;

    private static readonly ulong ULongMin = ulong.MinValue;
    private static readonly ulong ULongMax = ulong.MaxValue - 1UL;

    private const float FloatMin = -1e30f;
    private const float FloatMax = 1e30f;

    private static readonly decimal DecimalMin = -1000000M;
    private static readonly decimal DecimalMax = 1000000M;

    private const char CharMin = char.MinValue;
    private const char CharMax = char.MaxValue;

    private const int StrMinLen = 0;
    private const int StrMaxLen = 32;

    private static readonly DateTime DateMin = DateTime.MinValue;
    private static readonly DateTime DateMax = DateTime.MaxValue;

    private static readonly TimeSpan TimeMin = TimeSpan.MinValue;
    private static readonly TimeSpan TimeMax = TimeSpan.MaxValue;

    [TestMethod]
    public void Int32Test()
        => Assert.AreNotEqual(GetRandom.Int32(IntMin, IntMax), GetRandom.Int32(IntMin, IntMax));

    [TestMethod]
    public void Int64Test()
        => Assert.AreNotEqual(GetRandom.Int64(LongMin, LongMax), GetRandom.Int64(LongMin, LongMax));

    [TestMethod]
    public void DoubleTest()
        => Assert.AreNotEqual(GetRandom.Double(DoubleMin, DoubleMax), GetRandom.Double(DoubleMin, DoubleMax));

    [TestMethod]
    public void Int8Test()
        => Assert.AreNotEqual(GetRandom.Int8(SByteMin, SByteMax), GetRandom.Int8(SByteMin, SByteMax));

    [TestMethod]
    public void Int16Test()
        => Assert.AreNotEqual(GetRandom.Int16(ShortMin, ShortMax), GetRandom.Int16(ShortMin, ShortMax));

    [TestMethod]
    public void UInt8Test()
        => Assert.AreNotEqual(GetRandom.UInt8(ByteMin, ByteMax), GetRandom.UInt8(ByteMin, ByteMax));

    [TestMethod]
    public void UInt16Test()
        => Assert.AreNotEqual(GetRandom.UInt16(UShortMin, UShortMax), GetRandom.UInt16(UShortMin, UShortMax));

    [TestMethod]
    public void UInt32Test()
        => Assert.AreNotEqual(GetRandom.UInt32(UIntMin, UIntMax), GetRandom.UInt32(UIntMin, UIntMax));

    [TestMethod]
    public void UInt64Test()
        => Assert.AreNotEqual(GetRandom.UInt64(ULongMin, ULongMax), GetRandom.UInt64(ULongMin, ULongMax));

    [TestMethod]
    public void FloatTest()
        => Assert.AreNotEqual(GetRandom.Float(FloatMin, FloatMax), GetRandom.Float(FloatMin, FloatMax));

    [TestMethod]
    public void DecimalTest()
        => Assert.AreNotEqual(GetRandom.Decimal(DecimalMin, DecimalMax), GetRandom.Decimal(DecimalMin, DecimalMax));

    [TestMethod]
    public void CharTest()
        => Assert.AreNotEqual(GetRandom.Char(CharMin, CharMax), GetRandom.Char(CharMin, CharMax));

    [TestMethod]
    public void BoolTest()
        => Assert.IsInstanceOfType(GetRandom.Bool(), typeof(bool));

    [TestMethod]
    public void StringTest()
        => Assert.AreNotEqual(GetRandom.String(StrMinLen, StrMaxLen), GetRandom.String(StrMinLen, StrMaxLen));

    [TestMethod]
    public void DateTimeTest()
        => Assert.AreNotEqual(GetRandom.DateTime(DateMin, DateMax), GetRandom.DateTime(DateMin, DateMax));

    [TestMethod]
    public void TimeSpanTest()
        => Assert.AreNotEqual(GetRandom.TimeSpan(TimeMin, TimeMax), GetRandom.TimeSpan(TimeMin, TimeMax));

    [TestMethod]
    public void GuidTest()
        => Assert.AreNotEqual(GetRandom.Guid(), GetRandom.Guid());
}
