using System;
using System.Diagnostics;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var tester = new StringsTester(10_000_000);
            
            Mesure(tester.ToStringWithoutBoxing);
            Mesure(tester.ToStringWithBoxing);

            Mesure(tester.ToStringArrayWithoutBoxing);
            Mesure(tester.ToStringArrayWithBoxing);

            Console.ReadKey();
        }

        static void Mesure(Func<string> getResult)
        {
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine($"Executing {getResult.Method.Name}...");
            Console.WriteLine($"Result: {getResult()}");
            sw.Stop();
            Console.WriteLine($"Execution time: {sw.Elapsed}");
            Console.WriteLine();
        }
    }
}
