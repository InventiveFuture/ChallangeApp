using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallangeApp
{
    public class Employee
    {
        public List<int> score = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Employee(string name) 
        { this.Name = name; 
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }

        }

        public void AddScore(int number)
        {
            this.score.Add(number);

        }

        public void DeleteScore(int number)
        {
            this.score.Add(number);

        }

        public void Multiplication(int number)
        {
            this.score.Add(number);


        }
    }
}

