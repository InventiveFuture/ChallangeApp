var Age = 33;
string Name = "Ewa";
var Gender = "Kobieta";


if (Age == 33 && Name == "Ewa") 
{
    Console.WriteLine("Ewa, lat 33");

}
else if (Age < 30 && Gender == "Kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (Age < 18 && Gender != "Kobieta")
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}

