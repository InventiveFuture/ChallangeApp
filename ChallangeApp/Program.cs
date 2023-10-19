var Age = 33;
string Name = "Ewa";
var gender = "kobieta";


if (Age < 40 && Name == "Ewa") 
{
    Console.WriteLine("Ewa, lat 33");

}
else if (Age < 30 && gender == "kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (Age < 18 && gender != "kobieta")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

