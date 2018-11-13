using System;

class Palindrome
{
  static void Main()
  {
    Console.WriteLine("Please enter a word:");
    string myString = Console.ReadLine();
    string myReverseString = "";

    for (int index = myString.Length; index > 0; index--)
    {
      myReverseString = myReverseString + myString[index - 1];
    }

    int count = 0;
    for(int index = 0; index < myString.Length; index++)
    {
      if(myString[index] == myReverseString[index])
      {
        count++;
      }
    }

    if(count == myString.Length)
    {
      Console.WriteLine(myString + " " + myReverseString + " is a Palindrome");
    }
    else
    {
      Console.WriteLine(myString + " " + myReverseString + " is not a Palindrome");
    }
  }
}
