using System.Collections.Generic;
using System.IO;

namespace BoxingAndUnboxing
{
    public class StringsTester
    {
        private readonly int _n;
        
        public StringsTester(int n)
        {
            _n = n;
            ConsoleHelper.WriteHeader("StringTester");
        }

        public string TestString(bool useBoxing)
        {
            var toStringFunc = ToStringHelpers.GetToStringFunction(useBoxing);
            
            var str = string.Empty; 
            for (var i = 0; i < _n; i++)
            {
                str = " " + toStringFunc(i);
            }
            
            return str;
        }

        public string TestStringArray(bool useBoxing)
        {
            var toStringFunc = ToStringHelpers.GetToStringFunction(useBoxing);

            var strings = new List<string>();
            for (var i = 0; i < _n; i++)
            {
                strings.Add(" " + toStringFunc(i));
            }

            return strings.Count.ToString();
        }

        public string TestStringStream(bool useBoxing)
        {
            var toStringFunc = ToStringHelpers.GetToStringFunction(useBoxing);

            using (var ms = new MemoryStream())
            using (var stream = new StreamWriter(ms))
            {
                for (var i = 0; i < _n; i++)
                {
                    stream.Write(" " + toStringFunc(i));
                }

                return ms.Length.ToString();
            }
        }
    }
}
