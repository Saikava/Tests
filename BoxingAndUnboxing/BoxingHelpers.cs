using System;

namespace BoxingAndUnboxing
{
    public class ToStringHelpers
    {
        public static Func<int, string> WithBoxing = x => ((Object)x).ToString();

        public static Func<int, string> WithoutBoxing = x => x.ToString();

        public static Func<int, string> GetToStringFunction(bool useBoxing)
            => useBoxing ? WithBoxing : WithoutBoxing;
    }
}
