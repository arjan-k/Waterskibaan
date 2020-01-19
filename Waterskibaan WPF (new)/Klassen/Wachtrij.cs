using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan_WPF__new_.Klassen
{
    public abstract class Wachtrij : IWachtrij
    {
        private Queue<Sporter> _wachtRij = new Queue<Sporter>();
        public int MAX_LENGTE_RIJ { get; }


        public List<Sporter> GetAllSporters()
        {
            List<Sporter> alleSporters = new List<Sporter>();
            foreach (var sporter in _wachtRij)
            {
                alleSporters.Add(sporter);
            }
            return alleSporters;
        }

        public void SporterNeemtPlaatsInRij(Sporter sp)
        {
            _wachtRij.Enqueue(sp);
        }

        public List<Sporter> SportersVerlatenRij(int aantal)
        {
            List<Sporter> sporterBeurtList = new List<Sporter>();
            for (int i = 0; i < aantal; i++)
            {
                try
                {
                    sporterBeurtList.Add(_wachtRij.Dequeue());
                }
                catch
                {
                    Console.WriteLine("Wachtrij leeg.");
                }
            }
            return sporterBeurtList;
        }

        public override string ToString()
        {
            return $"{_wachtRij.Count} sporters";
        }
    }
}
