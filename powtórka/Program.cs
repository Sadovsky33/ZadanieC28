using powtórka;

class PlikGłówny
{
    static void Main(String[] args)
    {
        Tablice tablica = new Tablice();

        int[] tab = tablica.Tworzenie_tablicy();


        tablica.Sortowanie(tab);
        tablica.Wyswietl(tab);

        tablica.Przeszukaj(tab);

    }
}
      
    