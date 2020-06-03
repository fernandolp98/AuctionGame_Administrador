using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public partial class FrmConfiguration : Form
    {
        private readonly DataControl _dataControl = new DataControl(Fonts.FontPlaceHolder, Fonts.FontRegular, Color.Silver, Color.Black, Color.Red);

        public FrmConfiguration()
        {
            InitializeComponent();
        }
        private void FrmRole_Load(object sender, EventArgs e)
        {
            var patch = "config.txt";
            if (File.Exists(patch))
            {
                    var lines = File.ReadAllLines(patch);
                    txbIPServer.Text = lines[0];
                    txbPortServer.Text = lines[1];
                    txbUserBd.Text = lines[2];
                    txbPasswordBd.Text = lines[3];
                    txbHostBd.Text = lines[4];
                    txbPortBd.Text = lines[5];
                    txbNameBd.Text = lines[6];
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de configuración config.txt");
            }
        }
        private void LoadRole()
        {

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
                txbIPServer,
                txbPortServer,
                txbPasswordBd,
                txbHostBd,
                txbUserBd,
                txbPortBd,
                txbNameBd
            };
            return _dataControl.Validar(textboxes);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {

            }
        }

        #region Txb_Validated

        private void txbOfersForRoundDown_Validated(object sender, EventArgs e)
        {

        }

        private void txbOffersForRoundTop_Validated(object sender, EventArgs e)
        {

        }

        private void txbRoundsTop_Validated(object sender, EventArgs e)
        {

        }

        private void txbIncreaseForBidDown_Validated(object sender, EventArgs e)
        {

        }

        private void txbIncreaseForBidTop_Validated(object sender, EventArgs e)
        {

        }
        private void mtxbTimeToBidDown_Validated(object sender, EventArgs e)
        {
        }
        private void mtxbTimeToBidTop_Validated(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
