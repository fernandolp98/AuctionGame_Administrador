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

namespace AuctionGame_Aministrador
{
    public partial class FrmFamily : Form
    {
        private Family _family;
        private bool _edit;
        private readonly ChildMainFamily _father;
        private readonly List<int> _productRegistered;//Productos ya registrados en la familia
        private readonly List<int> _productsAvailable;//Productos por registrar en la familia
        private readonly List<int> _newProducts;//Nuevos productos (de los disponibles) agregados
        private readonly List<int> _deletedProducts;//Productos de los registrados a eliminar


        public FrmFamily(ChildMainFamily f)
        {
            InitializeComponent();
            _edit = false;
            this._father = f;
            _productRegistered = new List<int>();
            _productsAvailable = new List<int>();
            _newProducts = new List<int>();
            _deletedProducts = new List<int>();
        }
        public FrmFamily(Family f, ChildMainFamily faher)
        {
            InitializeComponent();
            _family = f;
            _edit = true;
            this._father = faher;
            _newProducts = new List<int>();
            _deletedProducts = new List<int>();
            _productRegistered = new List<int>();
            _productsAvailable = new List<int>();
            _newProducts = new List<int>();
            _deletedProducts = new List<int>();
        }
        private void FormFamily_Load(object sender, EventArgs e)
        {
            if (_family != null)
            {
                LoadFamily();
                UpdateAvailableProducts();
                UpdateRegisteredProducts();
            }
            else
            {
                UpdateAvailableProductsAll();
            }
        }

        private void LoadFamily()
        {
            DataControl.Text(txbNameFamily, _family.NameFamily);
            DataControl.Text(txbPointsValue, _family.Points.ToString(CultureInfo.CurrentCulture));

        }

        private void UpdateAvailableProductsAll()
        {
            var productsAvailable = Product.GetAllProducts();
            foreach (var product in productsAvailable)
            {
                dgvAvailableProducts.Rows.Add(product.IdProduct, product.Name);
                _productsAvailable.Add(product.IdProduct);
            }
        }
        private void UpdateAvailableProducts()
        {
            var productsAvailable = _family.GetAvailableProducts();
            foreach (var product in productsAvailable)
            {
                dgvAvailableProducts.Rows.Add(product.IdProduct, product.Name);
                _productsAvailable.Add(product.IdProduct);
            }
        }
        private void UpdateRegisteredProducts()
        {
            var productRegistered = _family.GetRegisteredProducts();
            foreach (var product in productRegistered)
            {
                dgvRegisteredProducts.Rows.Add(product.IdProduct, product.Name);
                _productRegistered.Add(product.IdProduct);
            }
        }

        private bool Question(string question, string caption)
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
                var txbTag = (string)txb.Tag;
                var type = txbTag.Split(',')[1];
                DataControl.Validar(txb, type);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
        private bool ValidData()
        {
            var textboxes = new object[] { txbNameFamily, txbPointsValue };
            return DataControl.Validar(textboxes);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidData()) //Valida Datos
            {
                var newNameFamily = txbNameFamily.Text;
                var newPointsValue = txbPointsValue.Text;

                if (!_edit) //Si no va a editar un producto ya existente
                {
                    var query =
                        $"SELECT insert_family('{newNameFamily}', {newPointsValue})";
                    var idFamilyDt = DB_CONNECTION.consultar_datos(query);
                    if (idFamilyDt != null) //Si se ejecuta la consulta en la base de datos correctamente
                    {
                        _family = Family.GetFamilyById(int.Parse(idFamilyDt.Rows[0][0].ToString()));
                        AddNewProducts();
                        _father?.UpdateFamilies("");
                        if (Question(@"¡Se ha registrado la familia exitosamente! ¿Desea agregar otra?", @"Familia agregada"))
                        {

                            txbNameFamily.Clear();
                            txbPointsValue.Clear();
                        }
                        else
                        {
                            _edit = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Ocurrió un problema al registrar la familia.");
                    }
                }
                else if (_edit) //Si va a editar un producto ya existente
                {
                    var query =
                        $"UPDATE family set " +
                        $"nameFamily = '{newNameFamily}', " +
                        $"points = {newPointsValue} " +
                        $"WHERE idFamily = {_family.IdFamily}";
                    if (DB_CONNECTION.ejecutar(query)) //Si se ejecuta la consulta en la base de datos correctamente
                    {
                        var added = AddNewProducts();
                        var removed = RemoveOldProduct();
                        _father?.UpdateFamilies("");
                        if (!Question($"¡Se ha modificado la familia exitosamente!\nProductos Agregados: {added}\nProductos Eliminados: {removed}\n¿Desea Salir?",
                            @"Familia Modificada")) return;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(@"Ocurrió un problema modificando la familia.");
                    }
                }

            }
            else
            {
                MessageBox.Show(@"Existe un error en el formulario.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Question("¿Realmente desea salir?", "Está a punto de salir"))
                this.Close();
        }

        private int AddNewProducts()
        {
            var counter = 0;
            var index = 0;
            while (_newProducts.Count > index)
            {
                var idProduct = _newProducts[index];
                var query = $"INSERT INTO family_has_product (FAMILY_idFamily, PRODUCT_idProduct) VALUES ({_family.IdFamily}, {idProduct})";
                if (DB_CONNECTION.ejecutar(query))
                {
                    _newProducts.Remove(idProduct);
                    _productRegistered.Add(idProduct);
                    _productsAvailable.Remove(idProduct);
                    counter++;
                }
                else
                {
                    MessageBox.Show(@"Ocurrió un error agregando un producto");
                    index++;
                }
            }
            return counter;
        }

        private int RemoveOldProduct()
        {
            var counter = 0;
            var index = 0;
            while (_deletedProducts.Count > index)
            {
                var idProduct = _deletedProducts[index];
                var query = $"DELETE FROM family_has_product WHERE FAMILY_idFamily = {_family.IdFamily} AND PRODUCT_idProduct = {idProduct}";
                if (DB_CONNECTION.ejecutar(query))
                {
                    _deletedProducts.Remove(idProduct);
                    _productsAvailable.Add(idProduct);
                    _productRegistered.Remove(idProduct);
                    counter++;
                }
                else
                {
                    MessageBox.Show(@"Ocurrió un error eliminando un producto");
                    index++;
                }
            }

            return counter;
        }

        private void AvailableToRegistered()
        {
            var rows = dgvAvailableProducts.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                var id = (int)row.Cells[0].Value;
                if (_productsAvailable.Contains(id))
                    _newProducts.Add(id);
                if (_productRegistered.Contains(id))
                    _deletedProducts.Remove(id);

                dgvAvailableProducts.Rows.Remove(row);
                dgvRegisteredProducts.Rows.Add(row);
            }
        }
        private void RegisteredToAvailable()
        {
            var rows = dgvRegisteredProducts.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                var id = (int)row.Cells[0].Value;
                if (_productRegistered.Contains(id))
                    _deletedProducts.Add(id);
                if (_productsAvailable.Contains(id))
                    _newProducts.Remove(id);

                dgvRegisteredProducts.Rows.Remove(row);
                dgvAvailableProducts.Rows.Add(row);
            }
        }

        private void dgvAvailableProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                AvailableToRegistered();
        }

        private void pBoxAddProduct_Click(object sender, EventArgs e)
        {
            AvailableToRegistered();
        }

        private void dgvRegisteredProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                RegisteredToAvailable();
        }

        private void pBoxDeleteProduct_Click(object sender, EventArgs e)
        {
            RegisteredToAvailable();
        }

    }
}
