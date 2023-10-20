var age = 33;
string name = "Ewa";
var gender = "Kobieta";


if (age == 33 && name == "Ewa") 
{
    Console.WriteLine("Ewa, lat 33");

}
else if (age < 30 && gender == "Kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age < 18 && gender != "Kobieta")
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}

