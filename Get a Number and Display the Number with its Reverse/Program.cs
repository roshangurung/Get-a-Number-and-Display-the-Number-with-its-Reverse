using System;

namespace Get_a_Number_and_Display_the_Number_with_its_Reverse
{
    class Program//////In this C# program, we are reading the number using ‘num’ variable. Multiply the value of ‘reverse’ variable by 10 and add this value of reverse variable with the modulus of the value of ‘reverse’ variable by 10. Compute the division of the value of ‘num’ variable by 10. Print the number with its reverse orde////
    {
        static void Main(string[] args)
        {
            int num, reverse = 0;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);
            Console.ReadLine();
            ///Output
            ///Enter a number:123
            ///Reverse of Entered Number is :321
        }
    }
}
