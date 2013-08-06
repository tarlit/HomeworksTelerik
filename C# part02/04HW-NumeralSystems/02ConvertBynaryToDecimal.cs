using System;
using System.Text;
//02.Write a program to convert binary numbers to their decimal representation.

class ConvertBynaryToDecimal
{
    public static int BinaryToDecimal(string binaryNumber)
    {
        int decNumber = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            // we start with the least significant digit
            if (binaryNumber[binaryNumber.Length - i - 1] == '0')
            {
                continue;
            }
            decNumber += (int)Math.Pow(2, i);            
        }
        return decNumber;
    }
    
    static void Main()
    {
        Console.WriteLine("Enter a binary number : ");
        string binaryNumber = Console.ReadLine();

        int number = BinaryToDecimal(binaryNumber);
        Console.WriteLine("{0}(2) -> {1}(10)", binaryNumber, number);
    }
}
