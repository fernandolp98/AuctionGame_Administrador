using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGame_Admin
{
    public class Routine
    {
        public int IdRoutine { get; set; }
        public string NameRoutine { get; set; }
        public string DescriptionRoutine { get; set; }
        public List<Family> Families { get; set; }
        public List<Product> Products { get; set; }
        public List<VirtualBidder> VirtualBidders { get; set; }





        public static Routine GetRoutineById(int idRoutine)
        {
            var routine = new Routine();
            var query = $"SELECT nameRoutine, descriptionRoutine FROM routine WHERE idRoutine = {idRoutine}";
            var routineDt = DbConnection.consultar_datos(query);
            if (routine != null)
            {
                routine.NameRoutine = routineDt.Rows[0][0].ToString();
                routine.DescriptionRoutine = routineDt.Rows[0][1].ToString();
            }
            routine.IdRoutine = idRoutine;
            routine.Families = Family.GetFamiliesByRoutine(idRoutine);
            routine.Products = Product.GetSingleProductsByRoutine(idRoutine);
            routine.VirtualBidders = VirtualBidder.GetVirtualBiddersByRoutine(idRoutine);
            return routine;
        }
    }
}
