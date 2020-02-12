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
    public partial class ChildMainRole : Form
    {
        public ChildMainRole()
        {
            InitializeComponent();
        }
        public void UpdateRoles(string query)
        {

            if (string.IsNullOrEmpty(query))
                query = "SELECT * FROM roles_view";
            var roles = DbConnection.consultar_datos(query);
            dgvRoles.Rows.Clear();
            if (roles == null) return;
            var bRole = int.TryParse(dgvRoles.Tag.ToString(), out var currentIdFamily);
            foreach (DataRow row in roles.Rows)
            {
                var timeToBiddDown = new Time(row[3].ToString().Split('-')[0], "mm:ss");
                var timeToBiddTop = new Time(row[3].ToString().Split('-')[1], "mm:ss");
                var timeToBid = timeToBiddDown.Format("mm:ss") + " - " + timeToBiddTop.Format("mm:ss");
                dgvRoles.Rows.Add((int)row[0], (string)row[1], (string)row[2], timeToBid, (string)row[4], (string)row[5], (string)row[6]);
                var currentRow = dgvRoles.Rows[dgvRoles.Rows.Count - 1];
                if (!bRole || currentIdFamily == -1) continue;
                if (currentIdFamily == int.Parse(currentRow.Cells[0].Value.ToString()))
                    currentRow.Selected = true;
            }
        }
        private void ChildMenuRole_Load(object sender, EventArgs e)
        {
            UpdateRoles("");
        }
        private bool Question(string question, string caption)
        {
            return MessageBox.Show(question, caption, MessageBoxButtons.YesNoCancel) == DialogResult.Yes;
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvRoles.Rows[e.RowIndex].Selected)
                dgvRoles.Tag = dgvRoles.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvRoles.CurrentRow;

            if (row == null || row.Index == -1 || e.RowIndex == -1) return;

            var idRole = (int)row.Cells[0].Value;

            var role = new Role(idRole);

            var form = new FrmRole(role, this);
            form.Show();
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            var row = dgvRoles.CurrentRow;
            if (row == null || row.Index == -1) return;
            var currentIdproduct = int.Parse(row.Cells[0].Value.ToString());
            var currentNameProduct = row.Cells[1].Value.ToString();


            if (!Question($@"¿Está seguro de eliminar el rol {currentNameProduct}?",
                @"Estás a punto de eliminar un rol")) return;
            {
                //Se deben validar los jugadors virtuales y si existen decidir si eliminarlos o escoger otro rol...
            }
            var query = $"DELETE FROM role WHERE idRole = {currentIdproduct}";
            if (DbConnection.ejecutar(query))
            {
                MessageBox.Show(@"Se eliminó correctamente");
                UpdateRoles("");
            }
            else
            {
                MessageBox.Show(@"Ocurrió un error al eliminar el rol");
            }
        }

        private void btnSearchRoles_Click(object sender, EventArgs e)
        {
            var option = cboSearchRoles.SelectedIndex;
            var query = "SELECT* FROM roles_view";
            switch (option)
            {
                case 1: query += $" WHERE roles_view.nameRole LIKE '{txbSearchRoles.Text}%'"; break;
                case 2: query += $" WHERE roles_view.descriptionRole LIKE '%{txbSearchRoles.Text}%'"; break;
                case 3: query += $" WHERE roles_view.timeToBid LIKE '{txbSearchRoles.Text}'"; break;
                case 4: query += $" WHERE roles_view.offersForRound LIKE '{txbSearchRoles.Text}'"; break;
                case 5: query += $" WHERE roles_view.rounds LIKE '{txbSearchRoles.Text}'"; break;
                case 6: query += $" WHERE roles_view.bidIncrease LIKE '{txbSearchRoles.Text}'"; break;
            }
            UpdateRoles(query);
        }

    }
}
