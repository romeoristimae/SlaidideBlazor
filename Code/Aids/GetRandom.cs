using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Aids
{
    public static class GetRandom{
        private static Random r = new Random();
        public static int Int32(int min = int.MinValue, int max = int.MaxValue){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return r.Next(min, max);
        }
        public static long Int64(long min = long.MinValue, long max = long.MaxValue){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return r.NextInt64(min, max);
        }
        public static double Double(double min = double.MinValue, double max = double.MaxValue){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return min + r.NextDouble() * (max - min);
        }

        public static sbyte Int8(sbyte min = sbyte.MinValue, sbyte max = sbyte.MaxValue){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return (sbyte)r.Next(min, max);
        }

        public static short Int16(short min = short.MinValue, short max = short.MaxValue){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return (short)r.Next(min, max);
        }

        public static byte UInt8(byte min = byte.MinValue, byte max = byte.MaxValue){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return (byte)r.Next(min, max);
        }

        public static ushort UInt16(ushort min = ushort.MinValue, ushort max = ushort.MaxValue){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return (ushort)r.Next(min, max);
        }

        public static uint UInt32(uint min = uint.MinValue, uint max = uint.MaxValue){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return (uint)r.NextInt64(min, max);
        }

        public static ulong UInt64(ulong min = ulong.MinValue, ulong max = ulong.MaxValue){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            var range = max - min;
            var buffer = new byte[8];
            r.NextBytes(buffer);
            ulong value = BitConverter.ToUInt64(buffer, 0);
            return min + (value % (range + 1UL));
        }

        public static float Float(float min = float.MinValue, float max = float.MaxValue){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return min + (float)r.NextDouble() * (max - min);
        }

        public static decimal Decimal(decimal min = decimal.MinValue, decimal max = decimal.MaxValue){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            var fraction = (decimal)r.NextDouble();
            return min + fraction * (max - min);
        }

        public static char Char(char min = char.MinValue, char max = char.MaxValue){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return (char)r.Next(min, max);
        }

        public static bool Bool(){
            return r.Next(0, 2) == 1;
        }

        public static string String(int minLength = 0, int maxLength = 32){
            if (minLength == maxLength) minLength = maxLength = Math.Max(0, minLength);
            if (minLength > maxLength) (minLength, maxLength) = (maxLength, minLength);
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var len = r.Next(minLength, maxLength + 1);
            var sb = new StringBuilder(len);
            for (int i = 0; i < len; i++) sb.Append(chars[r.Next(0, chars.Length)]);
            return sb.ToString();
        }

        public static DateTime DateTime(DateTime min, DateTime max){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            var ticks = r.NextInt64(min.Ticks, max.Ticks);
            return new DateTime(ticks);
        }

        public static TimeSpan TimeSpan(TimeSpan min, TimeSpan max){
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            var ticks = r.NextInt64(min.Ticks, max.Ticks);
            return new TimeSpan(ticks);
        }

        public static Guid Guid() => System.Guid.NewGuid();
    }
}
