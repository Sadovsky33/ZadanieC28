using powtórka;

class PlikGłówny
{
    static void Main(String[] args)
    {
        Tablice tablica = new Tablice();

        int[] tab = tablica.Tworzenie_tablicy();

        tablica.Wyswietl(tab);
    }

}