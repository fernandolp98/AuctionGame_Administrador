using System;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public partial class ChildMainVirtualBidder : Form
    {
        public ChildMainVirtualBidder()
        {
            InitializeComponent();
        }

        private void ChildMainVirtualPlayers_Load(object sender, EventArgs e)
        {
            UpdateVirtualBidders(null);
        }
        private bool Question(string question, string caption)
        {
            return MessageBox.Show(question, caption, MessageBoxButtons.YesNoCancel) == DialogResult.Yes;
        }
        public void UpdateVirtualBidders(string query)
        {
            dgvVirtualBidders.Rows.Clear();
            var virtualBidders = VirtualBidder.GetAllVirtualBidders(query);

            if (virtualBidders == null) return;
            foreach (var vb in virtualBidders)
            {
                dgvVirtualBidders.Rows.Add(vb.IdVirtualBidder, vb.IdBidder, vb.NameBidder, vb.DescriptionBidder, vb.Role.NameRole,
                    vb.Wallet);
            }
        }

        private void btnDeleteVirtualBidder_Click(object sender, EventArgs e)
        {
            var row = dgvVirtualBidders.CurrentRow;
            if (row == null || row.Index == -1) return;
            var currentIdVirtualBidder = int.Parse(row.Cells[0].Value.ToString());
            var currentNameVirtualBidder = row.Cells[1].Value.ToString();


            if (!Question($@"¿Está seguro de eliminar el jugador virtual {currentNameVirtualBidder}?",
                @"Estás a punto de eliminar un jugador virtual")) return;
            {
                //Se deben validar los jugadors virtuales y si existen decidir si eliminarlos o escoger otro rol...
            }
            var query = $"DELETE FROM virtual_bidder WHERE idVirtualBidder = {currentIdVirtualBidder}";
            if (DbConnection.ejecutar(query))
            {
                MessageBox.Show(@"Se eliminó correctamente");
                UpdateVirtualBidders(null);
            }
            else
            {
                MessageBox.Show(@"Ocurrió un error al eliminar el jugador virtual");
            }
        }

        private void dgvVirtualBidders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvVirtualBidders.Rows[e.RowIndex].Selected)
                dgvVirtualBidders.Tag = dgvVirtualBidders.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvVirtualBidders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvVirtualBidders.CurrentRow; //Obtiene la fila seleccionada

            if (row == null || row.Index == -1 || e.RowIndex == -1) return;

            //Obtiene los datos de la fila seleccioanda y la convierte a objeto de PRODUCTO
            var idVirtualBidder = int.Parse(row.Cells[0].Value.ToString());

            var virtualBidder = VirtualBidder.GetVirtualBidderById(idVirtualBidder);

            var form = new FrmVirtualBidder(virtualBidder, this);//Instancia un nuevo formulario para agregar productos
            form.Show();//Abre el formulario
        }
    }
}
