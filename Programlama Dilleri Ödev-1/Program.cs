using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programlama_Dilleri_Ödev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Klavyeden girilen iki tam sayının toplamını bulan program
            //____________________________________________________________________________________
            //int sum = 0;
            //int x, y;

            //Console.Write("Lütfen birinci değer giriniz: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci değeri giriniz: ");
            //y = int.Parse(Console.ReadLine());
            //sum = x + y;
            //Console.WriteLine("Girilen " + x + " ve " + y + " değerlerinin toplamı: {0}", sum);
            //Console.ReadLine();
            //____________________________________________________________________________________





            //Doğum yılı verilen kişinin yaşını bulan program
            //____________________________________________________________________________________
            //int age = 0;
            //int x;

            //Console.Write("Lütfen doğum yılınızı giriniz: ");
            //x = int.Parse(Console.ReadLine());

            //age = DateTime.UtcNow.Year-x;
            //Console.WriteLine("Yaşınız: {0}", age);
            //Console.ReadLine();
            //____________________________________________________________________________________






            //3. Dikdörtgenin hacmini bulan program
            //____________________________________________________________________________________
            //int a, b, h;
            //int volume = 0;
            //Console.Write("Kısa Kenarı Giriniz: ");
            //a=int.Parse(Console.ReadLine());
            //Console.Write("Uzun Kenarı Giriniz: ");
            //b=int.Parse(Console.ReadLine());
            //Console.Write("Yüksekliği giriniz: ");
            //h=int.Parse(Console.ReadLine());
            //area = a * b * h;
            //Console.WriteLine("Dikdörtgenin Hacmi: {0}",volume);
            //Console.ReadKey();
            //____________________________________________________________________________________






            //4. Yarıçapı istenen dairenin alanını bulan program (pi = 3.14 alabilirsiniz)
            //____________________________________________________________________________________
            //double area = 0;
            //float pi = 3.14f;
            //int radius;
            //Console.Write("Please enter the value of the radius: ");
            //radius = int.Parse(Console.ReadLine());
            //area = pi * Math.Pow(radius,2);
            //Console.WriteLine("The area of the circle is {0} for the radius {1}", area, radius);
            //Console.ReadKey();
            //____________________________________________________________________________________





            //5. İki tam sayının bölüm ve kalanını bulan program
            //____________________________________________________________________________________
            //int remain = 0;
            //int division = 0;
            //int x, y;

            // Console.Write("Lütfen birinci değer giriniz: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci değeri giriniz: ");
            //y = int.Parse(Console.ReadLine());
            //remain = x % y;
            //division = x / y;
            //Console.WriteLine("Girilen " + x + " ve " + y + " değerleri için bölüm {0} ve kalan {1}", division,remain);
            //Console.ReadLine();
            //____________________________________________________________________________________






            //6. Klavyeden girilen 3 sayının aritmetik ortalamasını bulan programı yazınız.
            //____________________________________________________________________________________
            //double mean = 0;
            //int x, y,z;
            //int sum = 0;
            //Console.Write("Lütfen birinci değer giriniz: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci değeri giriniz: ");
            //y = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen üçüncü değeri giriniz: ");
            //z = int.Parse(Console.ReadLine());
            //sum = x + y + z;
            //mean = sum / 3;
            //Console.WriteLine("Girilen  değerlerin aritmatik ortalaması : {0}", mean);
            //Console.ReadLine();
            //____________________________________________________________________________________





            //7. Klavyeden girilen 2 sayıyı karşılaştırıp sonucu ekrana yazdıran programı yazınız.
            //____________________________________________________________________________________
            //int x, y;
            //Console.Write("Lütfen birinci değer giriniz: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci değeri giriniz: ");
            //y = int.Parse(Console.ReadLine());
            //if (x > y)
            //{ Console.WriteLine("{0}>{1}", x, y); }
            //else if (y > x)
            //{
            //    Console.WriteLine("{1}>{0}", x, y);
            //}
            //else if (x == y) Console.WriteLine("Girilen değerler birbirine eşittir.");
            //Console.ReadLine();
            //____________________________________________________________________________________




            //8. Klavyeden girilen bir sayının tek mi çift mi olduğunu gösteren program
            //____________________________________________________________________________________
            //int x;
            //Console.Write("Bir değer giriniz: ");
            //x=int.Parse(Console.ReadLine());
            //if (x % 2 == 0) Console.WriteLine("Girilen sayı çifttir.");
            //else if (x % 2 != 0) Console.WriteLine("Girilen sayı tektir.");
            //Console.ReadLine();
            //____________________________________________________________________________________





            //9. Klavyeden girilen Celsius değerinin Fahrenheit eşdeğerini bulan programı yazınız.
            //____________________________________________________________________________________
            //double c,f=0;
            //Console.Write("Enter value of the Celcius : ");
            //c= Convert.ToDouble(Console.ReadLine());
            //f = ((c / 100) * 180) + 32;
            //Console.WriteLine("Result of the Celcius to Fahrenheit from the values given is {0}",f);
            //Console.ReadLine();
            //____________________________________________________________________________________




            //10. Klavyeden aynı anda girilen 2 sayıdan, küçük sayının büyük sayının tam böleni olup olmadığını bulan program.
            //Öncelikle girilen sayılardan hangisinin daha büyük hangisinin daha küçük olduğu tespit edilmelidir.
            //____________________________________________________________________________________
            //int x, y;
            //Console.Write("Lütfen birinci değer giriniz: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci değeri giriniz: ");
            //y = int.Parse(Console.ReadLine());
            //if (x > y)
            //{
            //    if (x % y == 0)
            //    {
            //        Console.WriteLine("{0} değeri {1} değerinin bir tam bölenidir.", y, x);
            //    }
            //}
            //else if (y > x)
            //{
            //    if (y % x == 0)
            //        Console.WriteLine("{0} değeri {1} değerinin bir tam bölenidir.", x, y);
            //}
            //else if (x == y) Console.WriteLine("Girilen değerler birbirine eşittir.");
            //Console.ReadLine();
            //____________________________________________________________________________________



        }
    }
}
