using System;

namespace TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Bilinçsiz Dönüşüm
            Console.WriteLine("Implict Conversion");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:"+i);

            string e = "fatih";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g:" + g);

            //Bu şekilde yazılımcının isteği dışında gerçekleşen özellikle düzenlemediğimiz dönüşümler gerçekleşir.
            //Bu dönüşümleri C# kendi kendine halleder halledemediği kısımda bizim dönüşümü gerçekleştirabilmek için kod yazmamız gerekir.

            //Bizim kod yazarak gerçekleştirdiğimiz dönüşümlere bilinçli dönüşüm denir.

            //Bilinçli Dönüşüm
            Console.WriteLine("Explict Conversion");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            //Çevrimlerde veri kaybı olabilir.

            //ToString
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine(yy);

            string zz=12.5f.ToString();
            Console.WriteLine(zz);

            //System.Convert
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam:" + toplam);

            //Parse
            //String ifadeleri sayılara çevirmede kulanılır
            ParseMethod();

        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1=Int32.Parse(metin1);
            Console.WriteLine("rakam1:"+rakam1);

            double1=Double.Parse(metin2);
            Console.WriteLine("double1:" + double1);

        }

    }
}