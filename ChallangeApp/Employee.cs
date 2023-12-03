namespace ChallangeApp
{
    public class Employee
    {
        private List<float> grades= new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average= 0;
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
