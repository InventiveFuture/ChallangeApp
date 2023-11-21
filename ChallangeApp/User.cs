using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallangeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
           
        }
        public string name { get; private set; }
        public string surname { get; private set; }
        public string age { get; private set; }
       


        

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
    }
}
   
