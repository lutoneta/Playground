using System;

namespace Playground
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World Mijuch is coming");
            //Console.WriteLine("Zaczynamy");
            ////Console.ReadLine();
            //Rower dlybekObiekt = new Dlybek();
            //Rower kolarkaObiekt = new Kolarka();
            //Console.WriteLine("czy dlybek jest szybki? - " + dlybekObiekt.jestSzybki);
            //Console.WriteLine("czy kolarka ma przerzutki? - " + kolarkaObiekt.maPrzerzutki);
            //Console.WriteLine("jakiego koloru jest Dlybek - " + Dlybek.kolor());
            //Console.WriteLine("Ile to jest 5 + 10: " + suma(5, 10));
            //Console.WriteLine("jakiego koloru sa kola? - " + Rower.kolorKola());
            //przykladArray();

            //Console.WriteLine("\nCo?");
            //string reply = Console.ReadLine();
            //Console.WriteLine("AAAAA -> " + reply);

            //Console.Write("////HUMANS");
            //Human AnetaObiekt = new Aneta();
            //Human PatrykObiekt = new Patryk();
            //Human MiaObiekt = new Mia();
            //(AnetaObiekt as Woman).baby = MiaObiekt;
            //MiaObiekt.father = PatrykObiekt;
            //MiaObiekt.mother = AnetaObiekt;
            //Console.WriteLine("Mia -> " + MiaObiekt);
            //Console.WriteLine("Mia father -> " + (MiaObiekt as Mia).father.name);
            //Console.WriteLine("Mia mother -> " + (MiaObiekt as Mia).mother.name);

            Console.WriteLine("////Karcze");
            Human DanutaObiekt = new Danuta();
            Human TadeuszObiekt = new Tadeusz();
            Human AnetaObiekt = new Aneta();
            Human EwelinaObiekt = new Ewelina();
            EwelinaObiekt.father = TadeuszObiekt;
            EwelinaObiekt.mother = DanutaObiekt;
            Console.WriteLine("Danuta -> mother");
            Console.WriteLine("Tadeusz -> father");
            Console.WriteLine("Ewelina father -> " + EwelinaObiekt.father.name);
            Console.WriteLine("Ewelina mother -> " + EwelinaObiekt.mother.name);
        }

        //funkcja zwrotna
        static int suma(int a, int b)
        {
            //int sum = x + y;
            //string sentence = "The sum of " + x + " and " + y + " is " + sum + ".";
            return a + b;
        }

        static void przykladArray()
        {
            string[] array = new string[] { "uno", "duo", "tres", "quattro" };
            Console.WriteLine("przyklad array - " + string.Join(", ", array));

            /* initialize elements of array n */
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("I element: " + array[i] + " bingo!");
            }

            /* output each array element's value */
            foreach (string j in array)
            {
                string newValue = j + " ha !";
                Console.WriteLine("J element: " + newValue);
            }

            // sort

            Array.Sort(array);
            // write array
            Console.WriteLine("Posortowane alfabetycznie");
            foreach (string str in array) Console.Write(str + " ");
        }
    }

    //Tworzymy nowa klase

    public class Rower
    {
        // zmienne klasowe - nie okreslone
        public Boolean maPrzerzutki;
        public Boolean jestSzybki;
        public int iloscKolek;

        public static string kolorKola()
        {
            return "srebrny";
        }
    }

    public class Dlybek : Rower
    {

        // konstruktor
        public Dlybek()
        {
            // okreslone zmienne klasowe
            maPrzerzutki = false;
            jestSzybki = false;
            iloscKolek = 2;
            Console.WriteLine ("ile dlybek ma kol?- " + iloscKolek);
        }

        public static string kolor()    
        {
            return "zieluny";
        }
    }


    public class Kolarka : Rower
    {
        public Kolarka()
        {
            maPrzerzutki = true;
            jestSzybki = true;
            iloscKolek = 2;
        }
    }
}
/// <summary>
/// HUMANS
/// </summary>

public enum humanGender
{
    Female,
    Male
}

public class Human
{
    public humanGender gender;
    public int height;
    public int weight;
    public Boolean isAdult;
    public Boolean isChild;
    public string name;
    public Human mother;
    public Human father;
}

public class Woman: Human
{
    public Boolean isPregnant;
    public Human baby;
    public Boolean isMother;
}

public class Man : Human
{
    public Boolean hasMuscles;
}

public class Aneta: Woman
{
    public Aneta()
    {
        name = "Aneta";
        isAdult = true;
        isPregnant = true;
    }
}

public class Patryk: Man
{
    public Patryk()
    {
        name = "Patryk";
        isAdult = true;
        hasMuscles = false;
    }
}

public class Mia : Woman {

    public Mia()
    {
        name = "Mia";
        isChild = true;
    }
}


public class Danuta : Woman
{
    public Danuta()
    {
        name = "Danuta";
        isAdult = true;
        isMother = true;
    }
}

public class Tadeusz : Man
{
    public Tadeusz()
    {
        name = "Tadeusz";
        isAdult = true;
        hasMuscles = false;
    }
}


public class Ewelina : Woman
{

    public Ewelina ()
    {
        name = "Ewelina";
        isChild = true;
    }
}

