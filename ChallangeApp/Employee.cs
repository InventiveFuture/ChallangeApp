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
            if(float.TryParse(grade, out float result))
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

        public void AddGrade (int grade) 
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }
        
        public void AddGrade (double grade) 
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        
        }
        public Statistics GetStatistics()
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

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
    }
}
