using System;
using System.Text;

namespace zad9
{
    class Program
    {
        class lista
        {

            int[] tab12 = new int[100];
            public lista(int[] tab)//konstruktor z lista inicializacyjna
            {
                for (int i = 0; i < 100; i++)
                    tab12[i] = tab[i];
            }
            public void wyswietl()
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i % 10 == 0&&i!=0)
                        Console.WriteLine("\n");
                    if (i > -1 && i < 10)
                        Console.Write(tab12[i] + "  ");
                    else
                        Console.Write(tab12[i] + " ");

                }

            }
        }
        class nowa_clasa
        {
            public string imie = "brak";
            private string nazwisko = "brak";
            public nowa_clasa()
            {//konstruktor

            }


            
            


            public string Nazwisko   //i ptoperties
            {
                get { return nazwisko; }
                set { nazwisko = value; }
            }


          
        }
        static void swap(ref string a, ref string b) 
        {
            string c = a;
            a = b;
            b = c;
        
        
        
        }

        static double smaciez (int[,] tab)//funkcja wpisująca w tabele dwu wymiarowa ranodomowe liczby ktora jako argument ma tablice
        {
            Random a = new Random();
            int b = tab.Length;
            double c=System.Math.Sqrt(b);
            
           
            for (int i = 0; i < c; i++)
                for (int j = 0; j < c; j++)
                    tab[i, j] = a.Next(10, 99);
            return c;
        }
        static int [] zwracam_tab()//funkcja typu int [] pozwala na zwrocenie tablicy
        {
            int[] tab = new int[10];
           Random a = new Random();
            Console.WriteLine("10 randomowych cyfr");
            for (int i = 0; i < 10; i++)
            {
                tab[i] = a.Next(0, 9);
             Console.Write(tab[i]+" "); }
            Array.Sort(tab);
          
            Console.WriteLine("\nposegregowane:");
            for (int i = 0; i < 10; i++)
            {
                
                Console.Write(tab[i]+" ");
            }
            return tab;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Podpunkt 1\n");
            int[] tab = new int[100] ;
            for (int i = 0; i < 100; i++)
            {
                tab[i] = i;
            }
            lista a = new lista(tab);//uzycie listy nicializacyjnej do wypelnienia a (tablicy 100elem.)
            a.wyswietl();
            Console.WriteLine("\n\nPodpunkt 2");

            nowa_clasa[] tab1 = new nowa_clasa[10];//utworzenie taablicy 10 elementowej typu nowa_clasa
            for (int i = 0; i < tab1.Length; i++)//stworzenie 10 obiektów konstruktorem bez parametrow
                tab1[i] = new nowa_clasa();

            tab1[0].imie = "Halina";//przypisanie 4 obiektom imion i nazwisk
            tab1[0].Nazwisko = "Anilah";
            tab1[1].imie = "Julia";
            tab1[1].Nazwisko = "Ailuj";
            tab1[2].imie = "Kamil";
            tab1[2].Nazwisko = "Limak";
            tab1[3].imie = "Kuba";
            tab1[3].Nazwisko = "Abuk";
            Console.WriteLine();
            Console.WriteLine("Imie na pozycji 0: {0} imie na pozycji 3: {1}\n", tab1[0].imie, tab1[3].imie);//przykladowe dzialanie na obiekcie klasy 
            Console.WriteLine("zamiana imion z pozycji 0 i 3\n");
            swap(ref tab1[0].imie,ref tab1[3].imie);//zamiana imion 
            Console.WriteLine("Imie na pozycji 0: {0} imie na pozycji 3: {1}", tab1[0].imie, tab1[3].imie);


            Console.WriteLine("\nPodpunkt 3");
            int[,] tab123 = new int[10, 10];

            double pom=smaciez(tab123);//aby nie wykonywac kponownie pierwiastka przypisujemy obie pierwiastek wyliczony w funkcji ktora go zwraca dzieki temu znamy wielkosc tablicy
                                       //uzycie funkcji ktora jako argument bierze tablice
            for (int i = 0; i < pom; i++)
            {
                
                for (int j = 0; j < pom; j++)
                {
                    Console.Write(tab123[i,j]+" ");

                }

                Console.WriteLine();
            }
            //uzycie funkcji ktora zwraca tablice
            Console.WriteLine(zwracam_tab());//dowdd ze zwracana  jest tablica

            Console.WriteLine("\nPodpunkt 4");
            string w = "Paulina ";
            string ww = "Anlluap";
            
            string www = w + ww;
            Console.WriteLine(www);//string po dodaniu w i ww
            Console.WriteLine(www.Remove(3,6));//string po odjeciu/wymazaniu znaków od 3 do 6


            Console.WriteLine("\nPodpunkt 5");
            string imie="Kamil ";
            string nazwisko="Limak";
            string dane;
            StringBuilder aaa = new StringBuilder();//konstruktor stringow

            aaa.Append(imie);//dodajemy do niego najpierw imie potem naziwsko
            aaa.Append(nazwisko);
            dane = aaa.ToString();//zapisujemy do stringa dane
            Console.WriteLine(dane);
            aaa.Replace('a', 'z');//zamienimy wszystkie a na z
            dane = aaa.ToString();
            Console.WriteLine(dane);
            aaa.Insert(5, 157);//wrzuca na pozycje 5 liczbe 157
            dane = aaa.ToString();
            Console.WriteLine(dane);
            aaa.Remove(6, 4);//usuwamy od pozycji 5 4litery tak aby zostalo kamil1imzk
            dane = aaa.ToString();
            Console.WriteLine(dane);






            Console.ReadKey();




        }
    }
}
