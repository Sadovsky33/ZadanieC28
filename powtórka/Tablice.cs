using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtórka
{
    public class Tablice
    {
        public void Wyswietl(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++) 
            {
                Console.Write(tab[i]+ ",");
            }
        }


        public int[] Tworzenie_tablicy()
        {
            Console.WriteLine("ile znaków ma mieć tablica?");
            int dl = int.Parse(Console.ReadLine());

            int[] ints = new int[dl];

            for (int i = 0; i < dl; i++)
            {
                Console.WriteLine("podaj kolejny element:");
                ints[i] = int.Parse(Console.ReadLine()) ;
            }
            return ints;
        }

        public void Sortowanie(int[] tab)
        {
            int n = tab.Length;
            for (int i = 0;i < tab.Length; i++)
            {
                for(int j = 1; j < tab.Length - i; j++)
                {
                    if (tab[j-1] < tab[j])
                    {
                        int temp = tab[j-1];
                        tab[j-1] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
        }

        public void Przeszukaj(int[] tab)
        {
            Console.WriteLine("jakiej liczby szukasz w tablicy?");
            int szukana = int.Parse(Console.ReadLine());

            bool liczba_istnieje = false;
            int ile_powtorzen = 0;
            for(int i = 0;i < tab.Length;i++)
            {
                if (tab[i] == szukana)
                {
                    liczba_istnieje = true;
                    ile_powtorzen++;
                }
            }
            if(liczba_istnieje == true)
            {
                Console.WriteLine($"Liczba jest w tablicy, występuje {ile_powtorzen}");
            }
            else
            {
                Console.WriteLine("liczby nie ma w tablicy");
            }
            
        }
    }
}
