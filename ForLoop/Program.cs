using System;

namespace ForLoop{
    class Operatos{
        static void Main(String []args){
        
            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            int sayac = int.Parse(Console.ReadLine());
            for(int i = 1;i<=sayac;i++){
                if(i%2 ==1){
                    Console.WriteLine(i);
                }
            }

            int tekToplam = 0;
            int cıftToplam = 0;
            for (int i = 1 ; i<=1000;i++){
                if(i%2 ==1)
                tekToplam +=i;
                else
                cıftToplam +=i;
            }

            Console.WriteLine("Tek Toplam :" + tekToplam);
            Console.WriteLine("Cıft Toplam :" + cıftToplam);

            for (int i = 1; i< 10; i++){
                if(i==4)
                break;
                Console.WriteLine(i);
            }
        }
    }
    
}