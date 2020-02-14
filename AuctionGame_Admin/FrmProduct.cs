using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public partial class FrmProduct : Form
    {
        private readonly Product _product;
        private readonly bool _edit;
        private readonly ChildMainProducts _father;
        public FrmProduct(ChildMainProducts father)
        {
            InitializeComponent();
            _edit = false;
            _father = father;

        }
        public FrmProduct()
        {
            InitializeComponent();
            _edit = false;
        }
        public FrmProduct(Product product, ChildMainProducts father)
        {
            InitializeComponent();
            _product = product;
            _edit = true;
            _father = father;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            if (_product != null)
            {
                LoadProduct();
            }
        }

        private void LoadProduct()
        {
            DataControl.Text(txbIdProduct, _product.IdProduct.ToString());
            DataControl.Text(txbNameProduct, _product.Name);
            DataControl.Text(txbInitialPrice, _product.Price.ToString(CultureInfo.InvariantCulture));
            DataControl.Text(txbPointsValue, _product.Points.ToString(CultureInfo.InvariantCulture));
            pboxProducto.Image = _product.ImageProduct;
        }

        protected virtual bool Question(string question, string caption)
        {
            return MessageBox.Show(question, caption, MessageBoxButtons.YesNoCancel) == DialogResult.Yes;
        }

        private void Txb_Enter(object sender, EventArgs e)
        {
            DataControl.PlaceHolder_Enter((TextBox)sender);
        }

        private void Txb_Leave(object sender, EventArgs e)
        {
            DataControl.placeHolder_Leave((TextBox)sender);
        }


        private void Txb_Validated(object sender, EventArgs e)
        {
            try
            {
                var txb = (TextBox)sender;
                DataControl.Validar(txb);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private bool ValidData()
        {
            var textboxes = new object[] { txbIdProduct, txbInitialPrice, txbNameProduct, txbPointsValue };
            return DataControl.Validar(textboxes);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidData()) //Valida Datos
            {
                var newIdProduct = txbIdProduct.Text;
                var newNameProduct = txbNameProduct.Text;
                var newInitialPrice = txbInitialPrice.Text;
                var newPointsValue = txbPointsValue.Text;
                var newImageB64 = DataControl.ImageToBase64String(pboxProducto.Image);

                if (!_edit) //Si no va a editar un producto ya existente
                {
                    if (DbConnection.existencia($@"SELECT * FROM product WHERE idProduct = {newIdProduct} LIMIT 1", 1))
                    {
                        MessageBox.Show(@"El código introducido ya existe.");
                        return;
                    }
                    var query =
                        $"INSERT INTO product (idProduct, nameProduct, startinPrice, points, pathImage) " +
                        $"VALUES (" +
                        $"{newIdProduct}," +
                        $"'{newNameProduct}'," +
                        $"{newInitialPrice}, " +
                        $"{newPointsValue}, " +
                        $"'{newImageB64}')";
                    if (DbConnection.ejecutar(query)) //Si se ejecuta la consulta en la base de datos correctamente
                    {
                        _father?.UpdateProducts("");
                        if (MessageBox.Show(@"¡Se ha registrado el producto exitosamente! ¿Desea agregar otro?",
                                @"Producto agregado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                            DialogResult.Yes)
                        {

                            txbIdProduct.Clear();
                            txbNameProduct.Clear();
                            txbInitialPrice.Clear();
                            txbPointsValue.Clear();
                            pboxProducto.Image = Image.FromFile("../../Resources/no-foto.png");
                        }
                        else
                        {

                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Ocurrió un problema al registrar el producto.");
                    }
                }
                else if (_edit) //Si va a editar un producto ya existente
                {
                    if (DbConnection.existencia($@"SELECT * FROM product WHERE idProduct = {newIdProduct} LIMIT 2", 2))
                    {
                        MessageBox.Show(@"El código introducido ya existe.");
                        return;
                    }
                    var query =
                        $"UPDATE product set " +
                        $"idProduct = {newIdProduct}, " +
                        $"nameProduct = '{newNameProduct}', " +
                        $"startinPrice = {newInitialPrice}, " +
                        $"points = {newPointsValue}, " +
                        $"pathImage = '{newImageB64}' " +
                        $"WHERE idProduct = {_product.IdProduct}";
                    if (DbConnection.ejecutar(query)) //Si se ejecuta la consulta en la base de datos correctamente
                    {
                        _father?.UpdateProducts("");
                        if (!Question(@"¡Se ha modificado el producto exitosamente! ¿Desea Salir?",
                            @"Producto Modificado")) return;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(@"Ocurrió un problema modificando el producto.");
                    }
                }

            }
            else
            {
                MessageBox.Show(@"Existe un error en el formulario.");
            }
        }

        private void btnPatchImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                ofd.Filter = @"Archivos de Imagen (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (Image img = Image.FromFile(ofd.FileName))
                    {
                        pboxProducto.Image = (Image)img.Clone();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Question("¿Realmente desea salir?", "Está a punto de salir"))
                this.Close();
        }
    }
}
