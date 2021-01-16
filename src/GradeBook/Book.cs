using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name; // this is implicit variable for this object 
        }


        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        internal void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

            foreach (var item in grades)
            {
               highGrade = Math.Max(item, highGrade); // Math statics for math 
                
               lowestGrade = Math.Min(item, lowestGrade);

               result += item;
            }

            // averageGrade = result / grades.Count;
            result /= grades.Count; // same as result = result / grades.count
            
            Console.WriteLine($"The average grade is {result:N1}"); // number with 3 digits after decimal place
            Console.WriteLine($"The lowest grade is {lowestGrade:N1}"); // number with 3 digits after decimal place
            Console.WriteLine($"The highest grade is {highGrade:N1}"); // number with 3 digits after decimal place
        }

        private List<double> grades; // field for storage in class
        private string name;
    }
}