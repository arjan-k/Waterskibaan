using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan_WPF__new_.Klassen
{
    public class Kabel
    {
        private LinkedList<Lijn> _lijnen = new LinkedList<Lijn>();

        public bool IsStartPositieLeeg()
        {
            if (_lijnen != null)
            {
                return true;
            }
            else
            {
                if (_lijnen.First.Value.PositieOpDeKabel == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public void NeemLijnInGebruik(Lijn lijn)
        {
            if (IsStartPositieLeeg())
            {
                lijn.PositieOpDeKabel = 0;
                _lijnen.AddFirst(lijn);
            }
        }

        public void VerschuifLijnen()
        {
            foreach(Lijn lijn in _lijnen)
            {
                if(lijn.PositieOpDeKabel < 10)
                {
                    lijn.PositieOpDeKabel += 1;
                    lijn.Sporter.Move();
                }
            }
            if (_lijnen.Last.Value.PositieOpDeKabel == 10)
            {
                var lastLijn = _lijnen.Last.Value;
                
                lastLijn.Sporter.AantalRondenNogTeGaan--;

                if(lastLijn.Sporter.AantalRondenNogTeGaan > 0)
                {
                    NeemLijnInGebruik(lastLijn);
                    lastLijn.PositieOpDeKabel = 0;
                }
                else
                {
                    _lijnen.RemoveLast();
                }
            }
        }

        public Lijn VerwijderLijnVanKabel()
        {
            foreach (Lijn lijn in _lijnen)
            {
                if(lijn.PositieOpDeKabel == 9 && lijn.Sporter.AantalRondenNogTeGaan == 0)
                {
                    Console.WriteLine($"Verwijder lijn met positie: {lijn.PositieOpDeKabel}");
                    return lijn;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder();

            foreach (Lijn lijn in _lijnen)
            {
                sb.Append(lijn.PositieOpDeKabel).Append("|");
            }

            return $"{sb}\n";
        }
    }
}
