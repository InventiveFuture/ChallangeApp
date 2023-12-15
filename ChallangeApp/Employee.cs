using System;
using System.Security.Cryptography.X509Certificates;

namespace ChallangeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }

        }
        public void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);

        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.MaxValue = float.MinValue;
            statistics.MinValue = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count)
            {
                statistics.MaxValue = Math.Max(statistics.MaxValue, this.grades[index]);
                statistics.MinValue = Math.Min(statistics.MinValue, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            }

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.MaxValue = float.MinValue;
            statistics.MinValue = float.MaxValue;

            var index = 0;

            do
            {
                statistics.MaxValue = Math.Max(statistics.MinValue, this.grades[index]);
                statistics.MinValue = Math.Min(statistics.MinValue, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.MaxValue = float.MinValue;
            statistics.MinValue = float.MaxValue;
            statistics.Counter = this.grades.Count;
            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.MaxValue = Math.Max(statistics.MaxValue, this.grades[i]);
                statistics.MinValue = Math.Min(statistics.MinValue, this.grades[i]);
                statistics.Average += this.grades[i];
            }

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.MaxValue = float.MinValue;
            statistics.MinValue = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.MaxValue = Math.Max(statistics.MaxValue, grade);
                statistics.MinValue = Math.Min(statistics.MinValue, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
