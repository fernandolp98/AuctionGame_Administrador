using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public partial class FrmVirtualPlayer : Form
    {

        private readonly DataControl _dataControl = new DataControl(Fonts.FontPlaceHolder, Fonts.FontRegular, Color.Silver, Color.Black, Color.Red);

        private VirtualPlayer _virtualPlayer;
        private readonly ChildMainVirtualPlayer _father;
        private bool _edit;
        public FrmVirtualPlayer(VirtualPlayer virtualPlayer, ChildMainVirtualPlayer father)
        {
            InitializeComponent();
            _father = father;
            this._virtualPlayer = virtualPlayer;
            _edit = true;
        }
        public FrmVirtualPlayer(ChildMainVirtualPlayer father)
        {
            InitializeComponent();
            _father = father;
            _edit = false;
        }

        private void FrmvirtualPlayerr_Load(object sender, EventArgs e)
        {
            LoadRoles();
            if(_virtualPlayer != null)
                LoadVirtualBider();
        }

        private void LoadVirtualBider()
        {
                cboRole.SelectedValue = _virtualPlayer.Role.IdRole;
                _dataControl.Text(txbNamevirtualPlayer, _virtualPlayer.NameVirtualPlayer);
                _dataControl.Text(txbDescriptionVirtuaBidder, _virtualPlayer.DescriptionPlayer);
        }

        private void LoadRoles()
        {
            var roles = Role.GetAllRoles();
            cboRole.DataSource = roles;
            cboRole.DisplayMember = "NameRole";
            cboRole.ValueMember = "IdRole";
        }
        private bool Question(string question, string caption)
        {
            return MessageBox.Show(question, caption, MessageBoxButtons.YesNoCancel) == DialogResult.Yes;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Question("¿Realmente desea salir?", "Está a punto de salir"))
                this.Close();
        }

        protected bool ValidaData()
        {
            var textboxes = new object[]
            {
                txbNamevirtualPlayer,
                txbDescriptionVirtuaBidder,
            };
            return _dataControl.Validar(textboxes);
        }
    private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidaData())
            {
                var newNamevirtualPlayer = txbNamevirtualPlayer.Text;
                var newDescriptionvirtualPlayer = txbDescriptionVirtuaBidder.Text;
                var newIdRolevirtualPlayer = ((Role)cboRole.SelectedItem).IdRole;
                var virtualPlayer = new VirtualPlayer()
                {
                    NameVirtualPlayer = newNamevirtualPlayer,
                    DescriptionPlayer = newDescriptionvirtualPlayer,
                    Role = new Role(newIdRolevirtualPlayer)
                };
                if (!_edit)
                {
                    if (!virtualPlayer.Insert())
                    {
                        MessageBox.Show(@"Ocurrió un problema al registrar el jugador virtual.");
                    }
                    else
                    {
                        _virtualPlayer = virtualPlayer;
                        _father?.UpdatevirtualPlayers(null);
                        if (Question(@"¡Se ha registrado el jugador virtual exitosamente! ¿Desea agregar otro?",
                            @"Jugador Virtual Agregado"))
                        {
                            _dataControl.Clear(txbDescriptionVirtuaBidder);
                            _dataControl.Clear(txbNamevirtualPlayer);
                        }
                        else
                        {
                            _edit = true;
                        }
                    }
                }
                else if (_edit) //Si va a editar un producto ya existente
                {
                    virtualPlayer.IdvirtualPlayer = _virtualPlayer.IdvirtualPlayer;

                    if (!virtualPlayer.Update())
                    {
                        MessageBox.Show(@"Ocurrió un problema modificando el jugador virtual.");
                    }
                    else
                    {
                        _father?.UpdatevirtualPlayers(null);
                        if (Question($"¡Se ha modificado el jugador virtual exitosamente! ¿Desea Salir?",
                            @"Jugador Virtual Modificado")) this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Existe un error en el formulario.");
            }
        }

        private void Txb_Enter(object sender, EventArgs e)
        {
            _dataControl.PlaceHolder_Enter((TextBox)sender);
        }

        private void Txb_Leave(object sender, EventArgs e)
        {
            _dataControl.placeHolder_Leave((TextBox)sender);
        }

        private void Txb_Validated(object sender, EventArgs e)
        {
            _dataControl.Validar((TextBox)sender);
        }
    }
}
