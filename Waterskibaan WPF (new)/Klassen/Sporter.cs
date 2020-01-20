using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Waterskibaan_WPF__new_.Klassen
{
    public class Sporter : IMoves
    {
        Random rnd = new Random();

        private int _aantalRondenNogTeGaan = 0;
        public int AantalRondenNogTeGaan
        {
            get => _aantalRondenNogTeGaan;
            set
            {
                _aantalRondenNogTeGaan = value;
            }
        }

        public Zwemvest Zwemvest { get; set; }
        public Skies Skies { get; set; }
        public Color KledingKleur { get; set; }
        public List<IMoves> Moves { get; set; }
        public int Score { get; set; }
        
        public IMoves move;

        public Sporter()
        {
            Zwemvest = new Zwemvest();
            Skies = new Skies();
            AantalRondenNogTeGaan = 0;

            Moves = MoveCollection.GetWillekeurigeMoves();
            KledingKleur = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        public int Move()
        {
            int behaaldePunten = 0;
            if (rnd.Next(0,3) == 0 && Moves.Count > 0)
            {
                move = Moves[rnd.Next(0, Moves.Count)];
                behaaldePunten += move.Move();
            }
            else
            {
                move = null;
            }
            Score += behaaldePunten;

            return behaaldePunten;
        }
    }
}
