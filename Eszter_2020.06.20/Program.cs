using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._06._20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Írj programot, mely beolvas három egész számot, 
            //és kiírja a képernyőre a legkisebbet!
            Console.Write("Kérem adja meg az első egész számot! ");
            int elso = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a második egész számot! ");
            int masodik = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a harmadik egész számot! ");
            int harmadik = int.Parse(Console.ReadLine());
            if (elso < masodik && elso < harmadik)
            {
                Console.WriteLine("A három szám közül {0} a legkisebb szám!",elso);
            }
            if (masodik < elso && masodik < harmadik)
            {
                Console.WriteLine("A három szám közül {0} a legkisebb szám!", masodik);
            }
            if (harmadik < elso && harmadik < masodik)
            {
                Console.WriteLine("A három szám közül {0} a legkisebb szám!", harmadik);
            }

            //Írj programot, mely generál három egész véletlen számot [2-100], 
            //és kiírja mindhárom számot a képernyőre növekvő sorrendben!
            Random veletlen = new Random(); //példányosítottunk egy üres Random osztályt
            int szam1 = veletlen.Next(2, 101);
            int szam2 = veletlen.Next(2, 101);
            int szam3 = veletlen.Next(2, 101);
            Console.WriteLine($"A generált számok: {szam1} {szam2} {szam3}");
            if (szam1 < szam2 && szam1 < szam3)
            {
                if(szam2 < szam3) Console.WriteLine($"Rangsor növekvőben: {szam1} {szam2} {szam3}");
                else Console.WriteLine($"Rangsor növekvőben: {szam1} {szam3} {szam2}");
            }

            if (szam2 < szam1 && szam2 < szam3)
            {
                if (szam1 < szam3)
                {
                    Console.WriteLine($"Rangsor növekvőben: {szam2} {szam1} {szam3}");
                }
                else
                {
                    Console.WriteLine($"Rangsor növekvőben: {szam2} {szam3} {szam1}");
                }
            }

            if (szam3 < szam1 && szam3 < szam2)
            {
                if (szam1 < szam2)
                {
                    Console.WriteLine($"Rangsor növekvőben: {szam3} {szam1} {szam2}");
                }
                else
                {
                    Console.WriteLine($"Rangsor növekvőben: {szam3} {szam2} {szam1}");
                }
            }

            //Írj programot, amely 1 és 100 között kiírja az összes páros egész számot!
            //A számokat egymástól szóközökkel válasszuk el a kiírás sorrendjében.
            for (int i = 2;i<=100;i=i+2)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}
