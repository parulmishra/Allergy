using System;
using System.Collections.Generic;
					
public class Program
{
	private int _score;
		
	private static Dictionary<int, string> dict = new Dictionary<int , string>();
		
	public static void Main()
	{
		
		dict[1] = "eggs";
		dict[2] = "peanuts";
		dict[4] = "shellfish";
		dict[8] = "strawberry";
		
		var result = FindRepresentation(9);
		foreach(var str in result)
		{
			Console.WriteLine(str);
		}
	}
	
	static List<string> FindRepresentation(int num)
	{
		List<string> result = new List<string>();
		while(num > 0)
		{
			int power = FindBiggestMultipleLessThan(num);
			result.Add(dict[power]);
			num = num - power;
		}
		return result;
	}
	
	static int FindBiggestMultipleLessThan(int num)
	{
		int power = 1;
		while(power <= num)
		{
			power = power * 2;
		}
		
		return power / 2;
	}
}
