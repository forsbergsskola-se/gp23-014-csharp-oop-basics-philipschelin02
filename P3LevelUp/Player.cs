public class Player
{
    public int level = 0;
    public int experience = 0;
    public void GrantExperience(int expAdd)
    {
        Console.WriteLine($"{this.level} Level and {this.experience} experience. Thank u.");
        experience = expAdd + experience;
        while (experience >= 100)
        {
            level++;
            experience = experience - 100;
        }
    }
}