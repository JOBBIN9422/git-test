using System;
namespace HelloWorld
{
    class Hello 
    {
        static void Main() 
        {
		Console.WriteLine(add(2, 2));
            Console.WriteLine("Goodbye World!");
        }
	
	public static int add(int a, int b)
	{
		return a + b;
	}
    }
}
