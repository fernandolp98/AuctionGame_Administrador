using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace AuctionGame_Admin
{ 
    public class Product : IEquatable<Product>
    {
        public int IdProduct;
        public string Name { get; set; }
        public decimal StartingPrice { get; set; }
        public int Points { get; set; }

        public Image ImageProduct { get; set; }

        public Product()
        {

        }
        public Product(int id, string name, decimal startingPrice, int points, Image image)
        {
            this.IdProduct = id;
            this.Name = name;
            this.StartingPrice = startingPrice;
            this.Points = points;
            this.ImageProduct = image;
        }
        public bool Equals(Product product)
        {
            if (ReferenceEquals(this, product)) return true;

            return product != null && (this.IdProduct.CompareTo(product.IdProduct) == 0 && this.Name.Equals(product.Name));
        }


        public static Product GetProductById(int idProduct)
        {
            var product = new Product();
            var query = $"SELECT * FROM products_view WHERE id_product = {idProduct}";
            var productDataTable = DbConnection.consultar_datos(query);
            if (productDataTable == null) return null;
            foreach (DataRow row in productDataTable.Rows)
            {
                var image = DataControl.Base64StringToImage((string) row[4]);
                product = new Product((int)row[0], (string)row[1], (decimal)row[2], (int)row[3], image);
                    
            }
            return product;
        }
        public static List<Product> GetAllProducts()
        {
            var products = new List<Product>();
            var query = "SELECT * FROM products_view";
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

        public bool Insert()
        {
            var b64Image = DataControl.ImageToBase64String(this.ImageProduct);
            var query =
                $"CALL procedure_insert_product({IdProduct}, '{Name}', {StartingPrice}, {Points}, '{b64Image}')";
            return DbConnection.ejecutar(query);
        }

        public bool Update()
        {
            var b64Image = DataControl.ImageToBase64String(this.ImageProduct);
            var query = $"CALL procedure_update_product({IdProduct}, '{Name}', {StartingPrice}, {Points}, '{b64Image}')";
            return DbConnection.ejecutar(query);
        }
    }
}
