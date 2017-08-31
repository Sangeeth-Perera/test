using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorModify
{
    class Program
    {
        public enum Operations
        {
            ADD, SUBSTRACT, DIVIDE, MULTIPLY, INVALID
        };
        static void Main(string[] args)
        {


            string input = Console.ReadLine();
            string[] fields = input.Split(' ');

            int length = fields.Length;  //geting length of argument
            int[] num = new int[length]; // creating a array


            for (int i = 1; i < length; i++)
            {
                int.TryParse(fields[i], out num[i]);
            }
           

            //operator search
            switch (fields[0])
            {
                case "+":
                    
                    add(num);
                    break;
    
                case "*":
                    multiply(num);
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;
            }

            Console.ReadKey();


        }

        //method to perform add calculation
        public static void add(int []num)
        {
            int length=num.Length;
            int answer=0;
            for (int i = 1; i < length; i++)
            {
                answer += num[i];
            }
            Console.WriteLine("Answer is "+ answer);

        }
        //method to perform multiply calculation
        public static void multiply(int[] num)
        {
            int length = num.Length;
            int answer = 1;
            for (int i = 1; i < length; i++)
            {
                answer *= num[i];
            }
            Console.WriteLine("Answer is " +answer);

        }
    }
}
