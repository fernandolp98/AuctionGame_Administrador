using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGame_Admin
{
    [Serializable]
    public class Routine
    {
        public int IdRoutine { get; set; }
        public string NameRoutine { get; set; }
        public string DescriptionRoutine { get; set; }
        public List<Family> Families { get; set; }
        public List<Product> SingleProducts { get; set; }
        public List<Product> ProductsByFamily { get; set; }
        public List<Product> AllProducts { get; set; }
        public List<VirtualPlayer> virtualPlayers { get; set; }

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
            routine.Families = routine.GetFamilies();
            routine.SingleProducts = routine.GetSingleProducts();
            routine.ProductsByFamily = routine.GetProductsByFamily();
            routine.AllProducts = routine.GetAllProducts();
            routine.virtualPlayers = routine.GetvirtualPlayers();
            return routine;
        }
        public static List<Routine> GetAllRoutines()
        {
            var routines = new List<Routine>();
            var query = $"SELECT idRoutine, nameRoutine, descriptionRoutine FROM routine";
            var routineDt = DbConnection.consultar_datos(query);
            foreach(DataRow row in routineDt.Rows)
            {
                var routine = new Routine();
                routine.IdRoutine = (int)row[0];
                routine.NameRoutine = (string)row[1];
                routine.DescriptionRoutine = (string)row[2];
                routine.Families = routine.GetFamilies();
                routine.SingleProducts = routine.GetSingleProducts();
                routine.ProductsByFamily = routine.GetProductsByFamily();
                routine.AllProducts = routine.GetAllProducts();
                routine.virtualPlayers = routine.GetvirtualPlayers();
                routines.Add(routine);
            }
            return routines;
        }

        public List<Family> GetFamilies()
        {
            var families = new List<Family>();
            var query = "SELECT family.* FROM routine_has_family " +
                        "LEFT JOIN family " +
                        "ON family.idFamily = routine_has_family.FAMILY_idFamily " +
                        $"WHERE routine_has_family.ROUTINE_idRoutine = {IdRoutine}";
            var familiesDataTable = DbConnection.consultar_datos(query);
            if (familiesDataTable == null) return families;
            for (var index = 0; index < familiesDataTable.Rows.Count; index++)
            {
                var row = familiesDataTable.Rows[index];
                var family = new Family((int) row[0], (string) row[1], (int) row[2]);
                families.Add(family);
            }

            return families;
        }

        public List<Product> GetSingleProducts()
        {
            var products = new List<Product>();
            var query = $"SELECT * FROM single_products_per_routine WHERE ROUTINE_idRoutine = {IdRoutine}";

            var consult = DbConnection.consultar_datos(query);
            if (consult == null) return products;
            for (var index = 0; index < consult.Rows.Count; index++)
            {
                var row = consult.Rows[index];
                var id = (int) row[0];
                var name = (string) row[1];
                var price = (decimal) row[2];
                var points = (int) row[3];
                var image = DataControl.Base64StringToImage((string) row[4]);


                var p = new Product(id, name, price, points, image);
                products.Add(p);
            }
            return products;
        }

        public List<Product> GetProductsByFamily()
        {
            var products = new List<Product>();
            var query = $"SELECT * FROM products_per_family_per_routine WHERE ROUTINE_idRoutine = {IdRoutine}";

            var consult = DbConnection.consultar_datos(query);
            if (consult == null) return products;
            for (var index = 0; index < consult.Rows.Count; index++)
            {
                var row = consult.Rows[index];
                var id = (int) row[0];
                var name = (string) row[1];
                var price = (decimal) row[2];
                var points = (int) row[3];
                var image = DataControl.Base64StringToImage((string) row[4]);


                var p = new Product(id, name, price, points, image);
                products.Add(p);
            }

            return products;
        }

        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();
            var query =
                $"SELECT * FROM single_products_per_routine WHERE ROUTINE_idRoutine = {IdRoutine} UNION SELECT * FROM products_per_family_per_routine WHERE ROUTINE_idRoutine = {IdRoutine}";

            var consult = DbConnection.consultar_datos(query);
            if (consult == null) return products;
            for (var index = 0; index < consult.Rows.Count; index++)
            {
                var row = consult.Rows[index];
                var id = (int) row[0];
                var name = (string) row[1];
                var price = (decimal) row[2];
                var points = (int) row[3];
                var image = DataControl.Base64StringToImage((string) row[4]);

                var p = new Product(id, name, price, points, image);
                products.Add(p);
            }

            return products;
        }

        public List<VirtualPlayer> GetvirtualPlayers()
        {
            var virtualPlayers = new List<VirtualPlayer>();
            var query = "SELECT * FROM virtual_bidders_per_routine " +
                        $"WHERE ROUTINE_idRoutine = {IdRoutine}";
            var virtualPlayersDt = DbConnection.consultar_datos(query);

            if (virtualPlayersDt == null) return virtualPlayers;
            for (var index = 0; index < virtualPlayersDt.Rows.Count; index++)
            {
                var row = virtualPlayersDt.Rows[index];
                var virtualPlayer = new VirtualPlayer()
                {
                    IdvirtualPlayer = (int)row[0],
                    IdBidder = (int)row[1],
                    NameVirtualPlayer = (string)row[2],
                    DescriptionPlayer = (string)row[3],
                    Wallet = (decimal)row[4],
                    Role = new Role((int)row[5]),
                }; 
                virtualPlayers.Add(virtualPlayer);
            }

            return virtualPlayers;
        }

        public List<Product> GetAvailableProducts()
        {
            var products = new List<Product>();
            var query = "SELECT t1.* FROM products_view t1 " +
                        "WHERE NOT EXISTS(SELECT NULL FROM routine_has_product t2 " +
                        $"WHERE t1.idProduct = t2.PRODUCT_idProduct AND t2.ROUTINE_idRoutine = {IdRoutine})";
            var consult = DbConnection.consultar_datos(query);
            if (consult == null) return products;
            for (var index = 0; index < consult.Rows.Count; index++)
            {
                var row = consult.Rows[index];
                var id = (int) row[0];
                var name = (string) row[1];
                var price = (decimal) row[2];
                var points = (int) row[3];
                var image = DataControl.Base64StringToImage((string) row[4]);

                var p = new Product(id, name, price, points, image);
                products.Add(p);
            }

            return products;
        }
        public List<Family> GetAvailableFamilies()
        {
            var families = new List<Family>();

            var query = "SELECT t1.* FROM families_view t1 " +
                        "WHERE NOT EXISTS(SELECT NULL FROM routine_has_family t2 " +
                        $"WHERE t1.idFamily = t2.FAMILY_idFamily AND t2.ROUTINE_idRoutine = {IdRoutine})";
            var consult = DbConnection.consultar_datos(query);
            if (consult == null) return families;
            for (var index = 0; index < consult.Rows.Count; index++)
            {
                var row = consult.Rows[index];
                var family = new Family((int)row[0], (string)row[1], (int)row[2]);
                families.Add(family);
            }

            return families;
        }
        public List<VirtualPlayer> GetAvailablevirtualPlayers()
        {
            var virtualPlayers = new List<VirtualPlayer>();
            var query = "SELECT t1.* FROM virtual_bidders_view t1 " +
                        "WHERE NOT EXISTS(SELECT NULL FROM routine_has_virtual_bidder t2 " +
                        $"WHERE t1.idvirtualPlayer = t2.VIRTUAL_BIDDER_idvirtualPlayer AND t2.ROUTINE_idRoutine = {IdRoutine})";
            var consult = DbConnection.consultar_datos(query);
            if (consult == null) return virtualPlayers;
            for (var index = 0; index < consult.Rows.Count; index++)
            {
                var row = consult.Rows[index];
                var virtualPlayer = new VirtualPlayer()
                {
                    IdvirtualPlayer = (int)row[0],
                    IdBidder = (int)row[1],
                    NameVirtualPlayer = (string)row[2],
                    DescriptionPlayer = (string)row[3],
                    Wallet = (decimal)row[4],
                    Role = new Role((int)row[5]),
                }; 
                virtualPlayers.Add(virtualPlayer);
            }

            return virtualPlayers;
        }
    }
}
