using System;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public partial class FrmRole : Form
    {
        private bool _edit;
        private readonly ChildMainRole _father;
        private Role _role;
        public FrmRole(Role role, Form father)
        {
            InitializeComponent();
            _father = (ChildMainRole)father;
            this._role = role;
            _edit = true;
        }
        public FrmRole(Form father)
        {
            InitializeComponent();
            _father = (ChildMainRole)father;
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
            DataControl.Text(txbNameRole, _role.NameRole);
            DataControl.Text(txbDescriptionRole, _role.DescriptionRole);
            DataControl.Text(txbOfersForRoundDown, _role.OffertsForRound.DownValue.ToString());
            DataControl.Text(txbOffersForRoundTop, _role.OffertsForRound.TopValue.ToString());
            DataControl.Text(txbRoundsDown, _role.Rounds.DownValue.ToString());
            DataControl.Text(txbRoundsTop, _role.Rounds.TopValue.ToString());
            DataControl.Text(txbBidIncreaseDown, _role.BidIncrease.DownValue.ToString());
            DataControl.Text(txbBidIncreaseBidTop, _role.BidIncrease.TopValue.ToString());
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

                var timeToBidDown = new Time(mtxbTimeToBidDown.Text, "mm:ss");
                var timeToBidTop = new Time(mtxbTimeToBidTop.Text, "mm:ss");

                var nameRole = txbNameRole.Text;
                var descriptionRole = txbDescriptionRole.Text;
                var timeToBidDownSeconds = timeToBidDown.GetSeconds();
                var timeToBidTopSeconds = timeToBidTop.GetSeconds();
                var offersForRoundDown = txbOfersForRoundDown.Text;
                var offersForRoundTop = txbOffersForRoundTop.Text;
                var roundsDown = txbRoundsDown.Text;
                var roundsTop = txbRoundsTop.Text;
                var increaseBidDown = txbBidIncreaseDown.Text;
                var increaseBidTop = txbBidIncreaseBidTop.Text;
                if (!_edit)
                {
                    var query = $"SELECT insert_role " +
                                   $"('{nameRole}', " +
                                   $"'{descriptionRole}', " +
                                   $"{timeToBidDownSeconds}, " +
                                   $"{timeToBidTopSeconds}, " +
                                   $"{offersForRoundDown}, " +
                                   $"{offersForRoundTop}, " +
                                   $"{roundsDown}, " +
                                   $"{roundsTop}, " +
                                   $"{increaseBidDown}, " +
                                   $"{increaseBidTop})";
                    var rolId = DbConnection.consultar_datos(query);
                    if (rolId != null)
                    {
                        _role = new Role(int.Parse(rolId.Rows[0][0].ToString()));
                        _father?.UpdateRoles("");
                        if (Question(@"¡Se ha registrado el rol exitosamente! ¿Desea agregar otro?", @"Rol agregado"))
                        {
                            txbNameRole.Clear();
                            txbDescriptionRole.Clear();
                            txbOfersForRoundDown.Clear();
                            txbOffersForRoundTop.Clear();
                            txbRoundsDown.Clear();
                            txbRoundsTop.Clear();
                            txbBidIncreaseDown.Clear();
                            txbBidIncreaseBidTop.Clear();
                            mtxbTimeToBidDown.Clear();
                            mtxbTimeToBidTop.Clear();
                        }
                        else
                        {
                            _edit = true;
                        }
                    }
                }
                else if (_edit)
                {
                    var query = $"UPDATE  `role` SET " +
                                   $"`nameRole` = '{nameRole}', " +
                                   $"`descriptionRole` = '{descriptionRole}', " +
                                   $"`timeToBid_Down` = {timeToBidDownSeconds}, " +
                                   $"`timeToBid_Top` = {timeToBidTopSeconds}, " +
                                   $"`offersForRound_Down` = {offersForRoundDown}, " +
                                   $"`offersForRound_Top` = {offersForRoundTop}, " +
                                   $"`rounds_Down` = {roundsDown}, " +
                                   $"`rounds_Top` = {roundsTop}, " +
                                   $"`bidIncrease_Down` = {increaseBidDown}, " +
                                   $"`bidIncrease_Top` =  {increaseBidTop} " +
                                   $"WHERE idRole = {_role.IdRole}";
                    if (DbConnection.ejecutar(query))
                    {
                        _father?.UpdateRoles("");
                        if (!Question($"¡Se ha modificado el rol exitosamente! ¿Desea Salir?",
                            @"Rol Guardado")) return;
                        this.Close();
                    }
                }
            }
        }

        #region Txb_Validated

        private void txbOfersForRoundDown_Validated(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (DataControl.Validar(txb)) return;
            if (DataControl.Validar(txbOffersForRoundTop)) return;
            var down = int.Parse(txbOfersForRoundDown.Text);
            var top = int.Parse(txbOffersForRoundTop.Text);
            if (down <= top) return;
            MessageBox.Show(@"El valor minimo no puede ser mayor que el valor máximo.");
            DataControl.Clear(txb);
        }

        private void txbOffersForRoundTop_Validated(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (DataControl.Validar(txb)) return;
            if (DataControl.Validar(txbOfersForRoundDown)) return;
            var down = int.Parse(txbOfersForRoundDown.Text);
            var top = int.Parse(txbOffersForRoundTop.Text);
            if (top >= down) return;
            MessageBox.Show(@"El valor máximo no puede ser menor que el valor mínimo.");
            DataControl.Clear(txb);
        }
        private void txbRoundsDown_Validated(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (DataControl.Validar(txb)) return;
            if (DataControl.Validar(txbRoundsTop)) return;
            var down = int.Parse(txbRoundsDown.Text);
            var top = int.Parse(txbRoundsTop.Text);
            if (down <= top) return;
            MessageBox.Show(@"El valor minimo no puede ser mayor que el valor máximo.");
            DataControl.Clear(txb);
        }

        private void txbRoundsTop_Validated(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (DataControl.Validar(txb)) return;
            if (DataControl.Validar(txbRoundsDown)) return;
            var down = int.Parse(txbRoundsDown.Text);
            var top = int.Parse(txbRoundsTop.Text);
            if (top >= down) return;
            MessageBox.Show(@"El valor máximo no puede ser menor que el valor mínimo.");
            DataControl.Clear(txb);
        }

        private void txbIncreaseForBidDown_Validated(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (DataControl.Validar(txb)) return;
            if (DataControl.Validar(txbBidIncreaseBidTop)) return;
            var down = int.Parse(txbBidIncreaseDown.Text);
            var top = int.Parse(txbBidIncreaseBidTop.Text);
            if (down <= top) return;
            MessageBox.Show(@"El valor minimo no puede ser mayor que el valor máximo.");
            DataControl.Clear(txb);
        }

        private void txbIncreaseForBidTop_Validated(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (DataControl.Validar(txb)) return;
            if (DataControl.Validar(txbBidIncreaseDown)) return;
            var down = int.Parse(txbBidIncreaseDown.Text);
            var top = int.Parse(txbBidIncreaseBidTop.Text);
            if (top >= down) return;
            MessageBox.Show(@"El valor máximo no puede ser menor que el valor mínimo.");
            DataControl.Clear(txb);
        }
        private void mtxbTimeToBidDown_Validated(object sender, EventArgs e)
        {
            var mtxb = (MaskedTextBox)sender;
            if (DataControl.Validar(mtxb)) return;
            if (DataControl.Validar(mtxbTimeToBidTop)) return;
            var down = new Time(mtxb.Text, "mm:ss");
            var top = new Time(mtxbTimeToBidDown.Text, "mm:ss");
            if (down <= top) return;
            MessageBox.Show(@"El valor minimo no puede ser mayor que el valor máximo.");
            mtxb.Clear();
        }
        private void mtxbTimeToBidTop_Validated(object sender, EventArgs e)
        {
            var mtxb = (MaskedTextBox)sender;
            if (DataControl.Validar(mtxb)) return;
            if (DataControl.Validar(mtxbTimeToBidDown)) return;
            var down = new Time(mtxbTimeToBidDown.Text, "mm:ss");
            var top = new Time(mtxb.Text, "mm:ss");
            if (top >= down) return;
            MessageBox.Show(@"El valor máximo no puede ser menor que el valor mínimo.");
            mtxb.Clear();
        }

        #endregion
    }
}
