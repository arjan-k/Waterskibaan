using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan_WPF__new_.Klassen
{
    public abstract class Wachtrij : IWachtrij
    {
        public List<Sporter> GetAllSporters()
        {
            throw new NotImplementedException();
        }

        public void SporterNeemtPlaatsInRij(Sporter sp)
        {
            throw new NotImplementedException();
        }

        public List<Sporter> SportersVerlatenRij(int aantal)
        {
            throw new NotImplementedException();
        }
    }
}
