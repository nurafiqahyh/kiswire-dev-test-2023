using System;
 
public class palindromechecker
{
    public static bool IsPalindrome(string text)
    {
        if (text.Length <= 1)
            return true;
        else
        {
            if ( text[0] != text[ text.Length - 1 ] )
                return false;
            else
                return IsPalindrome( text.Substring( 1, text.Length-2 ) );
        }   
    }   
    public static void Main()
    {
      Console.Write("\n\nCheck whether a word is Palindrome or not :\n");
	  string str1;
	  bool tf;
		
      Console.Write(" Input any word : ");
      str1 = Console.ReadLine();
      tf=IsPalindrome(str1);
      if (tf==true)
      {
      Console.WriteLine(" The words is Palindrome.\n");
      }
      else
      {
       Console.WriteLine(" The words is not a Palindrome.\n");
      }
    }
}