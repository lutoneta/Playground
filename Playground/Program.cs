﻿using System;

namespace Playground
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World Mijuch is coming");
            Console.WriteLine("Zaczynamy");
            //Console.ReadLine();
            Rower dlybekObiekt = new Dlybek();
            Rower kolarkaObiekt = new Kolarka();
            Console.WriteLine("czy dlybek jest szybki? - " + dlybekObiekt.jestSzybki);
            Console.WriteLine("czy kolarka ma przerzutki? - " + kolarkaObiekt.maPrzerzutki);
            Console.WriteLine("jakiego koloru jest Dlybek - " + Dlybek.kolor());
            Console.WriteLine("Ile to jest 5 + 10: " + suma(5, 10));
            Console.ReadLine();
        }

        //funkcja zwrotna
        static int suma(int a, int b)
        {
            //int sum = x + y;
            //string sentence = "The sum of " + x + " and " + y + " is " + sum + ".";
            return a + b;
        }
    }

    //Tworzymy nowa klase

    public class Rower
    {
        // zmienne klasowe - nie okreslone
        public Boolean maPrzerzutki;
        public Boolean jestSzybki;
        public int iloscKolek;
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
