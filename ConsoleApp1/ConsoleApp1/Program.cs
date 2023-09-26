namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ortabal = 13.3;

            if (!(ortabal > 0.0 && ortabal < 100.1))
            {
                Console.WriteLine("Bele ortalama movcud deyil");
            }
            else
            {
                if (ortabal > 90.0 && ortabal < 101.0)
                {
                    Console.WriteLine("A");
                }
                else
                {
                    if (ortabal > 80.0 && ortabal < 91.0)
                    {
                        Console.WriteLine("B");
                    }
                    else
                    {
                        if (ortabal > 70.0 && ortabal < 81.0)
                        {
                            Console.WriteLine("C");
                        }
                        else
                        {
                            if (ortabal > 60.0 && ortabal < 71.0)
                            {
                                Console.WriteLine("D");
                            }
                            else
                            {
                                if (ortabal > 50.0 && ortabal < 61.0)
                                {
                                    Console.WriteLine("E");
                                }
                                else
                                {
                                    Console.WriteLine("Kesildiniz");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}