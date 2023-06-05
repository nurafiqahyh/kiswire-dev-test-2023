using System;

public class Question1 {
	
	// Returns sum of all digits in number from 1 to n
	static int sumOfDigitsFrom1ToN(int n)
	{
		// initialize result
		int result = 0;
	
		// One by one compute sum of digits
		// in every number from 1 to n
		for (int k = 1; k <= n; k++)
			result += sumOfNumbers(k);
	
		return result;
	}
	
	// To compute sum of digits in a given number k
	static int sumOfNumbers(int k)
	{
		int sum = 0;
		
		while (k != 0)
		{
			sum += k % 10;
			k = k / 10;
		}
		
		return sum;
	}
	
	public static void Main(string [] args)
	{
	    Console.WriteLine ("Please enter the chosen number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Sum of digits"
			+ " in numbers from 1 to " + n + " is="
				+ sumOfDigitsFrom1ToN(n) + ". Thank you!");

		Console.ReadKey();
	}
}

