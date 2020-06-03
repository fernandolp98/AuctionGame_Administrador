using System;
using System.Drawing;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public partial class FrmRole : Form
    {


        private readonly DataControl _dataControl = new DataControl(Fonts.FontPlaceHolder, Fonts.FontRegular, Color.Silver, Color.Black, Color.Red);

        private bool _edit;
        private readonly ChildMainRole _father;
        private Role _role;
        public FrmRole(Role role, ChildMainRole father)
        {
            InitializeComponent();
            _father = father;
            this._role = role;
            _edit = true;
        }
        public FrmRole(ChildMainRole father)
        {
            InitializeComponent();
            _father = father;
            _edit = false;
        }
        private void FrmRole_Load(object sender, EventArgs e)
        {
            if (_role != null)
            {
                LoadRole();
            }
        }
        private void LoadRole()
        {
            if (_role == null) return;
            var timeToBidDown = new Time(_role.TimeToBid.TimeDownSeconds, "ss").Format("mm:ss");
            var timeToBidTop = new Time(_role.TimeToBid.TimeTopSeconds, "ss").Format("mm:ss");

            mtxbTimeToBidDown.Text = timeToBidDown;
            mtxbTimeToBidTop.Text = timeToBidTop;
            _dataControl.Text(txbNameRole, _role.NameRole);
            _dataControl.Text(txbDescriptionRole, _role.DescriptionRole);
            _dataControl.Text(txbOfersForRoundDown, _role.OffertsForRound.DownValue.ToString());
            _dataControl.Text(txbOffersForRoundTop, _role.OffertsForRound.TopValue.ToString());
            _dataControl.Text(txbRoundsDown, _role.Rounds.DownValue.ToString());
            _dataControl.Text(txbRoundsTop, _role.Rounds.TopValue.ToString());
            _dataControl.Text(txbBidIncreaseDown, _role.BidIncrease.DownValue.ToString());
            _dataControl.Text(txbBidIncreaseBidTop, _role.BidIncrease.TopValue.ToString());
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
            return _dataControl.Validar(textboxes);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidData()) return;
            var timeToBidDown = new Time(mtxbTimeToBidDown.Text, "mm:ss");
            var timeToBidTop = new Time(mtxbTimeToBidTop.Text, "mm:ss");

            var nameRole = txbNameRole.Text;
            var descriptionRole = txbDescriptionRole.Text;

            var timeToBidDownSeconds = timeToBidDown.GetSeconds();
            var timeToBidTopSeconds = timeToBidTop.GetSeconds();
            var timeToBid = new TimesValues(timeToBidDownSeconds, timeToBidTopSeconds);
            var offersForRoundDown = int.Parse(txbOfersForRoundDown.Text);
            var offersForRoundTop = int.Parse(txbOffersForRoundTop.Text);
            var offersForRound = new BetwenValues(offersForRoundDown, offersForRoundTop);
            var roundsDown = int.Parse(txbRoundsDown.Text);
            var roundsTop = int.Parse(txbRoundsTop.Text);
            var rounds = new BetwenValues(roundsDown, roundsTop);
            var increaseBidDown = int.Parse(txbBidIncreaseDown.Text);
            var increaseBidTop = int.Parse(txbBidIncreaseBidTop.Text);
            var increaseBid = new BetwenValues(increaseBidDown, increaseBidTop);


            var role = new Role(nameRole, descriptionRole, timeToBid, offersForRound, rounds, increaseBid);
            if (!_edit)
            {

                if (!role.Insertar())
                {
                    MessageBox.Show(@"Ocurrió un problema al registrar el rol");
                    return;
                }
                _father?.UpdateRoles("");
                if (Question(@"¡Se ha registrado el rol exitosamente! ¿Desea agregar otro?", @"Rol agregado"))
                {
                    _dataControl.Clear(txbNameRole);
                    _dataControl.Clear(txbOfersForRoundDown);
                    _dataControl.Clear(txbDescriptionRole);
                    _dataControl.Clear(txbOfersForRoundDown);
                    _dataControl.Clear(txbOffersForRoundTop);
                    _dataControl.Clear(txbRoundsDown);
                    _dataControl.Clear(txbRoundsTop);
                    _dataControl.Clear(txbBidIncreaseDown);
                    _dataControl.Clear(txbBidIncreaseBidTop);
                    mtxbTimeToBidTop.Clear();
                    mtxbTimeToBidDown.Clear();
                }
                else
                {
                    _edit = true;
                }
            }
            else if (_edit)
            {
                role.IdRole = _role.IdRole;

                if (role.Update())
                {
                    _role = role;
                    _father?.UpdateRoles("");
                    if (!Question($"¡Se ha modificado el rol exitosamente! ¿Desea Salir?",
                        @"Rol Guardado")) return;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(@"Ocurrió un error al actualizar el rol");
                }
            }
        }

        #region Txb_Validated

        private void txbOfersForRoundDown_Validated(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (_dataControl.Validar(txb)) return;
            if (_dataControl.Validar(txbOffersForRoundTop)) return;
            var down = int.Parse(txbOfersForRoundDown.Text);
            var top = int.Parse(txbOffersForRoundTop.Text);
            if (down <= top) return;
            MessageBox.Show(@"El valor minimo no puede ser mayor que el valor máximo.");
            _dataControl.Clear(txb);
        }

        private void txbOffersForRoundTop_Validated(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (_dataControl.Validar(txb)) return;
            if (_dataControl.Validar(txbOfersForRoundDown)) return;
            var down = int.Parse(txbOfersForRoundDown.Text);
            var top = int.Parse(txbOffersForRoundTop.Text);
            if (top >= down) return;
            MessageBox.Show(@"El valor máximo no puede ser menor que el valor mínimo.");
            _dataControl.Clear(txb);
        }
        private void txbRoundsDown_Validated(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (_dataControl.Validar(txb)) return;
            if (_dataControl.Validar(txbRoundsTop)) return;
            var down = int.Parse(txbRoundsDown.Text);
            var top = int.Parse(txbRoundsTop.Text);
            if (down <= top) return;
            MessageBox.Show(@"El valor minimo no puede ser mayor que el valor máximo.");
            _dataControl.Clear(txb);
        }

        private void txbRoundsTop_Validated(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (_dataControl.Validar(txb)) return;
            if (_dataControl.Validar(txbRoundsDown)) return;
            var down = int.Parse(txbRoundsDown.Text);
            var top = int.Parse(txbRoundsTop.Text);
            if (top >= down) return;
            MessageBox.Show(@"El valor máximo no puede ser menor que el valor mínimo.");
            _dataControl.Clear(txb);
        }

        private void txbIncreaseForBidDown_Validated(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (_dataControl.Validar(txb)) return;
            if (_dataControl.Validar(txbBidIncreaseBidTop)) return;
            var down = int.Parse(txbBidIncreaseDown.Text);
            var top = int.Parse(txbBidIncreaseBidTop.Text);
            if (down <= top) return;
            MessageBox.Show(@"El valor minimo no puede ser mayor que el valor máximo.");
            _dataControl.Clear(txb);
        }

        private void txbIncreaseForBidTop_Validated(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (_dataControl.Validar(txb)) return;
            if (_dataControl.Validar(txbBidIncreaseDown)) return;
            var down = int.Parse(txbBidIncreaseDown.Text);
            var top = int.Parse(txbBidIncreaseBidTop.Text);
            if (top >= down) return;
            MessageBox.Show(@"El valor máximo no puede ser menor que el valor mínimo.");
            _dataControl.Clear(txb);
        }
        private void mtxbTimeToBidDown_Validated(object sender, EventArgs e)
        {
            var mtxb = (MaskedTextBox)sender;
            if (_dataControl.Validar(mtxb)) return;
            if (_dataControl.Validar(mtxbTimeToBidTop)) return;
            var down = new Time(mtxb.Text, "mm:ss");
            var top = new Time(mtxbTimeToBidDown.Text, "mm:ss");
            if (down <= top) return;
            MessageBox.Show(@"El valor minimo no puede ser mayor que el valor máximo.");
            mtxb.Clear();
        }
        private void mtxbTimeToBidTop_Validated(object sender, EventArgs e)
        {
            var mtxb = (MaskedTextBox)sender;
            if (_dataControl.Validar(mtxb)) return;
            if (_dataControl.Validar(mtxbTimeToBidDown)) return;
            var down = new Time(mtxbTimeToBidDown.Text, "mm:ss");
            var top = new Time(mtxb.Text, "mm:ss");
            if (top >= down) return;
            MessageBox.Show(@"El valor máximo no puede ser menor que el valor mínimo.");
            mtxb.Clear();
        }

        #endregion
    }
}
