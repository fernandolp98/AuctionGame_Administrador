using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace AuctionGame_Admin
{
    public class VirtualPlayer : Bidder
    {
        public int IdvirtualPlayer { get; set; }
        public string NameVirtualPlayer { get; set; }
        public  Role Role { get; set; }
        public string DescriptionPlayer { get; set; }

        public Thread Hilo;

        public bool WantToBid(decimal ultimateOffert, int winner, int round)
        {
            if (winner == IdBidder) return false;//Si el ganador actual esél mismo, no puja
            if (OutBidder) return false;//Si está fuera de la apuesta, no puja
            if (Role.Rounds.FinallyValue < round) return false;//Si su límite de rounds es mayor al actual, no puja
            if (Role.OffertsForRound.FinallyValue < ParticipationsRound) return false;//Si su límite de ofertas por round es mayor a las participaciones que ha hecho, no puja
            if (ultimateOffert + Role.BidIncrease.GetNewFinallyValue() > Wallet) return false;//Si lo que desea ofertar es mayor a su dinero disponible, no puja

            Offert = (int)ultimateOffert + Role.BidIncrease.FinallyValue;
            UpdateParticipation();//Incrementa sus participaciones
            return true;//Puja
        }

        public static List<VirtualPlayer> GetVirtualPlayers(string query)
        {
            if(string.IsNullOrEmpty(query))
                query = "SELECT * FROM virtual_players_view";
            var virtualPlayers = new List<VirtualPlayer>();
            var virtualPlayersDt = DbConnection.consultar_datos(query);
            if (virtualPlayersDt == null) return null;
            foreach (DataRow row in virtualPlayersDt.Rows)
            {
                var virtualPlayer = new VirtualPlayer()
                {
                    IdvirtualPlayer = (int)row[0],
                    NameVirtualPlayer = (string)row[1],
                    DescriptionPlayer = (string)row[2],
                    Role = new Role((int)row[3])
                };
                virtualPlayers.Add(virtualPlayer);
            }
            return virtualPlayers;
        }

        public static VirtualPlayer GetVirtualPlayerById(int idVirtualPlayer)
        {
            var query = $"SELECT * FROM virtual_players_view WHERE id_virtual_player = {idVirtualPlayer}";
            var virtualPlayersDt = DbConnection.consultar_datos(query);
            if (virtualPlayersDt == null) return null;
            var row = virtualPlayersDt.Rows[0];
            var virtualPlayer = new VirtualPlayer()
            {
                IdvirtualPlayer = (int)row[0], 
                NameVirtualPlayer = (string)row[1], 
                DescriptionPlayer = (string)row[2],
                Role = new Role((int)row[3])
            };
            return virtualPlayer;
        }

        public bool Insert()
        {
            var query =
                $"SELECT function_insert_virtual_player(" +
                $"'{NameVirtualPlayer}', " +
                $"'{DescriptionPlayer}', " +
                $"{Role.IdRole})";
            var idVirtualPlayerDt = DbConnection.consultar_datos(query);
            if (idVirtualPlayerDt == null) return false;
            IdvirtualPlayer = int.Parse(idVirtualPlayerDt.Rows[0][0].ToString());
            return true;
        }

        public bool Update()
        {
            var query =
                $"CALL procedure_update_virtual_player (" +
                $"{IdvirtualPlayer}, " +
                $"'{NameVirtualPlayer}', " +
                $"'{DescriptionPlayer}', " +
                $"{Role.IdRole})";
            return DbConnection.ejecutar(query);
        }
    }
}
