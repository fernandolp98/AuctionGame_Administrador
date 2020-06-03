using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public partial class ChildMainProducts : Form
    {
        private readonly DataControl _dataControl = new DataControl(Fonts.FontPlaceHolder, Fonts.FontRegular, Color.Silver, Color.Black, Color.Red);
        public ChildMainProducts()
        {
            InitializeComponent();
        }

        public void UpdateProducts(string query)
        {
            if (string.IsNullOrEmpty(query))
                query = "SELECT * FROM products_view";
            var products = DbConnection.consultar_datos(query); //Obtiene una consulta de los productos de la base de datos
            dgvProducts.Rows.Clear();//Limpia las filas de la tabla producto
            if (products == null) return;
            var bProducts = int.TryParse(dgvProducts.Tag.ToString(), out var currentIdProduct);

            foreach (DataRow row in products.Rows)//Agrega todas las filas de la consulta a la tabla
            {


                dgvProducts.Rows.Add((int)row[0], row[1], (decimal)row[2], (int)row[3], $@"{row[4]}");
                var currentRow = dgvProducts.Rows[dgvProducts.Rows.Count - 1];
                if (!bProducts || currentIdProduct == -1) continue;
                if (currentIdProduct == int.Parse(currentRow.Cells[0].Value.ToString()))
                    currentRow.Selected = true;
            }
        }
        private bool Question(string question, string caption)
        {
            return MessageBox.Show(question, caption, MessageBoxButtons.YesNoCancel) == DialogResult.Yes;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var row = dgvProducts.CurrentRow; //Obtiene la fila seleccionada
            if (row == null || row.Index == -1) return;
            var currentIdproduct = int.Parse(row.Cells[0].Value.ToString());
            var currentNameProduct = row.Cells[1].Value.ToString();


            if (!Question($@"¿Está seguro de eliminar el producto {currentNameProduct} ({currentIdproduct})?",
                @"Estás a punto de eliminar un producto")) return;
            var query = $"CALL procedure_delete_product{currentIdproduct}"; //Query  para eliminar producto seleccionado
            if (DbConnection.ejecutar(query))//Ejecuta el query en la base de datos
            {
                MessageBox.Show(@"Se eliminó correctamente");
                UpdateProducts("");
            }
            else
            {
                MessageBox.Show(@"Ocurrió un error al eliminar el producto");
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvProducts.Rows[e.RowIndex].Selected)
                dgvProducts.Tag = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvProducts.CurrentRow; //Obtiene la fila seleccionada

            if (row == null || row.Index == -1 || e.RowIndex == -1) return;

            //Obtiene los datos de la fila seleccioanda y la convierte a objeto de PRODUCTO
            var idProduct = int.Parse(row.Cells[0].Value.ToString());
            var nameProduct = row.Cells[1].Value.ToString();
            var initialPrice = decimal.Parse(row.Cells[2].Value.ToString());
            var pointsValue = int.Parse(row.Cells[3].Value.ToString());
            var image = DataControl.Base64StringToImage(row.Cells[4].Value.ToString());

            var product = new Product
            {
                IdProduct = idProduct,
                Name = nameProduct,
                StartingPrice = initialPrice,
                Points = pointsValue,
                ImageProduct = image
            };

            var form = new FrmProduct(product, this);//Instancia un nuevo formulario para agregar productos
            form.Show();//Abre el formulario
        }

        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            var option = cboSearchProducts.SelectedIndex;
            var query = "SELECT * FROM products_view";
            switch (option)
            {
                case 1:
                    query += $" WHERE products_view.id_product = {txbSearchProducts.Text}";
                    break;
                case 2:
                    query += $" WHERE products_view.name_product LIKE '{txbSearchProducts.Text}%'";
                    break;
                case 3:
                    query += $" WHERE products_view.starting_price = {txbSearchProducts.Text}";
                    break;
                case 4:
                    query += $" WHERE products_view.points_product = {txbSearchProducts.Text}";
                    break;
            }

            UpdateProducts(query);
        }

        private void txbSearchProducts_Enter(object sender, EventArgs e)
        {
            _dataControl.PlaceHolder_Enter((TextBox)sender);
        }

        private void txbSearchProducts_Leave(object sender, EventArgs e)
        {
            _dataControl.placeHolder_Leave((TextBox)sender);

        }

    }
}
