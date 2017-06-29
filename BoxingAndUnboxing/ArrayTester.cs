using System.Collections.Generic;

namespace BoxingAndUnboxing
{
    public class ArrayTester
    {
        private readonly int _n;

        public ArrayTester(int n)
        {
            _n = n;
            ConsoleHelper.WriteHeader("ArrayTester");
        }

        public string TestStringArrayWtihConcat(bool useBoxing)
        {
            var toStringFunc = ToStringHelpers.GetToStringFunction(useBoxing);

            var strings = new List<string>();
            for (var i = 0; i < _n; i++)
            {
                strings.Add(" " + toStringFunc(i));
            }

            return strings.Count.ToString();
        }
        
        public string TestStringArrayWtihoutConcat(bool useBoxing)
        {
            var toStringFunc = ToStringHelpers.GetToStringFunction(useBoxing);

            var strings = new List<string>();
            for (var i = 0; i < _n; i++)
            {
                strings.Add(toStringFunc(i));
            }

            return strings.Count.ToString();
        }
    }
}
