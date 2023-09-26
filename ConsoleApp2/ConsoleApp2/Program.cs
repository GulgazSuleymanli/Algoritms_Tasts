namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 384;
            int y = -18;
            int z = 0;

            if (x == y && y==z)
            {
                Console.WriteLine("Ededler beraberdir");
            }
            else
            {
                if (x>y)
                {
                    if(x>z)
                    {
                        Console.WriteLine("En boyuk eded x-dir");
                    }
                    else
                    {
                        Console.WriteLine("En boyuk eded z-dir");
                    }
                }
                else
                {
                    if(y>z)
                    {
                        Console.WriteLine("En boyuk eded y-dir");
                    }
                    else
                    {
                        Console.WriteLine("En boyuk eded z-dir");
                    }
                }
            }
        }
    }
}