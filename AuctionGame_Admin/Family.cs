using System.Collections.Generic;
using System.Data;

namespace AuctionGame_Admin
{
    public class Family
    {
        public int IdFamily { get; set; }
        public string NameFamily { get; set; }
        public int Points { get; set; }
        public List<Product> Products { get; set; }

        public Family()
        {
            GetProducts();
        }
        public Family(int id, string name, int points)
        {
            this.IdFamily = id;
            this.NameFamily = name;
            this.Points = points;
            GetProducts();
        }

        private void GetProducts()
        {
            Products = new List<Product>();
            var query = "SELECT product.idProduct FROM family_has_product " +
                           "LEFT JOIN product " +
                           "ON product.idProduct = family_has_product.PRODUCT_idProduct " +
                           $"WHERE family_has_product.FAMILY_idFamily = {this.IdFamily}";
            var productsDataTable = DbConnection.consultar_datos(query);
            if (productsDataTable == null) return;
            foreach (DataRow row in productsDataTable.Rows)
            {
                Products.Add(Product.GetProductById((int)row[0]));
            }
        }
        public static List<Family> GetFamiliesByRoutine(int idRoutine)
        {
            var families = new List<Family>();
            var query = "SELECT family.* FROM routine_has_family " +
                           "LEFT JOIN family " +
                           "ON family.idFamily = routine_has_family.FAMILY_idFamily " +
                           $"WHERE routine_has_family.ROUTINE_idRoutine = {idRoutine}";
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

        public static Family GetFamilyById(int id)
        {
            var query = $@"SELECT * FROM family WHERE idFamily = {id}";
            var familyDt = DbConnection.consultar_datos(query);
            if (familyDt == null) return null;
            var rowFamily = familyDt.Rows[0];
            var family = new Family()
            {
                IdFamily = int.Parse(rowFamily[0].ToString()),
                NameFamily = rowFamily[1].ToString(),
                Points = int.Parse(rowFamily[2].ToString()),
            };
            return family;
        }

        public List<Product> GetAvailableProducts()
        {
            var products = new List<Product>();
            var query = "SELECT product.idProduct FROM product " +
                            "WHERE NOT EXISTS (SELECT 1 FROM family_has_product WHERE product.idProduct = family_has_product.PRODUCT_idProduct " +
                            $"AND family_has_product.FAMILY_idFamily = {this.IdFamily}) ";
            var productsDt = DbConnection.consultar_datos(query);
            if (productsDt == null) return products;
            for (var index = 0; index < productsDt.Rows.Count; index++)
            {
                var row = productsDt.Rows[index];
                products.Add(Product.GetProductById((int)row[0]));
            }
            return products;
        }
        public List<Product> GetRegisteredProducts()
        {
            var products = new List<Product>();
            var query = "SELECT product.idProduct FROM product " +
                            "WHERE EXISTS (SELECT 1 FROM family_has_product WHERE product.idProduct = family_has_product.PRODUCT_idProduct " +
                            $"AND family_has_product.FAMILY_idFamily = {IdFamily}) ";
            var productsDt = DbConnection.consultar_datos(query);
            if (productsDt == null) return products;
            for (var index = 0; index < productsDt.Rows.Count; index++)
            {
                var row = productsDt.Rows[index];
                products.Add(Product.GetProductById((int)row[0]));
            }
            return products;
        }
    }
}
