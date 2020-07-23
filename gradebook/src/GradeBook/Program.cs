using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array de valores double
            var numbers = new[] {12.7, 10.3, 6.11, 4.1};

            var result_0 = 0.0;
            foreach(var number in numbers)
            {
                result_0 += number;
            }

            Console.WriteLine($"Soma dos valores do array: {result_0}");

            // Lista de valores double
            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);

            var result_1 = 0.0;
            var media = 0.0;
            foreach(var grade in grades)
            {
                result_1 += grade;
            }

            double v = result_1 / grades.Count;
            media = v;

            Console.WriteLine($"Soma dos valores da lista: {result_1}");
            Console.WriteLine($"Média dos valores da lista: {media:N1}");

        }
    }
}
