using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtórka
{
    public class Tablice
    {
        public void Wyswietl()
        {
            Console.WriteLine("111");
        }


        public void Tworzenie_tablicy()
        {
            Console.WriteLine("ile znaków ma mieć tablica?");
            int dl = int.Parse(Console.ReadLine());

            int[] ints = new int[dl];

            for (int i = 0; i < dl; i++)
            {
                Console.WriteLine("podaj kolejny element:");
                ints[i] = int.Parse(Console.ReadLine()) ;
            }
        }
    }
}
