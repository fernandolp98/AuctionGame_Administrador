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


        public int BidTotal { get; set; }
        public int BidWin { get; set; }
        public double Points { get; set; }
        public decimal Wallet { get; set; }
        public string Log { get; set; }




        public Statistical()
        {
            _roundsByAuction = new List<int>();
            _bidByRound = new List<int>();
            _secondsBetweenBid = new List<int>();
            _increaseForBid = new List<int>();

        }

        public double Mean(List<int> list)
        {
            var mean = 0.0;
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

        public void Results()
        {
            var roundsForBidd = (int)Mean(_roundsByAuction);
            var biddForRound = (int)Mean(_bidByRound);
            var secondsBetweenBidd = (int)Mean(_secondsBetweenBid);
            var increaseForBidd = (int)Mean(_increaseForBid);

            var query = $"UPDATE statistical_data SET " +
                           $"roundsForBid = {roundsForBidd}, " +
                           $"biddForRound={biddForRound}, " +
                           $"totalBid={BidTotal}, " +
                           $"bidWin={BidWin}, " +
                           $"secondsBetweenBidd={secondsBetweenBidd}, " +
                           $"increaseForBidd={increaseForBidd}, " +
                           $"points={Points}, " +
                           $"log = '{Log}'" +
                           $"WHERE idSTATISCAL = {IdStatistical}";
            DbConnection.ejecutar(query);
        }
    }
}
