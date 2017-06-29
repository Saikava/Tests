using System;
using System.Diagnostics;

namespace BoxingAndUnboxing
{
    class Program
    {
        private const int N = 10_000_000;

        static void Main(string[] args)
        {
            var stringTester = new StringsTester(N);

            RunTestCase(stringTester.TestString);
            RunTestCase(stringTester.TestStringArray);
            RunTestCase(stringTester.TestStringStream);
            
            var arrayTester = new ArrayTester(N);
            
            RunTestCase(arrayTester.TestStringArrayWtihConcat);
            RunTestCase(arrayTester.TestStringArrayWtihoutConcat);
            
            Console.ReadKey();
        }

        static void RunTestCase(Func<bool, string> testCase)
        {
            Console.WriteLine($"Testing {testCase.Method.Name} without boxing...");
            Test(() => testCase(false));
            Console.WriteLine($"Executing {testCase.Method.Name} with boxing...");
            Test(() => testCase(true));
        }

        static void Test(Func<string> getResult)
        {
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine($"Result: {getResult()}");
            sw.Stop();
            Console.WriteLine($"Execution time: {sw.Elapsed}");
            Console.WriteLine();
        }
    }
}
