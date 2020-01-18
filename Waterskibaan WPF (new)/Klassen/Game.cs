using System;
using System.Collections.Generic;
using System.Text;
using Waterskibaan_WPF__new_.Klassen.Wachttijden;
using System.Timers;

namespace Waterskibaan_WPF__new_.Klassen
{
    class Game
    {
        private InstructieGroep _instructieGroep = new InstructieGroep();
        private WachtrijInstructie _wachtrijInstructie = new WachtrijInstructie();
        private WachtrijStarten _wachtrijStarten = new WachtrijStarten();
        public InstructieGroep instructieGroep { get => _instructieGroep; set => _instructieGroep = value; }
        public WachtrijInstructie wachtrijInstructie { get => _wachtrijInstructie; set => _wachtrijInstructie = value; }
        public WachtrijStarten wachtrijStarten { get => _wachtrijStarten; set => _wachtrijStarten = value; }


        private Waterskibaan _wb = new Waterskibaan();
        public Waterskibaan wb { get => _wb; set => _wb = value; }


        public Timer startGameTimer;

        public void Initialize()
        {
            startGameTimer = SetTimer(1000, OnGameStartEvent);
        }

        public Timer SetTimer(int ms, ElapsedEventHandler elapsedEventHandler)
        {
            // create a new timer with 'x' interval in miliseconds & produce elapsed event
            Timer t = new Timer(ms);
            t.Elapsed += (ElapsedEventHandler)elapsedEventHandler;
            t.AutoReset = true;
            t.Enabled = true;
            return t;
        }

        public void OnGameStartEvent(object source, ElapsedEventArgs e)
        {
            wb.SporterStart(new Sporter());
            wb.VerplaatsKabel();
            wb.ToString();
        }
    }
}
