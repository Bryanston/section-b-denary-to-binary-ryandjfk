// Console template
using System;
class Program
{
    static void Main()
    {
        // Here is your empty program!
        Console.Clear();

        Console.Write("Enter input a denary number to convert: ");
        int userNum = Convert.ToInt32(Console.ReadLine());
        string newDigit = "";
        string remainder = "";
        while (userNum > 0)
        {
            newDigit = Convert.ToString(userNum % 2);
            remainder = newDigit + remainder;
            userNum = userNum / 2;


        }

        Console.Write(remainder);
    }
}
