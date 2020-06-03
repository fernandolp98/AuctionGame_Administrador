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
    public partial class FrmVirtualPlayersForRoutine : Form
    {
        private readonly Routine _routine;
        private readonly FrmRoutine _father;
        private readonly List<int> _availablevirtualPlayers;
        private readonly List<int> _registeredvirtualPlayers;
        private readonly List<int> _newvirtualPlayers;
        private readonly List<int> _deletedvirtualPlayers;

        public FrmVirtualPlayersForRoutine(Routine routine, FrmRoutine father)
        {
            InitializeComponent();
            _routine = routine;
            _father = father;
            _newvirtualPlayers = new List<int>();
            _deletedvirtualPlayers = new List<int>();
            _availablevirtualPlayers = new List<int>();
            _registeredvirtualPlayers = new List<int>();
        }

        private void FrmParamsForRoutine_Load(object sender, EventArgs e)
        {
            UpdateForvirtualPlayers();
        }

        private void UpdateForvirtualPlayers()
        {
            var availablevirtualPlayers = _routine.GetAvailablevirtualPlayers();
            foreach (var virtualPlayer in availablevirtualPlayers)
            {
                _availablevirtualPlayers.Add(virtualPlayer.IdvirtualPlayer);
                dgvAvailable.Rows.Add(virtualPlayer.IdvirtualPlayer, virtualPlayer.NameVirtualPlayer);
            }
            foreach (var virtualPlayer in _routine.virtualPlayers)
            {
                _registeredvirtualPlayers.Add(virtualPlayer.IdvirtualPlayer);
                dgvRegistered.Rows.Add(virtualPlayer.IdvirtualPlayer, virtualPlayer.NameVirtualPlayer);

            }
        }
        private void AvailableToRegistered()
        {
            var rows = dgvAvailable.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                var id = (int)row.Cells[0].Value;
                if (_availablevirtualPlayers.Contains(id))
                    _newvirtualPlayers.Add(id);
                if (_registeredvirtualPlayers.Contains(id))
                    _deletedvirtualPlayers.Remove(id);

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
                if (_registeredvirtualPlayers.Contains(id))
                    _deletedvirtualPlayers.Add(id);
                if (_availablevirtualPlayers.Contains(id))
                    _newvirtualPlayers.Remove(id);

                dgvRegistered.Rows.Remove(row);
                dgvAvailable.Rows.Add(row);
            }
        }

        private void Add()
        {
            foreach (var id in _newvirtualPlayers)
            {
                var query = $"INSERT INTO routine_has_virtual_bidder (ROUTINE_idRoutine, VIRTUAL_BIDDER_idvirtualPlayer) VALUES ({_routine.IdRoutine}, {id})";
                if (!DbConnection.ejecutar(query))
                {
                    MessageBox.Show(@"Hubo un error agregando un jugador virtual");
                }
            }
        }

        private void Delete()
        {
            foreach (var id in _deletedvirtualPlayers)
            {
                var query = $"DELETE FROM routine_has_virtual_bidder WHERE ROUTINE_idRoutine = {_routine.IdRoutine} AND VIRTUAL_BIDDER_idvirtualPlayer = {id}";
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
            _routine.virtualPlayers = _routine?.GetvirtualPlayers();
            _father?.UpdatevirtualPlayers();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
