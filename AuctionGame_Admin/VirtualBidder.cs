using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace AuctionGame_Admin
{
    public class VirtualBidder : Bidder
    {
        public int IdVirtualBidder { get; set; }
        public  Role Role { get; set; }
        public string DescriptionBidder { get; set; }

        public Thread Hilo;
        public VirtualBidder()
        {

        }
        public bool WantToBid(int ultimateOffert, int winner, int round)
        {
            if (winner == IdBidder) return false;//Si el ganador actual esél mismo, no puja
            if (OutBidder) return false;//Si está fuera de la apuesta, no puja
            if (Role.Rounds.FinallyValue > round) return false;//Si su límite de rounds es mayor al actual, no puja
            if (Role.OffertsForRound.FinallyValue > ParticipationsRound) return false;//Si su límite de ofertas por round es mayor a las participaciones que ha hecho, no puja
            if (ultimateOffert + Role.BidIncrease.GetNewFinallyValue() > Wallet) return false;//Si lo que desea ofertar es mayor a su dinero disponible, no puja

            Offert = ultimateOffert + Role.BidIncrease.FinallyValue;
            UpdateParticipation();//Incrementa sus participaciones
            return true;//Puja
        }

        public static List<VirtualBidder> GetAllVirtualBidders(string query)
        {
            if(string.IsNullOrEmpty(query))
                query = "SELECT * FROM virtual_bidders_view";
            var virtualBidders = new List<VirtualBidder>();
            var virtualBiddersDt = DbConnection.consultar_datos(query);
            if (virtualBiddersDt == null) return null;
            foreach (DataRow row in virtualBiddersDt.Rows)
            {
                var virtualBidder = new VirtualBidder()
                {
                    IdVirtualBidder = (int)row[0],
                    IdBidder = (int)row[1],
                    NameBidder = (string)row[2],
                    DescriptionBidder = (string)row[3],
                    Wallet = (decimal)row[4],
                    Role = new Role((int)row[5])
                };
                virtualBidders.Add(virtualBidder);
            }
            return virtualBidders;
        }

        public static List<VirtualBidder> GetVirtualBiddersByRoutine(int idRoutine)
        {
            var virtualBidders = new List<VirtualBidder>();
            var query = "SELECT virtual_bidder.*, bidder.nameBidder, bidder.wallet FROM routine_has_virtual_bidder " +
                           "INNER JOIN virtual_bidder " +
                           "ON virtual_bidder.IdVirtualBidd = routine_has_virtual_bidder.VIRTUAL_BIDDER_idVIrtualBidder " +
                           "INNER JOIN bidder on virtual_bidder.BIDDER_idBidd = bidder.idBidd " +
                           $"WHERE routine_has_virtual_bidder.ROUTINE_idRoutine = {idRoutine}";
            var virtualBiddersDt = DbConnection.consultar_datos(query);

            if (virtualBiddersDt == null) return null;
            foreach (DataRow row in virtualBiddersDt.Rows)
            {
                var virtualBidder = new VirtualBidder()
                {
                    IdVirtualBidder = (int)row[0],
                    IdBidder = (int)row[1],
                    NameBidder = (string)row[2],
                    DescriptionBidder = (string)row[3],
                    Wallet = (decimal)row[4],
                    Role = new Role((int)row[5])
                }; virtualBidders.Add(virtualBidder);
            }
            return virtualBidders;
        }

        public static VirtualBidder GetVirtualBidderById(int idVirtualBidder)
        {
            var query = $"SELECT * FROM virtual_bidders_view WHERE idVirtualBidder = {idVirtualBidder}";
            var virtualBiddersDt = DbConnection.consultar_datos(query);
            if (virtualBiddersDt == null) return null;
            var row = virtualBiddersDt.Rows[0];
            var virtualBidder = new VirtualBidder()
            {
                IdVirtualBidder = (int)row[0], 
                IdBidder = (int)row[1], 
                NameBidder = (string)row[2], 
                DescriptionBidder = (string)row[3],
                Wallet = (decimal)row[4],
                Role = new Role((int)row[5])
            };
            return virtualBidder;
        }
    }
}
