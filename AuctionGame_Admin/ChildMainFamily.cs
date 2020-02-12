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
    public partial class ChildMainFamily : Form
    {
        public ChildMainFamily()
        {
            InitializeComponent();
        }
        public void UpdateFamilies(string query)
        {

            if (string.IsNullOrEmpty(query))
                query = "SELECT * FROM families_view";
            var families = DbConnection.consultar_datos(query);
            dgvFamilies.Rows.Clear();
            if (families == null) return;
            var bFamily = int.TryParse(dgvFamilies.Tag.ToString(), out var currentIdFamily);
            foreach (DataRow row in families.Rows)
            {
                dgvFamilies.Rows.Add((int)row[0], (string)row[1], (int)row[2], (long)row[3]);
                var currentRow = dgvFamilies.Rows[dgvFamilies.Rows.Count - 1];
                if (!bFamily || currentIdFamily == -1) continue;
                if (currentIdFamily == int.Parse(currentRow.Cells[0].Value.ToString()))
                    currentRow.Selected = true;
            }
        }
        private void ChildMenuFamily_Load(object sender, System.EventArgs e)
        {
            UpdateFamilies("");
        }
        private bool Question(string question, string caption)
        {
            return MessageBox.Show(question, caption, MessageBoxButtons.YesNoCancel) == DialogResult.Yes;
        }
        private void dgvFamilies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvFamilies.Rows[e.RowIndex].Selected)
                dgvFamilies.Tag = dgvFamilies.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvFamilies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvFamilies.CurrentRow;

            if (row == null || row.Index == -1 || e.RowIndex == -1) return;

            var idFamily = (int)row.Cells[0].Value;
            var nameFamily = (string)row.Cells[1].Value;
            var pointsValue = (int)row.Cells[2].Value;

            var product = new Family()
            {
                IdFamily = idFamily,
                NameFamily = nameFamily,
                Points = pointsValue,
            };

            var form = new FrmFamily(product, this);
            form.Show();
        }

        private void btnDeleteFamily_Click(object sender, System.EventArgs e)
        {
            var row = dgvFamilies.CurrentRow;
            if (row == null || row.Index == -1) return;
            var currentIdproduct = int.Parse(row.Cells[0].Value.ToString());
            var currentNameProduct = row.Cells[1].Value.ToString();


            if (!Question($@"¿Está seguro de eliminar el producto {currentNameProduct}?",
                @"Estás a punto de eliminar un producto")) return;
            var query = $"DELETE FROM family WHERE idFamily = {currentIdproduct}";
            if (DbConnection.ejecutar(query))
            {
                MessageBox.Show(@"Se eliminó correctamente");
                UpdateFamilies("");
            }
            else
            {
                MessageBox.Show(@"Ocurrió un error al eliminar la familia");
            }
        }

        private void btnSearchFamily_Click(object sender, System.EventArgs e)
        {
            var option = cboSearchFamily.SelectedIndex;
            var query = "SELECT * FROM families_view";
            switch (option)
            {
                case 1: query += $" WHERE families_view.nameFamily LIKE '{txbSearchFamily.Text}%'"; break;
                case 2: query += $" WHERE families_view.points = {txbSearchFamily.Text}"; break;
                case 3: query += $" WHERE families_view.products = {txbSearchFamily.Text}"; break;
            }
            UpdateFamilies(query);
        }

        private void txbSearchFamily_Enter(object sender, System.EventArgs e)
        {
            DataControl.PlaceHolder_Enter((TextBox)sender);
        }

        private void txbSearchFamily_Leave(object sender, System.EventArgs e)
        {
            DataControl.placeHolder_Leave((TextBox)sender);

        }
    }
}
