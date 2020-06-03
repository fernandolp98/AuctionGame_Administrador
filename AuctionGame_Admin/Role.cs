using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public class Role
    {
        public int IdRole { get; set; }
        public string NameRole { get; }
        public string DescriptionRole { get; }
        public TimesValues TimeToBid { get; }//tiempo para la primer oferta
        public BetwenValues OffertsForRound { get; }//numero de apuestas que puede hacer en cada ronda
        public BetwenValues Rounds { get; }//numero de rondas en las que puede participar en cada subasta
        public BetwenValues BidIncrease { get; }//valor que puede incrementar en su oferta

        public Role(string nameRole, string descriptionRole, TimesValues timeToBid, BetwenValues offertsForRound, BetwenValues rounds, BetwenValues bidIncrease)
        {
            IdRole = -1;
            NameRole = nameRole;
            DescriptionRole = descriptionRole;
            TimeToBid = timeToBid;
            OffertsForRound = offertsForRound;
            Rounds = rounds;
            BidIncrease = bidIncrease;

        }
        public Role(int roleId)
        {
            var values = DbConnection.consultar_datos($"SELECT * FROM role WHERE id_role = {roleId}");
            if (values != null)
            {
                this.IdRole = roleId;
                this.NameRole = NameRole = values.Rows[0][1].ToString();
                this.DescriptionRole = values.Rows[0][2].ToString();

                var timeToBidDown = int.Parse(values.Rows[0][3].ToString());
                var timeToBidTop = int.Parse(values.Rows[0][4].ToString());

                var offersForRoundDown = int.Parse(values.Rows[0][5].ToString());
                var offersForRoundTop = int.Parse(values.Rows[0][6].ToString());

                var roundsDown = int.Parse(values.Rows[0][7].ToString());
                var roundsTop = int.Parse(values.Rows[0][8].ToString());

                var bidIncreaseDown = int.Parse(values.Rows[0][9].ToString());
                var bidIncreaseTop = int.Parse(values.Rows[0][10].ToString());

                this.TimeToBid = new TimesValues(timeToBidDown, timeToBidTop);
                this.OffertsForRound = new BetwenValues(offersForRoundDown, offersForRoundTop);
                this.Rounds = new BetwenValues(roundsDown, roundsTop);
                this.BidIncrease = new BetwenValues(bidIncreaseDown, bidIncreaseTop);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show($@"Ocurrió un error al establecer los valores para el rol {roleId}");
            }
        }
        public static List<Role> GetAllRoles()
        {
            var roles = new List<Role>();
            var query = "SELECT id_role FROM role";
            var consult = DbConnection.consultar_datos(query);
            if (consult == null) return roles;
            foreach (DataRow row in consult.Rows)
            {
                var id = (int)row[0];

                var role = new Role(id);
                roles.Add(role);
            }
            return roles;
        }

        public bool Insertar()
        {
            var query = $"SELECT function_insert_role(" +
                        $"'{NameRole}'," +
                        $"'{DescriptionRole}'," +
                        $"{TimeToBid.TimeDownSeconds}," +
                        $"{TimeToBid.TimeTopSeconds}, " +
                        $"{OffertsForRound.DownValue}, " +
                        $"{OffertsForRound.TopValue}, " +
                        $"{Rounds.DownValue}, " +
                        $"{Rounds.TopValue}, " +
                        $"{BidIncrease.DownValue}, " +
                        $"{BidIncrease.TopValue})";
            var roleIdDt = DbConnection.consultar_datos(query);
            if (roleIdDt == null) return false;
            IdRole = int.Parse(roleIdDt.Rows[0][0].ToString());
            return true;
        }

        public bool Update()
        {
            var query = $"CALL procedure_update_role(" +
                        $"{IdRole} ," +
                        $"'{NameRole}'," +
                        $"'{DescriptionRole}'," +
                        $"{TimeToBid.TimeDownSeconds}," +
                        $"{TimeToBid.TimeTopSeconds}, " +
                        $"{OffertsForRound.DownValue}, " +
                        $"{OffertsForRound.TopValue}, " +
                        $"{Rounds.DownValue}, " +
                        $"{Rounds.TopValue}, " +
                        $"{BidIncrease.DownValue}, " +
                        $"{BidIncrease.TopValue})";
            return DbConnection.ejecutar(query);
        }
    }
}
