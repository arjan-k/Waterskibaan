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


        private Timer startGameTimer;
        private Timer nieuweBezoekerTimer;
        private Timer statusTimer;
        private Timer instructieAfgelopenTimer;


        public delegate void NieuweBezoekerHandler(NieuweBezoekerArgs args);
        public event NieuweBezoekerHandler NieuweBezoeker;

        public delegate void InstructieAfgelopenHandler(InstructieAfgelopenArgs args);
        public event InstructieAfgelopenHandler instructieAfgelopen;

        public void Initialize()
        {
            startGameTimer = SetTimer(1000, OnGameStartEvent); // Elke 1  sec.
            nieuweBezoekerTimer = SetTimer(3000, OnNieuweBezoekerEvent); // Elke 3  sec.
            statusTimer = SetTimer(10000, OnStatusEvent); // Elke 10 sec.
            instructieAfgelopenTimer = SetTimer(20000, OnInstructieAfgelopenEvent); // Elke 20 sec.

            NieuweBezoeker += OnNieuweBezoeker;
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
            Console.WriteLine($"{wb.ToString()}");
        }

        public void OnNieuweBezoekerEvent(object source, ElapsedEventArgs e)
        {
            NieuweBezoeker?.Invoke(new NieuweBezoekerArgs(new Sporter()));
        }

        private void OnNieuweBezoeker(NieuweBezoekerArgs e)
        {
            wachtrijInstructie.SporterNeemtPlaatsInRij(e.Sporter);
            OnBezoekerNaarInstructie();
        }

        public void OnBezoekerNaarInstructie()
        {
            List<Sporter> sporters = new List<Sporter>();
            if (instructieGroep.GetAllSporters().Count == 0)
            {
                sporters = wachtrijInstructie.SportersVerlatenRij(5);
            }
            foreach (Sporter sporter in sporters)
            {
                instructieGroep.SporterNeemtPlaatsInRij(sporter);
            }
        }

        public void OnInstructieAfgelopenEvent(object source, ElapsedEventArgs e)
        {

        }

        public void OnStatusEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine(
                 "-------------------------------------------------------- \n" +
                $"WachtrijInstructie: {wachtrijInstructie.ToString()} \n" +
                $"Instructiegroep: {instructieGroep.ToString()} \n" +
                $"WachtrijStarten: {wachtrijStarten.ToString()} \n" +
                $"--------------------------------------------------------");
        }

    }
}
