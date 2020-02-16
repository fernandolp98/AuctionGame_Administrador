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
    public partial class FrmVurtualBiddersForRoutine : Form
    {
        private readonly Routine _routine;
        private readonly FrmRoutine _father;
        private readonly List<int> _availableVirtualBidders;
        private readonly List<int> _registeredVirtualBidders;
        private readonly List<int> _newVirtualBidders;
        private readonly List<int> _deletedVirtualBidders;

        public FrmVurtualBiddersForRoutine(Routine routine, FrmRoutine father)
        {
            InitializeComponent();
            _routine = routine;
            _father = father;
            _newVirtualBidders = new List<int>();
            _deletedVirtualBidders = new List<int>();
            _availableVirtualBidders = new List<int>();
            _registeredVirtualBidders = new List<int>();
        }

        private void FrmParamsForRoutine_Load(object sender, EventArgs e)
        {
            UpdateForVirtualBidders();
        }

        private void UpdateForVirtualBidders()
        {
            var availableVirtualBidders = _routine.GetAvailableVirtualBidders();
            foreach (var virtualBidder in availableVirtualBidders)
            {
                _availableVirtualBidders.Add(virtualBidder.IdVirtualBidder);
                dgvAvailable.Rows.Add(virtualBidder.IdVirtualBidder, virtualBidder.NameBidder);
            }
            foreach (var virtualBidder in _routine.VirtualBidders)
            {
                _registeredVirtualBidders.Add(virtualBidder.IdVirtualBidder);
                dgvRegistered.Rows.Add(virtualBidder.IdVirtualBidder, virtualBidder.NameBidder);

            }
        }
        private void AvailableToRegistered()
        {
            var rows = dgvAvailable.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                var id = (int)row.Cells[0].Value;
                if (_availableVirtualBidders.Contains(id))
                    _newVirtualBidders.Add(id);
                if (_registeredVirtualBidders.Contains(id))
                    _deletedVirtualBidders.Remove(id);

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
                if (_registeredVirtualBidders.Contains(id))
                    _deletedVirtualBidders.Add(id);
                if (_availableVirtualBidders.Contains(id))
                    _newVirtualBidders.Remove(id);

                dgvRegistered.Rows.Remove(row);
                dgvAvailable.Rows.Add(row);
            }
        }

        private void Add()
        {
            foreach (var id in _newVirtualBidders)
            {
                var query = $"INSERT INTO routine_has_virtual_bidder (ROUTINE_idRoutine, VIRTUAL_BIDDER_idVIrtualBidder) VALUES ({_routine.IdRoutine}, {id})";
                if (!DbConnection.ejecutar(query))
                {
                    MessageBox.Show(@"Hubo un error agregando un jugador virtual");
                }
            }
        }

        private void Delete()
        {
            foreach (var id in _deletedVirtualBidders)
            {
                var query = $"DELETE FROM routine_has_virtual_bidder WHERE ROUTINE_idRoutine = {_routine.IdRoutine} AND VIRTUAL_BIDDER_idVirtualBidder = {id}";
                if (!DbConnection.ejecutar(query))
                {
                    MessageBox.Show(@"Hubo un error eliminando un jugador virtual");
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
            _routine.VirtualBidders = _routine?.GetVirtualBidders();
            _father?.UpdateVirtualBidders();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
