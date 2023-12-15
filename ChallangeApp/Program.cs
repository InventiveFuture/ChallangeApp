using ChallangeApp;

var employee = new Employee("Adam", "Nowak");

employee.AddGrade("Adam");
employee.AddGrade("300");
employee.AddGrade(10);
employee.AddGrade(40);
employee.AddGrade(0.333);

//var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithDoWhile();


Console.WriteLine($"{"Loop Foreach",15} | {"Loop For",15} | {"Loop Do While",15} | {"Loop While",15}|");
Console.WriteLine($"Number of Grades");
Console.WriteLine($"{statistics1.Counter,15} | {statistics2.Counter,15} | {statistics3.Counter,15} | {statistics4.Counter,15}|");
Console.WriteLine($"Min Value");
Console.WriteLine($"{statistics1.MinValue,15} | {statistics2.MinValue,15} | {statistics3.MinValue,15} | {statistics4.MinValue,15}|");
Console.WriteLine($"Max Value");
Console.WriteLine($"{statistics1.MaxValue,14}  |  {statistics2.MaxValue,13}  |  {statistics3.MaxValue,13}  |  {statistics4.MaxValue,14}|");
Console.WriteLine($"Average");
Console.WriteLine($"{statistics1.Average,14}  |  {statistics2.Average,13}  |  {statistics3.Average,13}  |  {statistics4.Average,14}|");





//Console.WriteLine($"Average: {statistics.Average:N2}");
//Console.WriteLine($"Min: {statistics.MinValue}");
//Console.WriteLine($"Max: {statistics.MaxValue}");








