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
        private bool _edit;
        public FrmGameConfiguration()
        {
            InitializeComponent();
            _edit = true;
        }
        private void FrmRole_Load(object sender, EventArgs e)
        {

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
            DataControl.PlaceHolder_Enter((TextBox)sender);
        }

        private void Txb_Leave(object sender, EventArgs e)
        {
            DataControl.placeHolder_Leave((TextBox)sender);
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
                txbNameRole,
                txbDescriptionRole,
                mtxbTimeToBidDown,
                mtxbTimeToBidTop,
                txbOfersForRoundDown,
                txbOffersForRoundTop,
                txbRoundsDown,
                txbRoundsTop,
                txbBidIncreaseDown,
                txbBidIncreaseBidTop
            };
            return DataControl.Validar(textboxes);
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
