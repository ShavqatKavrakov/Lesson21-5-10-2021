using System;
using System.Collections.Generic;
namespace Lesson21_5_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation<decimal,decimal> math=Sum;
           Console.WriteLine("Какой оператция вы хотите выполнить(+,-,*,/)");
           switch(Console.ReadLine())
           {
               case "+": math=Sum;break;
               case "-": math=Minus;break;
               case "*": math=Multy;break;
               case "/": math=Div;break;
           }
           Console.WriteLine(" Введите двух чисел");
          decimal x=decimal.Parse(Console.ReadLine());
          decimal y=decimal.Parse(Console.ReadLine());
           Console.WriteLine(math(x,y));
        }
        public delegate T MathOperation<T,I>(T x,I y);
        public static T Sum<T,I>(T x,I y ){
           return (dynamic)x + (dynamic)y;
        }
        public static T Minus<T,I>(T x,I y ){
           return (dynamic)x - (dynamic)y;
        }
        public static T Multy<T,I>(T x,I y ){
           return (dynamic)x * (dynamic)y;
        }
        public static T Div<T,I>(T x,I y ){
           return Math.Round(((dynamic)x / (dynamic)y),3);
        }
        
      }
    }

