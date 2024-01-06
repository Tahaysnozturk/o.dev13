using System;

namespace or211
{
    class Program
    {
        public static void Main(string[] args)
        {
            int enBuyuk = int.MinValue;
            int enDusuk = int.MaxValue;
            string[] isimler = { "Emin", "Emir", "İclal", "Bekir", "Cem", "Arda", "Kaan", "Metin", "Can", "Ramiz" };
            int[] notlar = { 56, 78, 95, 23, 95, 87, 61, 77, 45, 33 };

            string enYuksekAlanlar = "En Yüksek Notu Alan Kişi/Kişiler: ";
            string enDusukAlanlar = "En Düşük Notu Alan Kişi/Kişiler: ";

            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] > enBuyuk)
                {
                    enBuyuk = notlar[i];
                }

                if (notlar[i] < enDusuk)
                {
                    enDusuk = notlar[i];
                }
            }

            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] == enBuyuk)
                {
                    enYuksekAlanlar += isimler[i] + ", ";
                }

                if (notlar[i] == enDusuk)
                {
                    enDusukAlanlar += isimler[i] + ", ";
                }
            }

            Console.WriteLine(enYuksekAlanlar.TrimEnd(',', ' ') + ".");
            Console.WriteLine(enDusukAlanlar.TrimEnd(',', ' ') + ".");

            Console.Write("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
