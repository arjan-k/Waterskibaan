using System;
using System.Collections.Generic;
using System.Text;

namespace Waterskibaan_WPF__new_.Klassen
{
    public class NieuweBezoekerArgs
    {
        public Sporter Sporter { get; set; }
        public NieuweBezoekerArgs(Sporter sporter)
        {
            Sporter = sporter;
        }
    }
}
