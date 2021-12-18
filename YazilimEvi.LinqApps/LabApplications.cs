using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace YazilimEvi.LinqApps
{
    public class LabApplications
    {
        public static void App01()
        {
            // (1) VERİ KAYNAĞINA ERİŞİM
            var rand = new Random();
            var randomSequence = Enumerable.Repeat(0, 10).Select(i => rand.Next(0, 100));
            var numbers = new List<int>(randomSequence);

            // (2) SORGU TASARIMI 
            // numbers listesinin özellikleri
            // Tek sayılar yer alacaktır.                   
            // Sayılar büyükten küçüğe sıralanacaktır.
            // Sayılar benzersiz olacaktır.
            // İlk beş örnek alınacaktır. 

            // querySyntax için gerekli düzenlemeyi yapınız. 
            var querySyntax = from num in numbers
                              select num;

            // SORGUNUN ÇALIŞTIRILMASI
            // elde ettiğiniz sonuçları Uygulama Yönergesine işleyiniz. 
            Console.WriteLine("List of Numbers");
            querySyntax.ToList().ForEach(x => Console.Write($"{x,-3}"));
        }

        public static void App02()
        {
            var list = new ArrayList
            {
                "Ahmet","Mehmet","Ayşe","Hatice","Feyza","Mert",
                23,55,44,16,23,34,6,12,13,49,
                true,false,
                DateTime.Now, DateTime.Now.AddDays(3), DateTime.Now.AddMonths(5)
            };

            // Sorguyu <string> yerine <int>, <DateTime> ve <bool> içinde çalıştırınız. 
            var methodSyntaxQuery = list.OfType<string>();

            // method query üzerindeki kayıtları döndüreceğiniz
            foreach (var item in methodSyntaxQuery)
            {
                Console.WriteLine(item);
            }
        }

        private static List<T> GenerateList<T>(IEnumerable collection)
        {
            var list = new List<T>();
            foreach (var item in collection)
            {
                // Gerekli implementasyonu gerçekleştiriniz
            }
            return list;
        }
    }
}
