using System;

namespace BoxingAndUnboxing
{
    public class StringsTester
    {
        private readonly int _n;
        private const string DefaultResult = "DONE";

        public StringsTester(int n)
        {
            _n = n;
        }

        public string ToStringWithBoxing() => TestString(ToStringWithBoxing);

        public string ToStringWithoutBoxing() => TestString(ToString);

        public string ToStringArrayWithoutBoxing() => TestStringArray(ToString);

        public string ToStringArrayWithBoxing() => TestStringArray(ToStringWithBoxing);

        private string TestStringArray(Func<int, string> toStringFunc)
        {
            var strings = new string[_n];
            for (var i = 0; i < _n; i++)
            {
                strings[i] = toStringFunc(i);
            }
            
            return DefaultResult;
        }

        private string TestString(Func<int, string> toStringFunc)
        {
            var str = string.Empty; 
            for (var i = 0; i < _n; i++)
            {
                str = (str + toStringFunc(i)).GetHashCode().ToString();
                Console.WriteLine(str);
            }
            
            return str;
        }

        private string ToStringWithBoxing(int x) => ((Object) x).ToString();
        
        private string ToString(int x) => x.ToString();
    }
}
