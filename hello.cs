using System;
namespace HelloWorld
{
    class Hello 
    {
        static void Main() 
        {
		Console.WriteLine(subtract(2, 2));
		Console.WriteLine(multiply(3, 2));
            Console.WriteLine("Goodbye World!");
        }
	
	public static int subtract(int a, int b)
	{
		return a - b;
	}

	public static int multiply(int a, int b)
	{
		return a * b;
	}
    }
}
