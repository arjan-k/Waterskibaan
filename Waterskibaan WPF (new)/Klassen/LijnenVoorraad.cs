using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan_WPF__new_.Klassen
{
    public class LijnenVoorraad
    {
        private Queue<Lijn> _lijnen = new Queue<Lijn>();

        public void LijnToevoegenAanRij(Lijn lijn)
        {
            _lijnen.Enqueue(lijn);
        }

        public Lijn VerwijderEersteLijn()
        {
            if(_lijnen.Count < 0)
            {
                return null;
            }
            else
            {
                return _lijnen.Dequeue();
            }

        }

        public int GetAantalLijnen()
        {
            return _lijnen.Count;
        }

        public override string ToString()
        {
            return $"{GetAantalLijnen()} lijnen op voorraad";
        }
    }
}
