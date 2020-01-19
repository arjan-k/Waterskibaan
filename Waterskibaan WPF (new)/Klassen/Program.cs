using System;
using System.Collections.Generic;
using System.Text;
using Waterskibaan_WPF__new_.Klassen;
using System.Windows;

namespace Waterskibaan_WPF__new_
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOpdracht11();

            MainWindow window = new MainWindow();
            window.Show();
        }

        static void TestOpdracht11()
        {
            Console.WriteLine("--- 11 ---");
            Console.WriteLine("Game start");
            Console.WriteLine("----------");
            Game game = new Game();
            game.Initialize();
            Console.Read();
        }

        static void TestOpdracht2()
        {
            Console.WriteLine("--- 2 ---");
            Kabel kabel = new Kabel();
            Lijn l1 = new Lijn();
            Lijn l2 = new Lijn();
            Lijn l3 = new Lijn();

            kabel.NeemLijnInGebruik(l1);
            Console.Write(kabel.ToString());
            kabel.VerschuifLijnen();
            kabel.NeemLijnInGebruik(l2);
            Console.Write(kabel.ToString());
            kabel.VerschuifLijnen();
            kabel.NeemLijnInGebruik(l3);
            Console.Write(kabel.ToString());
            kabel.VerschuifLijnen();
            Console.Write(kabel.ToString());
            kabel.VerschuifLijnen();
            Console.Write(kabel.ToString());
            kabel.VerschuifLijnen();
            Console.Write(kabel.ToString());
            kabel.VerschuifLijnen();
            Console.Write(kabel.ToString());
            kabel.VerschuifLijnen();
            Console.Write(kabel.ToString());
            kabel.VerschuifLijnen();
            Console.Write(kabel.ToString());
            kabel.VerschuifLijnen();
            Console.Write(kabel.ToString());
            kabel.VerschuifLijnen();
            Console.Write(kabel.ToString());
            kabel.VerschuifLijnen();
            Console.Write(kabel.ToString());
            kabel.VerschuifLijnen();
            Console.Write(kabel.ToString());
            kabel.VerschuifLijnen();
            Console.Write(kabel.ToString());
        }

        static void TestOpdracht3()
        {
            Console.WriteLine("--- 3 ---");
            LijnenVoorraad lv = new LijnenVoorraad();
            Lijn l1 = new Lijn();
            Lijn l2 = new Lijn();
            Lijn l3 = new Lijn();

            Console.WriteLine(lv.ToString());
            lv.LijnToevoegenAanRij(l1);
            Console.WriteLine(lv.ToString());
            lv.LijnToevoegenAanRij(l2);
            Console.WriteLine(lv.ToString());
            lv.LijnToevoegenAanRij(l3);
            Console.WriteLine(lv.ToString());

            lv.VerwijderEersteLijn();
            Console.WriteLine(lv.ToString());
            lv.VerwijderEersteLijn();
            Console.WriteLine(lv.ToString());
            lv.VerwijderEersteLijn();
            Console.WriteLine(lv.ToString());
        }

        static void TestOpdracht4()
        {
            Console.WriteLine("--- 4 ---");
            Waterskibaan wb = new Waterskibaan();

            Console.WriteLine(wb.ToString());
        }

        static void TestOpdracht8()
        {
            Console.WriteLine("--- 8 ---");
            Waterskibaan wb = new Waterskibaan();

            Console.WriteLine(wb.ToString());

            wb.SporterStart(new Sporter());
            wb.VerplaatsKabel();
            Console.WriteLine(wb.ToString());
            wb.SporterStart(new Sporter());
            wb.VerplaatsKabel();
            Console.WriteLine(wb.ToString());
            wb.SporterStart(new Sporter());
            wb.VerplaatsKabel();
            Console.WriteLine(wb.ToString());
            // Debug mode geeft ook juiste waardes sporter aan.
        }


    }
}
