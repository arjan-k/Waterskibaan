using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan_WPF__new_.Klassen.Wachttijden
{
    public class WachtrijStarten : Wachtrij
    {
        public int MAX_LENGTE_RIJ()
        {
            return 20;
        }

        public override string ToString()
        {
            return base.ToString() + "de startwachtrij.";
        }
    }
}
