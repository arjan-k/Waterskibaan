using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan_WPF__new_.Klassen
{
    public interface IWachtrij
    {
        public void SporterNeemtPlaatsInRij(Sporter sp);

        public List<Sporter> GetAllSporters();

        public List<Sporter> SportersVerlatenRij(int aantal);
    }
}
