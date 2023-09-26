namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 53;
            int y = 0;
            int z = -8;

            if(x==y && y==z)
            {
                Console.WriteLine("Ededler beraberdir");
            }
            else
            {
                if (x == y)
                {
                    if (x > z)
                    {
                        Console.WriteLine("Ededlerden en boyuyu x ve y-dir");
                    }
                    else
                    {
                        Console.WriteLine("Ededlerden en boyuyu z-dir");
                    }
                }
                else
                {
                    if(y==z)
                    {
                        if(y>x)
                        {
                            Console.WriteLine("Ededlerden en boyuyu y ve z-dir");
                        }
                        else
                        {
                            Console.WriteLine("Ededlerden en boyuyu x-dir");
                        }
                    }
                    else
                    {
                        if (x==z)
                        {
                            if (z>y)
                            {
                                Console.WriteLine("Ededlerden en boyuyu x ve z-dir");
                            }
                            else
                            {
                                Console.WriteLine("Ededlerden en boyuyu y-dir");
                            }
                        }
                        else
                        {
                            if(x>y)
                            {
                                if(x>z)
                                {
                                    Console.WriteLine("Ededlerden en boyuyu x-dir");
                                }
                                else
                                { 
                                    Console.WriteLine("Ededlerden en boyuyu z-dir");
                                }
                            }
                            else 
                            { 
                                if(y>z)
                                {
                                    Console.WriteLine("Ededlerden en boyuyu y-dir");
                                }
                                else 
                                { 
                                    Console.WriteLine("Ededlerden en boyuyu z-dir");
                                }
                            }
                        }
                    }
                }        
            }
        }
    }
}