using System;
using System.Collections.Generic;
using System.Text;

namespace ApplocationCore.Entities.Match
{
    public class TennisMatch : BaseEntity
    {

        public List<TennisSet> TennisSets { get; set; }
        public List<TennisPlayer> TennisPlayers { get; set; }

        public TennisMatch(string name1, string name2)
        {
            TennisPlayers = new List<TennisPlayer> { new TennisPlayer(0, name1),
                                                     new TennisPlayer(1, name2) };
            TennisSets = new List<TennisSet> { new TennisSet(), new TennisSet() };
        }

        public void playMatch() { 
            foreach(var set in TennisSets)
            {
                set.playSet();
            }
            // if a player hasn't won in the 2 first sets, play a third one
            var minSetsToWinMatch = 2;
            if (TennisSets.FindAll(set => set.getWinner() == 0).Count < minSetsToWinMatch &&
                TennisSets.FindAll(set => set.getWinner() == 1).Count < minSetsToWinMatch)
            {
                TennisSets.Add(new TennisSet());
                TennisSets[TennisSets.Count - 1].playSet();
            }
        }

        public int getWinner()
        {
            var winnerId = -1;
            {            
                // if a player hasn't won in the 2 first sets, play a third one
                var minSetsToWinMatch = 2;
                var player0WonSets = TennisSets.FindAll(set => set.getWinner() == 0).Count;
                var player1WonSets = TennisSets.FindAll(set => set.getWinner() == 1).Count;
                if (player0WonSets == minSetsToWinMatch || player1WonSets == minSetsToWinMatch)
                {
                    winnerId = player0WonSets == minSetsToWinMatch ? 0 : 1;
                }
            }
            return winnerId;
        }
    }


}
