using ChallangeApp;

var user1 = new User("Andrzej", "Kaczmarek", 40);
var user2 = new User("Paweł", "Jagielski", 25);
var user3 = new User("Agnieszka", "Kowalska", 31);
var user4 = new User("Damian", "Nowak", 28);

user1.AddScore(10);
user1.AddScore(30);
user1.AddScore(40);

user2.AddScore(50);
user2.AddScore(5);
user2.AddScore(10);

user3.AddScore(30);
user3.AddScore(15);

user4.AddScore(30);

List<User> employees = new List<User>()

{
    user1, user2, user3, user4
};

int maxResult = -1;
User userWithMaxResult = null;

foreach (var user in employees)
{
    if (user.Result > maxResult)
    {
        userWithMaxResult = user;
        maxResult = user.Result;
    }
}

Console.WriteLine(userWithMaxResult.Name + "" + userWithMaxResult.Surname + "" + userWithMaxResult.Age + ",wynik:" + userWithMaxResult.Result);






