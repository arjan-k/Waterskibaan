using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan_WPF__new_.Klassen.Wachttijden
{
    public class WachtrijInstructie : Wachtrij, IWachtrij
    {
        public int MAX_LENGTE_RIJ()
        {
            return 100;
        }

        public override string ToString()
        {
            return base.ToString() + " in de instructiewachtrij.";
        }
    }
}
