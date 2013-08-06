using System;
using System.Text;
//01.Write a program to convert decimal numbers to their binary representation.

class ConvertDecimalToBynary
{
    public static StringBuilder IntDecimalToBinary(int number)
    {
        StringBuilder sb = new StringBuilder();

        if (number > 0)
        {
            sb = sb.Append(0);
            int pos = 30;
            while (pos != -1)
            {
                if ((number & (1 << pos)) != 0)
                {
                    sb = sb.Append(1);
                }
                else
                {
                    sb = sb.Append(0);
                }
                pos--;
            }
        }
        else if (number < 0)
        {
            sb = sb.Append(1);
            number = int.MaxValue - Math.Abs(number + 1);
            int pos = 30;
            while (pos != -1)
            {
                if ((number & (1 << pos)) != 0)
                {
                    sb = sb.Append(1);
                }
                else
                {
                    sb = sb.Append(0);
                }
                pos--;
            }
        }
        else
        {
            sb = sb.Append(0);
        }
        return sb;
    }

    static void Main()
    {
        Console.Write("Enter an integer : ");
        int number = int.Parse(Console.ReadLine());

        StringBuilder result = IntDecimalToBinary(number);
        Console.WriteLine("{0}(10)  ->  {1}(2)", number, result);
    }
}
