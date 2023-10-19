Player p1 = new Player(); //ID 1
ChangePlayer(p1); //ID 1
Console.WriteLine(p1.experience);

void ChangePlayer(Player player)
{
    player = new Player();
    player.experience = 200;
}