using System;
using System.Collections.Generic;

namespace Dictionarydeneme
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary <int,string> sozluk = new Dictionary <int,string> ();
           
            sozluk.Add(1, "a");
            Console.WriteLine(sozluk.Count);
            //foreach (var item in sozluk)
            //{
            //    Console.WriteLine(item);
            //}
            MyDictionary<int, string> mysozluk = new MyDictionary<int, string>();
            mysozluk.Add(2, "b");
            mysozluk.Add(3, "c");
            Console.WriteLine(mysozluk.Count);

            //foreach (var item in mysozluk)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }

    public class MyDictionary<K,V>// farklı olmalıya
    {
        K[] array;
        K[] temparray;
        V[] array1;
        V[] temparray1;
        public MyDictionary()
        {
            array = new K[0];
            array1 = new V[0];
            
        }

        public void Add(K item, V item1)
        {
            temparray = array;//geçmiş veriyi tempde tutuyoruz
            temparray1 = array1;
            array= new K[array.Length + 1];// yenş adreslere  boyutu bir attırılmış arraylar tanımlıyoruz içi boş
            array1 = new V[array1.Length + 1];
            for (int i = 0; i < temparray.Length; i++)// Keyler için önceki değerlerialma
            {
                array[i] = temparray[i];
            }
            for (int i = 0; i < temparray1.Length; i++)//valueler için geçmiş değerleri alma
            {
                array1[i] = temparray1[i];
            }
            //simdide yeni eklenen değerleri atama
            array[array.Length - 1] = item;
            array1[array1.Length - 1] = item1;
;
        }
        public int Count
        {
            get { return array.Length;
                return array1.Length;
              }
           
        }

    }
}
