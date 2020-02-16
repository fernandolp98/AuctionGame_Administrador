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
    public partial class FrmFamiliesForRoutine : Form
    {
        private readonly Routine _routine;
        private readonly FrmRoutine _father;
        private readonly List<int> _availableFamilies;
        private readonly List<int> _registeredFamilies;
        private readonly List<int> _newFamilies;
        private readonly List<int> _deletedFamilies;

        public FrmFamiliesForRoutine(Routine routine, FrmRoutine father)
        {
            InitializeComponent();
            _routine = routine;
            _father = father;
            _newFamilies = new List<int>();
            _deletedFamilies = new List<int>();
            _availableFamilies = new List<int>();
            _registeredFamilies = new List<int>();
        }

        private void FrmParamsForRoutine_Load(object sender, EventArgs e)
        {
            UpdateForFamilies();
        }

        private void UpdateForFamilies()
        {
            var availableFamilies = _routine.GetAvailableFamilies();
            foreach (var family in availableFamilies)
            {
                _availableFamilies.Add(family.IdFamily);
                dgvAvailable.Rows.Add(family.IdFamily, family.NameFamily);
            }
            foreach (var family in _routine.Families)
            {
                _registeredFamilies.Add(family.IdFamily);
                dgvRegistered.Rows.Add(family.IdFamily, family.NameFamily);

            }
        }
        private void AvailableToRegistered()
        {
            var rows = dgvAvailable.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                var id = (int)row.Cells[0].Value;
                if (_availableFamilies.Contains(id))
                    _newFamilies.Add(id);
                if (_registeredFamilies.Contains(id))
                    _deletedFamilies.Remove(id);

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
                if (_registeredFamilies.Contains(id))
                    _deletedFamilies.Add(id);
                if (_availableFamilies.Contains(id))
                    _newFamilies.Remove(id);

                dgvRegistered.Rows.Remove(row);
                dgvAvailable.Rows.Add(row);
            }
        }

        private void Add()
        {
            foreach (var id in _newFamilies)
            {
                var query = $"INSERT INTO routine_has_family (ROUTINE_idRoutine, FAMILY_idFamily) VALUES ({_routine.IdRoutine}, {id})";
                if (!DbConnection.ejecutar(query))
                {
                    MessageBox.Show(@"Hubo un error agregando una familia");
                }
            }
        }

        private void Delete()
        {
            foreach (var id in _deletedFamilies)
            {
                var query = $"DELETE FROM routine_has_family WHERE ROUTINE_idRoutine = {_routine.IdRoutine} AND FAMILY_idFamily = {id}";
                if (!DbConnection.ejecutar(query))
                {
                    MessageBox.Show(@"Hubo un error eliminando una familia");
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
            _routine.Families = _routine?.GetFamilies();
            _routine.AllProducts = _routine?.GetAllProducts();
            _routine.ProductsByFamily = _routine.GetProductsByFamily();
            _father?.UpdateFamilies();
            _father?.UpdateProducts();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
