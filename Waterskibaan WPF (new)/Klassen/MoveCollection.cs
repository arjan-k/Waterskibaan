using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Waterskibaan_WPF__new_.Klassen
{
    public static class MoveCollection
    {
        public static List<IMoves> GetWillekeurigeMoves()
        {
            List<IMoves> allMoves = new List<IMoves>();
            allMoves.AddRange(new List<IMoves>
            {
                new EenBeen(),
                new EenHand(),
                new Salto(),
                new Sprong()
            }) ;

            Random rnd = new Random();
            List<IMoves> rndMoves = allMoves.OrderBy(x => rnd.Next(1, allMoves.Count()))
                .Take(rnd.Next(1, allMoves.Count()))
                .ToList();

            return rndMoves;
        }
    }
}
