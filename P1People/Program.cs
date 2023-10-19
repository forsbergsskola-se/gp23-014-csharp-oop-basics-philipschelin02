Person[] personarray = new Person[3];

for (var i = 0; i < personarray.Length; i++)
{
    personarray[i] = new Person();
}

for (var i = 0; i < personarray.Length; i++)
{
    Console.WriteLine(personarray[i]);
}