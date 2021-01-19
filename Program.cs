using System;

namespace RefAndOutKeywords
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] kisiler = { "İrem", "Berkay", "Ceren", "Mert" };
            foreach (string kisi in kisiler)
            {
                Console.WriteLine(kisi);
            }

            Duzenle(kisiler);
            foreach (string kisi in kisiler)
            {
                Console.WriteLine(kisi);
            }
        }

        static void Duzenle(string[] kisiler)
        {
            for (int i = 0, kisiSayisi = kisiler.Length; i < kisiSayisi; i++)
            {
                kisiler[i] = "İrem";
            }

            // Örnekte yer alan "Duzenle" metoduna kisiler dizisinin başlangıç adresi gönderdik.
            // Diğer türler için ise metotlara belleğin başlangıç adresini göndermek yerine bir kopyasını gönderir.
            // Bu örneğin dizisinin koypasını almak eleman sayısı az olduğu için kısa sürebilir ama eleman sayısı çok olduğunda işlem uzun sürer.
            // Bu yüzden değer türlerini metoda geçmek için "ref" ve "out" keyword kullanırız.



            {  // REF KEYWORD

                int sayimiz1 = 3;
                Console.WriteLine("Başlangıç değeri: {0}", sayimiz1);
                Kare(sayimiz1);
                Console.WriteLine("Kare() sonrası: {0}", sayimiz1);
                Kare2(ref sayimiz1);
                Console.WriteLine("Kare2() sonrası: {0}", sayimiz1);
            }

            static void Kare(int sayi)
            {
                sayi = sayi * sayi;
            }

            static void Kare2(ref int sayi)
            {
                sayi = sayi * sayi;
            }

            // OUT KEYWORD

            // C# ta ref ve out aynı işlemi yapar.
            // Ancak ref ile kullanımda değişkene başlangıç değerinin verilmesi gerekirken out ile olan kullanımda başlangıç değerinin verimesine gerek yoktur.

            {
                int sayimizOut;
                DegistirOut(out sayimizOut);
                Console.WriteLine(sayimizOut);

                int sayimizRef = 0;  // değer verilmediğinde hata verecektir.
                DegistirRef(ref sayimizRef);
                Console.WriteLine(sayimizRef);
            }

            static void DegistirRef(ref int sayiRef)
            {
                sayiRef = 1234;
            }

            static void DegistirOut(out int sayiOut)
            {
                sayiOut = 1234;
            }

            // C# içinde yer alan out key word değer türlerindeki "TryParse" metodunda kullanılır.

            string girilenSayi = "1453";
            int sayimiz;

            bool sonuc = int.TryParse(girilenSayi, out sayimiz);

            if (sonuc)
            {
                Console.WriteLine("Dönüşüm başarılı.");
                Console.WriteLine("Sayı: {0}", sayimiz);
            }
            else
            {
                Console.WriteLine("Dönüşüm başarısız.");
            }



        }

    }




}




