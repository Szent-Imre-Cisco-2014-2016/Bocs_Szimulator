using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double bőcs = 0;
            double egyes = 0;
            bool aurél = false;
            while (aurél == false)
            {
                Console.WriteLine("Bőcs Szimulátor v1.0\n");
                bőcs = 0;
                bőcs = rnd.Next(1, 10);
                if (bőcs < 5)
                {
                    Console.WriteLine("Késtél, megálsz az ajtóban...");
                    bőcs = 0;
                    bőcs = rnd.Next(1, 10);
                    if (bőcs < 5)
                    {
                        Console.WriteLine("Meghaltál...");
                        egyes = egyes + 1;
                    }
                    else
                    {
                        Console.WriteLine("Ezt megúsztad");
                    }
                }
                else
                {
                    Console.WriteLine("Időben beértél.");
                }
                bőcs = 0;
                bőcs = rnd.Next(1, 10);
                if (bőcs < 5)
                {
                    Console.WriteLine("Tessék új címnek felírni...");
                }
                else
                {
                    Console.WriteLine("Ezt a sort tessék szabaddá tenni...(évszámok)");
                    bőcs = 0;
                    bőcs = rnd.Next(1, 10);
                    if (bőcs < 5)
                    {
                        Console.WriteLine("Meghaltál...");
                        egyes = egyes + 1;
                        bőcs = 0;
                        bőcs = rnd.Next(1, 10);
                        if (bőcs < 5)
                        {
                            Console.WriteLine("Vaktérképet is kapsz...");
                            egyes = egyes + 1;
                        }
                        else
                        {
                            Console.WriteLine("De legalább nemkaptál vaktérképet");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ezt megúsztad");
                    }
                }
                bőcs = 0;
                bőcs = rnd.Next(1, 10);
                if (bőcs < 5)
                {
                    Console.WriteLine("Valaki(k) beszéltek az órán...5 perces killer doga (ezt nem úszodmeg)");
                    egyes = egyes + 1;
                }
                else
                {
                    Console.WriteLine("Mindenki szépen fegyelmezetten viselkedik");
                }
                bőcs = 0;
                bőcs = rnd.Next(1, 10);
                if (bőcs < 5)
                {
                    Console.WriteLine("kiderül hogy nincs atlaszod");
                    egyes = egyes + 1;
                }
                else
                {
                    Console.WriteLine("Ittvan az atlaszod, minden oké");
                }
                bőcs = 0;
                bőcs = rnd.Next(1, 10);
                if (bőcs < 4)
                {
                    Console.WriteLine("Nem hoztad az ujságcikkeket "+bőcs+" db cikkel tartoztál");
                    egyes = egyes + bőcs;

                }
                else
                {
                    Console.WriteLine("Behoztad az ujságcikkeket");
                }
                bőcs = 0;
                bőcs = rnd.Next(1, 10);
                if (bőcs < 5)
                {
                    Console.WriteLine("Kiderül hogy nincs könyved");
                    egyes = egyes + 1;
                }
                else
                {
                    Console.WriteLine("Ittvan a könyved, minden oké");
                }





















                Console.WriteLine("\nA mai órán " + egyes + " db egyest szeretél!");
                Console.Read();
                Console.Clear();
                egyes = 0;
            }
        }
    }
}
