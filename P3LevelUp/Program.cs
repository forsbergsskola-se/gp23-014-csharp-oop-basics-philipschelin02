Player player = new Player();
while (true)
{
    int expAdd = Convert.ToInt32(Console.ReadLine());
    player.GrantExperience(expAdd);
}