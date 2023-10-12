Person[] person = new Person[3];

for (var i = 0; i < person.Length; i++)
{
    person[i] = new Person();
    person[i].names = Console.ReadLine();
}

for (var i = 0; i < person.Length; i++)
{
    person[i].Greeting();
}