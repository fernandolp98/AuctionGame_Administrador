using System;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public partial class ChildMainVirtualPlayer : Form
    {
        public ChildMainVirtualPlayer()
        {
            InitializeComponent();
        }

        private void ChildMainVirtualPlayers_Load(object sender, EventArgs e)
        {
            UpdatevirtualPlayers(null);
        }
        private bool Question(string question, string caption)
        {
            return MessageBox.Show(question, caption, MessageBoxButtons.YesNoCancel) == DialogResult.Yes;
        }
        public void UpdatevirtualPlayers(string query)
        {
            dgvVirtualPlayers.Rows.Clear();
            var virtualPlayers = VirtualPlayer.GetVirtualPlayers(query);

            if (virtualPlayers == null) return;
            foreach (var vb in virtualPlayers)
            {
                dgvVirtualPlayers.Rows.Add(vb.IdvirtualPlayer, vb.NameVirtualPlayer, vb.DescriptionPlayer, vb.Role.NameRole);
            }
        }


        private void btnDeletevirtualPlayer_Click(object sender, EventArgs e)
        {
            var row = dgvVirtualPlayers.CurrentRow;
            if (row == null || row.Index == -1) return;
            var currentIdvirtualPlayer = int.Parse(row.Cells[0].Value.ToString());
            var currentNamevirtualPlayer = row.Cells[1].Value.ToString();


            if (!Question($@"¿Está seguro de eliminar el jugador virtual {currentNamevirtualPlayer}?",
                @"Estás a punto de eliminar un jugador virtual")) return;
            {
                //Se deben validar los jugadors virtuales y si existen decidir si eliminarlos o escoger otro rol...
            }
            var query = $"DELETE FROM virtual_bidder WHERE idvirtualPlayer = {currentIdvirtualPlayer}";
            if (DbConnection.ejecutar(query))
            {
                MessageBox.Show(@"Se eliminó correctamente");
                UpdatevirtualPlayers(null);
            }
            else
            {
                MessageBox.Show(@"Ocurrió un error al eliminar el jugador virtual");
            }
        }

        private void dgvvirtualPlayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvVirtualPlayers.Rows[e.RowIndex].Selected)
                dgvVirtualPlayers.Tag = dgvVirtualPlayers.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvvirtualPlayers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvVirtualPlayers.CurrentRow; //Obtiene la fila seleccionada

            if (row == null || row.Index == -1 || e.RowIndex == -1) return;

            //Obtiene los datos de la fila seleccioanda y la convierte a objeto de PRODUCTO
            var idvirtualPlayer = int.Parse(row.Cells[0].Value.ToString());

            var virtualPlayer = VirtualPlayer.GetVirtualPlayerById(idvirtualPlayer);

            var form = new FrmVirtualPlayer(virtualPlayer, this);//Instancia un nuevo formulario para agregar productos
            form.Show();//Abre el formulario
        }
    }
}
