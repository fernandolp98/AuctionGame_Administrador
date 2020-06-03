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
    public partial class ChildMainRoutines : Form
    {
        public ChildMainRoutines()
        {
            InitializeComponent();
        }

        private void ChildMainRoutines_Load(object sender, EventArgs e)
        {
            UpdateRoutines(null);
        }
        public void UpdateRoutines(string query)
        {
            if(string.IsNullOrEmpty(query))
                query = "SELECT * FROM routines_view";
            var table = DbConnection.consultar_datos(query);
            dgvRoutines.Rows.Clear();
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    dgvRoutines.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
                }
            }
        }

        private void dgvRoutines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvRoutines.Rows[e.RowIndex].Selected)
                dgvRoutines.Tag = dgvRoutines.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvRoutines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvRoutines.CurrentRow; //Obtiene la fila seleccionada

            if (row == null || row.Index == -1 || e.RowIndex == -1) return;

            //Obtiene los datos de la fila seleccioanda y la convierte a objeto de PRODUCTO
            var idRoutine = int.Parse(row.Cells[0].Value.ToString());

            var routine = Routine.GetRoutineById(idRoutine);

            var form = new FrmRoutine(routine, this);//Instancia un nuevo formulario para agregar productos
            form.Show();//Abre el formulario
        }

        private void btnSearchRoutines_Click(object sender, EventArgs e)
        {

        }
    }
}
