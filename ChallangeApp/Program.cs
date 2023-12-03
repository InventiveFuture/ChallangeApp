using ChallangeApp;

var employee = new Employee("Adam", "Nowak");

employee.AddGrade(2); 
employee.AddGrade(2);
employee.AddGrade(6);
employee.AddGrade(-1);
employee.AddGrade(3*2);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.MinValue}");
Console.WriteLine($"Max: {statistics.MaxValue}");








