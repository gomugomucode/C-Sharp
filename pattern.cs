
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for (int i = 5; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
