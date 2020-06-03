using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGame_Admin
{
    public class User : Bidder
    {
        public int IdUser { get; set; }
        public string NameUser { get; set; }
        public Statistical Statistics { get; set; }
        public List<Product> ProductsEarned { get; set; }
        public List<Family> FamiliesEarned { get; set; }



        public User()
        {

            Statistics = new Statistical();
            ProductsEarned = new List<Product>();
            FamiliesEarned = new List<Family>();
        }

        public static User GetUserById(int idUser)
        {
            var user = new User();
            var query = $"SELECT * FROM users_view WHERE idUser = {idUser}";
            var userDt = DbConnection.consultar_datos(query);
            if(userDt != null)
            {
                user.IdUser = (int)userDt.Rows[0][0];
                user.IdBidder = (int)userDt.Rows[0][1];
                user.NameUser = (string)userDt.Rows[0][2];
                user.Wallet = (decimal)userDt.Rows[0][3];
                user.Statistics.IdStatistical = (int)userDt.Rows[0][4];
            }

            return user;
        }

        public static List<User> GetUsers()
        {
            var users = new List<User>();

            return users;
        }
        public static List<User> GetUsers(string query)
        {
            var users = new List<User>();


            if (string.IsNullOrEmpty(query))
                query = "SELECT * FROM users_view";
            var usersDt = DbConnection.consultar_datos(query);
            if (usersDt == null) return null;
            foreach (DataRow row in usersDt.Rows)
            {
                var user = new User
                {
                    IdUser = (int) row[0],
                    IdBidder = (int) row[1],
                    NameUser = (string) row[2],
                    Wallet = (decimal) row[3],
                    Statistics = {IdStatistical = (int) row[4]}
                };
                users.Add(user);
            }

            return users;

        }

        public void UpdateParticipation(decimal lastBid, decimal newBid)
        {
            Offert = newBid;
            var increase = newBid - lastBid;

            var timeBetweenBidd = DateTime.Now - LastBiddTime;
            LastBiddTime = DateTime.Now;
            var secondsBetweenBidd = timeBetweenBidd.Seconds;

            UpdateParticipation();
            if (Rounds == 1 && ParticipationsRound == 1)//Si el jugador participó en el primer round
                Statistics.ParicipatedAuctions++;//Incrementa el contador de las subastas en las que participó
            Statistics.AddIncreaseForBid(increase);//Agrega el incremento a las estadísticas
            Statistics.AddSecondsBetweenBid(secondsBetweenBidd);//Agrega los segundos entre ofertas a las estadísticas
        }

    }
}
