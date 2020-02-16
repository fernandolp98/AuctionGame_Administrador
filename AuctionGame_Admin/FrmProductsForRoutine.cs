using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public partial class FrmProductsForRoutine : Form
    {
        private readonly Routine _routine;
        private readonly FrmRoutine _father;
        private readonly List<int> _availableProducts;
        private readonly List<int> _registeredProducts;
        private readonly List<int> _newProducts;
        private readonly List<int> _deletedProducts;

        public FrmProductsForRoutine(Routine routine, FrmRoutine father)
        {
            InitializeComponent();
            _routine = routine;
            _father = father;
            _newProducts = new List<int>();
            _deletedProducts = new List<int>();
            _availableProducts = new List<int>();
            _registeredProducts = new List<int>();
        }

        private void FrmParamsForRoutine_Load(object sender, EventArgs e)
        {
                UpdateForProducts();
        }

        private void UpdateForProducts()
        {
            var availableProducts = _routine.GetAvailableProducts();
            foreach (var product in availableProducts)
            {
                _availableProducts.Add(product.IdProduct);
                dgvAvailable.Rows.Add(product.IdProduct, product.Name);
            }
            foreach (var product in _routine.SingleProducts)
            {
                _registeredProducts.Add(product.IdProduct);
                dgvRegistered.Rows.Add(product.IdProduct, product.Name);

            }
        }
        private void AvailableToRegistered()
        {
            var rows = dgvAvailable.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                var id = (int)row.Cells[0].Value;
                if (_availableProducts.Contains(id))
                    _newProducts.Add(id);
                if (_registeredProducts.Contains(id))
                    _deletedProducts.Remove(id);

                dgvAvailable.Rows.Remove(row);
                dgvRegistered.Rows.Add(row);
            }
        }
        private void RegisteredToAvailable()
        {
            var rows = dgvRegistered.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                var id = (int)row.Cells[0].Value;
                if (_registeredProducts.Contains(id))
                    _deletedProducts.Add(id);
                if (_availableProducts.Contains(id))
                    _newProducts.Remove(id);

                dgvRegistered.Rows.Remove(row);
                dgvAvailable.Rows.Add(row);
            }
        }

        private void Add()
        {
            foreach (var id in _newProducts)
            {
                var query = $"INSERT INTO routine_has_product (ROUTINE_idRoutine, PRODUCT_idProduct) VALUES ({_routine.IdRoutine}, {id})";
                if (!DbConnection.ejecutar(query))
                {
                    MessageBox.Show(@"Hubo un error agregando un producto");
                }
            }
        }

        private void Delete()
        {
            foreach (var id in _deletedProducts)
            {
                var query = $"DELETE FROM routine_has_product WHERE ROUTINE_idRoutine = {_routine.IdRoutine} AND PRODUCT_idProduct = {id}";
                if (!DbConnection.ejecutar(query))
                {
                    MessageBox.Show(@"Hubo un error eliminando un producto");
                }
            }
        }

        private void pBoxAdd_Click(object sender, EventArgs e)
        {
            AvailableToRegistered();
        }

        private void pBoxDelete_Click(object sender, EventArgs e)
        {
            RegisteredToAvailable();
        }
        private void dgvAvailable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                AvailableToRegistered();
        }

        private void dgvRegistered_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                RegisteredToAvailable();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Add();
            Delete();
            _routine.SingleProducts = _routine?.GetSingleProducts();
            _routine.AllProducts = _routine?.GetAllProducts();
            _routine.AllProducts = _routine.GetAllProducts();
            _father?.UpdateProducts();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
