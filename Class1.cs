using System;

public class Person
{
	public static void GetName(int a)
	{
		Console.WriteLine("上面這段");
		Console.WriteLine(a);
	}
	public static void GetName(float a)
	{
		Console.WriteLine("下面這段");
		Console.WriteLine(float a);
		return 10;
	}
}
