public class Plant
{
    public bool isGrown = false;

    public void PrintStatus()
    {
        if (isGrown == true)
        {
            Console.WriteLine("Plant is a tree.");
        }
        else
        {
            Console.WriteLine("Plant is a seed.");
        }
    }

    public void Grow()
    {
        if (isGrown == false)
        {
            Console.WriteLine("Plant is growing.");
            isGrown = true;
        }
        else
        {
            Console.WriteLine("Plant has already grown.");
        }
    }
}