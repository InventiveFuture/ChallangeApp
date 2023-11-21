using ChallangeApp;

Employee user1 = new Employee("Andrzej","Kaczmarek", 40);
Employee user2 = new Employee("Paweł","Jagielski", 25);
Employee user3 = new Employee("Agnieszka", "Kowalska", 31);
Employee user4 = new Employee("Damian", "Nowak", 28);

user1.AddScore(10);
user1.AddScore(30);
user1.AddScore(40);

user2.AddScore(50);
user2.AddScore(5);
user2.AddScore(10);

user3.AddScore(30);
user3.AddScore(15);

user4.AddScore(30);

List<Employee> employees = new List<Employee>()

{
    user1, user2, user3, user4 
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult= employee.Result;
    }
}

Console.WriteLine(employeeWithMaxResult.name + "" + employeeWithMaxResult.surname + "" + employeeWithMaxResult.age + ",wynik:" + employeeWithMaxResult.Result);






