// See https://aka.ms/new-console-template for more information
using System;

namespace SwitchCase{
    class Program{
         static void Main(string[]args){
            int month = DateTime.Now.Month;

            switch(month){
                case 1:
                Console.WriteLine("Ocak Ayındasınız");
                break;
                case 2:
                Console.WriteLine("Şubat Ayındasınız");
                break;
                case 3:
                Console.WriteLine("Mart Ayındasınız");
                break;
                case 4:
                Console.WriteLine("Nisan Ayındasınız");
                break;
                default:
                Console.WriteLine("Yanlış Veri girdiniz");
                break;
            }
        }
    }

}