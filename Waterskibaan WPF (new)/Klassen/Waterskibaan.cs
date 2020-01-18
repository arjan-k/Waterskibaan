using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Waterskibaan_WPF__new_.Klassen
{
    public class Waterskibaan
    {
        private LijnenVoorraad _lijnenVoorraad = new LijnenVoorraad();
        private Kabel _kabel = new Kabel();

        Random rnd = new Random();

        public Waterskibaan()
        {
            for (int i = 0; i < 15; i++)
            {
                _lijnenVoorraad.LijnToevoegenAanRij(new Lijn());
            }
        }
        public void VerplaatsKabel()
        {
            _kabel.VerschuifLijnen();
            _kabel.VerwijderLijnVanKabel();

            Lijn verwijderdeLijn = _kabel.VerwijderLijnVanKabel();
            if(verwijderdeLijn != null)
            {
                _lijnenVoorraad.LijnToevoegenAanRij(verwijderdeLijn);
            }
        }

        public void SporterStart(Sporter sp)
        {
            if(sp.Skies != null && sp.Zwemvest != null)
            {
                sp.AantalRondenNogTeGaan = rnd.Next(0, 2);
                Lijn lijn = new Lijn()
                {
                    Sporter = sp
                };
                _kabel.NeemLijnInGebruik(lijn);
                _lijnenVoorraad.VerwijderEersteLijn();
            }
            else
            {
                throw new Exception("SPORTER MIST: ZWEMVEST OF SKIES.");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Waterskibaan:");
            sb.Append($"{_lijnenVoorraad.ToString()}");
            sb.Append($"{_kabel.ToString()}");
            return $"{sb}";
        }
    }
}
