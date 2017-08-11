using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseWorkOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();          
            int a = rand.Next(1, 100);
            int b = rand.Next(-100, 100);
            int c = rand.Next(-100, 100);
            int[] arr = { };
            Console.WriteLine("---Condidtions---");
            Console.WriteLine($"1. Input - a = {a}, b = {b}; Output = {Conditions.Task1(a,b)}");
            Console.WriteLine($"2. Input - x = {a}, y = {b}; Quarter = {Conditions.Task2(a, b)}");
            Console.WriteLine($"3. Input - a = {a}, b = {b}, c = {c}; Output = { Conditions.Task3(a, b, c)}");
            Console.WriteLine($"4. Input - a = {a}, b = {b}, c = {c}; Output = {Conditions.Task4(a, b, c)}");
            Console.WriteLine($"5. Input - a = {a}; Score = {Conditions.Task5(a)}");
            Console.WriteLine("---Cycles---");
            Console.WriteLine(Cycles.Task1_1());
           Console.WriteLine($"2. Input - a = {a}; {Cycles.Task2(a)}");
            Console.WriteLine($"3.1. Input - a = {a}; Binary Sqrt = {Cycles.Task3_1(a)}");
            Console.WriteLine($"3.2. Input - a = {a}; Simple Sqrt = {Cycles.Task3_2(a)}");
            Console.WriteLine($"4. Input - a = {a}, Factorial = {Cycles.Task4(a)}");
            Console.WriteLine($"5. Input - a = {a}; Digit's sum = {Cycles.Task5(a)}");
            Console.WriteLine($"6. Input - a = {a}; Output = {Cycles.Task6(a)}");
           

            //Console.WriteLine($"5. Sum elements with odd indexes = {Arrays.Task5(arr)}");
            Arrays.Task9_2(arr);
            Console.WriteLine($"6. Reverse = {string.Join(",",arr)}");
            Console.WriteLine($"7. Count of odd elements = {Arrays.Task7(arr)}");
            
            Console.WriteLine("---Functions---");
            int day = rand.Next(1, 7);
            long input = rand.Next(1, 999999999);
            Console.WriteLine($"1. Day of week = {Functions.Task1(day)}");
            Console.WriteLine($"2. {input} = {Functions.Task2(input)}");
            Console.WriteLine($"3. {Functions.Task2(input)} = {Functions.Task3(Functions.Task2(input))}");
            Console.WriteLine($"4. Length betwwen points ({a},{c})({b},{day}) = {Functions.Task4(a,c,b,day)}");
        }
    }
}
