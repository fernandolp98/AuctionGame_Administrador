using System.Collections.Generic;

namespace AuctionGame_Admin
{
    public class Statistical
    {
        public int IdStatistical { get; set; }

        private readonly List<int> _roundsByAuction;
        private readonly List<int> _bidByRound;
        private readonly List<int> _secondsBetweenBid;
        private readonly List<int> _increaseForBid;


        public int TotalAuctions { get; set; }
        public int AuctionsWon { get; set; }
        public int ParicipatedAuctions { get; set; }
        public double Points { get; set; }

        public Statistical()
        {
            _roundsByAuction = new List<int>();
            _bidByRound = new List<int>();
            _secondsBetweenBid = new List<int>();
            _increaseForBid = new List<int>();
        }

        public decimal Mean(List<int> list)
        {
            var mean = (decimal)0.00;
            foreach (var n in list)
            {
                mean += n;
            }

            mean /= list.Count;
            return mean;
        }
        public void AddRoundsForAuction(int rounds)
        {
            this._roundsByAuction.Add(rounds);
        }
        public void AddBidByRound(int bidds)
        
        {
            if(bidds > 0)
                this._bidByRound.Add(bidds);
        }
        public void AddSecondsBetweenBid(int seconds)
        {
            this._secondsBetweenBid.Add(seconds);
        }
        public void AddIncreaseForBid(decimal increase)
        {
            this._increaseForBid.Add((int)increase);
        }

        public void Results(decimal wallet)
        {
            var roundsForBidd = Mean(_roundsByAuction);
            var biddForRound = Mean(_bidByRound);
            var secondsBetweenBidd = Mean(_secondsBetweenBid);
            var increaseForBidd = Mean(_increaseForBid);
            var query = $"UPDATE statistical_data SET " +
                           $"roundsForBid = {roundsForBidd}, " +
                           $"biddForRound={biddForRound}, " +
                           $"totalAuctions={TotalAuctions}, " +
                           $"participatedAuctions={ParicipatedAuctions}, " +
                           $"auctionsWon={AuctionsWon}, " +
                           $"finalWallet={wallet}, " +
                           $"points={Points}, " +
                           $"secondsBetweenBidd={secondsBetweenBidd}, " +
                           $"increaseForBidd={increaseForBidd} " +
                           $"WHERE idSTATISCAL = {IdStatistical}";
            DbConnection.ejecutar(query);
        }
    }
}
