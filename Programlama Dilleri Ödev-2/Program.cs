using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programlama_Dilleri_Ödev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1-Klavyeden girilen saniye değerini, hh:mm:ss biçiminde formatlı olarak yazdıran programı yazınız.
            //____________________________________________________________________________________________________
            //int second, hour, minute;
            //Console.Write("Lütfen saniye değeri giriniz: ");
            //second = int.Parse(Console.ReadLine());
            //minute = second / 60;
            //second = second % 60;
            //hour = minute / 60;
            //minute = minute % 60;
            //Console.WriteLine("Girilen saniye değerinin format hali {0}:{1}:{2}", hour, minute, second);
            //Console.ReadKey();
            //____________________________________________________________________________________________________



            //2-Random 250 ile 100000 arasında girilen bir sayının kaç basamaklı olduğunu ekrana yazdıran program
            //____________________________________________________________________________________________________
            //Random rn=new Random();
            //int sayı = rn.Next(250, 10001);
            //int sayac=0;
            //Console.WriteLine(sayı);

            //while(sayı>0)
            //{
            //    sayı /= 10;
            //    sayac++;
            //}
            //Console.WriteLine(sayac);
            //  Console.ReadKey();  
            //____________________________________________________________________________________________________




            //3-Dört basamaklı sayılardan ilk iki basamağı ile son iki basamağının toplamının karesi, sayının kendisine
            //eşit olan sayılara orijinal sayı denir. Girilen bir sayının orijinal olup olmadığını saptayan algoritma ve program.
            //____________________________________________________________________________________________________
            //int sayı,ilkiki,soniki;
            //int originalNumber = 0;
            //int temp;
            //Console.Write("Lütfen dört basamaklı bir sayı giriniz: ");
            //sayı= int.Parse(Console.ReadLine());
            //temp = sayı;
            //ilkiki = sayı % 100;
            //sayı /= 100;
            //soniki = sayı % 100;
            //sayı /= 100;
            //Console.WriteLine(soniki+""+ilkiki);
            //originalNumber = soniki + ilkiki;
            //int org =Convert.ToInt32( Math.Pow(originalNumber, 2));
            //if (org == temp) Console.WriteLine("{0} sayısı bir orijinal sayıdır.",temp);
            //else Console.WriteLine("{0} sayısı bir orijinal sayı değildir.",temp);
            //Console.ReadKey();
            //____________________________________________________________________________________________________







            //4-Klavyeden alınan saat ve dakika bilgileriyle yelkovan ile akrep arasındaki açıyı bulan programı yazınız.
            //(Örn: 6:00 ve 18:00 için 180 derece; 9:00, 3:00 için 45 derece )
            //____________________________________________________________________________________________________

            //int dakika, saat,akrep=0,yelkovan=0;
            //Console.Write("Lütfen dakika bilgisini giriniz: ");
            //dakika = int.Parse(Console.ReadLine());
            //if (dakika < 0 || dakika > 60) Console.WriteLine("Lütfen geçerli bir dakika bilgisi giriniz!!");
            //else
            //{
            //    Console.Write("Lütfen saat bilgisini giriniz: ");
            //    saat = int.Parse(Console.ReadLine());
            //    if (saat < 0 || saat > 24) Console.WriteLine("Lütfen geçerli bir saat bilgisi giriniz!!");

            //    yelkovan =dakika* 6;
            //    akrep = ((saat % 12) * 30)-yelkovan;
            //    if (akrep < 0) akrep = akrep * -1;
            //    Console.WriteLine(akrep);
            //}
            //Console.ReadKey();
            //____________________________________________________________________________________________________




            //5-İkinci dereceden bir denklemin köklerini bulan program
            //____________________________________________________________________________________________________
            //double kök1, kök2,a,b,c;
            //double disc=0;
            //Console.Write("Lütfen a katsayısını giriniz: ");
            //a= int.Parse(Console.ReadLine());
            //Console.Write("Lütfen b katsayısını giriniz: ");
            //b = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen c katsayısını giriniz: ");
            //c = int.Parse(Console.ReadLine());
            //disc=(Math.Pow(b,2))-(4*a*c);
            //kök1 = (-b + Math.Sqrt(disc)) / (2 * a);
            //kök2 = (-b - Math.Sqrt(disc)) / (2 * a);
            //if (disc > 0) Console.Write("İki adet kök vardır bunlar X1 için {0} ve X2 için {1}. ", kök1, kök2);
            //else if (disc < 0) Console.Write("Denklemin Gerçek kökü yoktur.");
            //else if (disc == 0) Console.Write("Denklemin bir adet gerçel kökü vardır {0}",kök1);
            //Console.ReadKey();
            //____________________________________________________________________________________________________




            //6-Bir sayının faktöriyelini bulan program
            //____________________________________________________________________________________________________
            //    Program pr= new Program();
            //    int sayi;
            //    Console.Write("Faktoriyeli bulunmak istenen değeri giriniz: ");
            //    sayi= int.Parse(Console.ReadLine());
            //    Console.WriteLine(pr.Factorial(sayi));
            //    Console.ReadLine();
            //}
            //public int Factorial(int sayi)
            //{
            //    if (sayi == 0 || sayi == 1)
            //        return 1;
            //    else return sayi*Factorial(sayi-1);
            //}
            //____________________________________________________________________________________________________






            //7-Bir sayının üssünü bulan program
            //____________________________________________________________________________________________________
            //    Program pr = new Program();
            //    int sayi, kuvvet;
            //    Console.Write("üssü bulunmak istenen değeri giriniz: ");
            //    sayi = int.Parse(Console.ReadLine());
            //    Console.Write("üssü giriniz: ");
            //    kuvvet = int.Parse(Console.ReadLine());
            //    Console.WriteLine(pr.ExponantialNumbers(sayi, kuvvet));

            //    Console.ReadKey();

            //}
            //public int ExponantialNumbers(int sayi, int kuvvet)
            //{
            //    int sonuc = 1;
            //    if (kuvvet == 0) return 1;
            //    else return sonuc = sayi * ExponantialNumbers(sayi, kuvvet - 1);
            //}
            //____________________________________________________________________________________________________




            //8-Bir sayının basamak değerlerinin toplamını bulan programı yazınız
            //____________________________________________________________________________________________________
            //    int sayı;
            //    Console.Write("Lütfen bir sayı giriniz: ");
            //    sayı = int.Parse(Console.ReadLine());
            //    Program pr = new Program();
            //    Console.WriteLine(pr.BasamakToplamı(sayı));
            //    Console.ReadKey();
            //}
            //public int BasamakToplamı(int sayi)
            //{
            //    int sonuc = 0;
            //    if (sayi == 0) return 0;
            //    else return sonuc = sayi % 10 + BasamakToplamı(sayi / 10);

            //}
            //____________________________________________________________________________________________________
        }
    }
}

