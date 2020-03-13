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
    public partial class FrmGameConfiguration : Form
    {
        private static readonly Font FontPlaceHolder = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        private static readonly Font FontRegular = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        private readonly DataControl _dataControl = new DataControl(FontPlaceHolder, FontRegular, Color.Silver, Color.Black, Color.Red);

        private bool _edit;
        public FrmGameConfiguration()
        {
            InitializeComponent();
            _edit = true;
        }
        private void FrmRole_Load(object sender, EventArgs e)
        {
            LoadRoutines();
        }
        private void LoadRoutines()
        {
            var routines = Routine.GetAllRoutines();
            cboRoutines.DataSource = routines;
            cboRoutines.DisplayMember = "NameRoutine";
            cboRoutines.ValueMember = "IdRoutine";
        }
        private bool Question(string question, string caption)
        {
            return MessageBox.Show(question, caption, MessageBoxButtons.YesNoCancel) == DialogResult.Yes;
        }
        private void Txb_Enter(object sender, EventArgs e)
        {
            _dataControl.PlaceHolder_Enter((TextBox)sender);
        }

        private void Txb_Leave(object sender, EventArgs e)
        {
            _dataControl.placeHolder_Leave((TextBox)sender);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Question("¿Realmente desea salir?", "Está a punto de salir"))
                this.Close();
        }
        private bool ValidData()
        {
            var textboxes = new object[]
            {
                txbInitialMoney,
                mtxbInitialTime,
            };
            return _dataControl.Validar(textboxes);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                var routine = (Routine)cboRoutines.SelectedItem;
                if (routine == null) return;
                var initialMoney = decimal.Parse(txbInitialMoney.Text);
                var time = new Time(mtxbInitialTime.Text, "mm:ss");
                var form = new FrmGame(routine, initialMoney, time);
                form.Show();
            }
        }

        #region Txb_Validated


        #endregion

        private void txbInitialMoney_Validated(object sender, EventArgs e)
        {
            _dataControl.Validar((TextBox) sender);
        }

        private void mtxbInitialTime_Validated(object sender, EventArgs e)
        {
            var mtxb = (MaskedTextBox) sender;
            if (_dataControl.Validar(mtxb)) return;
            var time = new Time(mtxb.Text, "mm:ss");
            mtxb.Text = time.Format("mm:ss");
        }
    }
}
