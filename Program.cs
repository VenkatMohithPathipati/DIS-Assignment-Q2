using System;

namespace AssignQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length of your first array?");
            int len1 = int.Parse(Console.ReadLine());//parsing to integer
            var bulls_string1 = new string[len1] ;// creating array with the input
            for (int i = 0; i < len1; i++)
            {
                bulls_string1[i] = Console.ReadLine();// adding strings to array
            }
            Console.WriteLine("Length of your second array?");
            int len2 = int.Parse(Console.ReadLine());
            var bulls_string2 = new string[len2] ;
            for (int i = 0; i < len2; i++)
            {
                bulls_string2[i] = Console.ReadLine();//adding strings to second array
            }
            Console.WriteLine(ArrayStringsAreEqual(bulls_string1,bulls_string2,len1,len2));
        }
        static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2, int len1, int len2)
        {
            
            string str1 = "";
            string str2 = "";
            for (int i = 0; i < len1; i++)
            {
                str1 = str1 + bulls_string1[i]; // combining all the strings in the array
            }
            for (int i = 0; i < len2; i++)
            {
                str2 = str2 + bulls_string2[i];
            }
            str1 = str1.ToLower();// making to lower cases
            str2 = str2.ToLower();
            return str1 == str2;// returs True or False
        }
    }
}
