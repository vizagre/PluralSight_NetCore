using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book{

        private List<double> grades;
        public string Name;

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Avarage = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            
            foreach(var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Avarage += grade;
            }

            result.Avarage /= grades.Count;

            return result;

        }
    }
}