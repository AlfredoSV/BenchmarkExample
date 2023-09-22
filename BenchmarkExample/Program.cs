using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkExample
{
    public class Program
    {
        static void Main(string[] args)
        {

            Summary summary = BenchmarkRunner.Run<ExampleBenchmark>();

            Console.WriteLine(summary);

            //Console.WriteLine(ExampleBenchmark.ReverserStrOne("Alfredo"));
            //Console.WriteLine(ExampleBenchmark.ReverserStrTwo("Alfredo"));

            Console.ReadLine();
        }

        
    }

    
    public class ExampleBenchmark
    {

        [Benchmark]
        [Arguments("AlfredoAlfredoAlfredoAlfredo")]
        public  string ReverserStrOne(string str)
        {
            char[] cadChar = str.ToArray();
            Array.Reverse(cadChar);

            return new string(cadChar);

        }


        [Benchmark]
        [Arguments("AlfredoAlfredoAlfredoAlfredo")]
        public string ReverserStrTwo(string str)
        {
            string result = string.Empty;

            for (int i = str.Length-1; i >= 0; i--)
            {
                result += str[i];
            }

            return result;
        }
    }
}
