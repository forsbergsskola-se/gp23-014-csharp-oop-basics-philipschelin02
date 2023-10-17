House house = new House();

void Sell(House anyname)
{
    anyname.owner = "Alex";
}

house.PrintOwner();

Sell(house);

house.PrintOwner();