using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programlama_Dilleri_Ödev_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1-Klavyeden girilen sayı dost mu? A'nın pozitif bölen toplamı B ve B'ninkiler A ise bunlar dost sayılardır.
            //_________________________________________________________________________________________________________
            //int a, b,toplam1=0,toplam2=0;
            //Console.Write("Lütfen a değerini giriniz: ");
            //a= int.Parse(Console.ReadLine());
            //Console.Write("Lütfen b değerini giriniz: ");
            //b= int.Parse(Console.ReadLine());
            //for (int i = 1; i < a; i++)
            //{
            //    if (a % i == 0) toplam1 += i;
            //}
            //for (int i = 1; i < b; i++)
            //{
            //    if (b % i == 0) toplam2 += i;
            //}
            //if (toplam1 == b && toplam2 == a) Console.WriteLine("Bu sayılar dost sayılardır.");
            //else
            //{
            //    Console.WriteLine("bu sayılar dost sayılar değildir.");
            //}
            //Console.ReadLine();
            //_________________________________________________________________________________________________________






            //2-Girilen iki sayı arasındaki asal sayılar
            //_________________________________________________________________________________________________________
            //int a, b, asal ;
            //Console.Write("Lütfen a değerini giriniz: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen b değerini giriniz: ");
            //b = int.Parse(Console.ReadLine());
            //if (a > b)
            //{
            //    for (int sayi = b; sayi <= a; sayi++)
            //    {
            //        int kontrol = 0;

            //        for (int i = 2; i < sayi; i++)
            //        {
            //            if (sayi % i == 0) //www.yazilimkodlama.com
            //            {
            //                kontrol = 1;

            //            }
            //        }
            //        if (kontrol == 1)
            //        {
            //            Console.WriteLine("{0} asal değidir", sayi);
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0} asaldır.", sayi);

            //        }

            //    }
            //}
            //else if (a == b) Console.WriteLine("Asal sayı yoktur.");
            //else if (b > a)
            //{
            //    for (int i = a; i < b; i++)
            //    {

            //    }
            //}
            //Console.ReadLine();
            //_________________________________________________________________________________________________________






            int a , asal = 0; ;
            Console.Write("Lütfen a değerini giriniz: ");
            a = int.Parse(Console.ReadLine());


            for (int sayi = 2; sayi < a; sayi++)
            {
               for (int i = 2; i<sayi; i++)
                {
                    if(sayi % i == 0)
                    {
                        break;
                    }
                    else if(i == sayi-1)
                    {
                        asal = sayi;
                    }
                 
                }
                 

            }

            Console.WriteLine(asal);
            Console.ReadLine();
        }








    }
}

