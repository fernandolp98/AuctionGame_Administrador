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
    public partial class FrmVirtualBidder : Form
    {
        private VirtualBidder _virtualBidder;
        private readonly ChildMainVirtualBidders _father;
        private bool _edit;
        public FrmVirtualBidder(VirtualBidder role, ChildMainVirtualBidders father)
        {
            InitializeComponent();
            _father = father;
            this._virtualBidder = role;
            _edit = true;
        }
        public FrmVirtualBidder(ChildMainVirtualBidders father)
        {
            InitializeComponent();
            _father = father;
            _edit = false;
        }

        private void FrmVirtualBidderr_Load(object sender, EventArgs e)
        {
            LoadRoles();
            if(_virtualBidder != null)
                LoadVirtualBider();
        }

        private void LoadVirtualBider()
        {
                cboRole.SelectedValue = _virtualBidder.Role.IdRole;
                DataControl.Text(txbNameVirtualBidder, _virtualBidder.NameBidder);
                DataControl.Text(txbDescriptionVirtuaBidder, _virtualBidder.DescriptionBidder);
                DataControl.Text(txbWalletVirtualBidder, _virtualBidder.Wallet.ToString(CultureInfo.CurrentCulture));
        }

        private void LoadRoles()
        {
            var roles = Role.GetAllRoles();
            cboRole.DataSource = roles;
            cboRole.DisplayMember = "nameRole";
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
                txbNameVirtualBidder,
                txbDescriptionVirtuaBidder,
                txbWalletVirtualBidder
            };
            return DataControl.Validar(textboxes);
        }
    private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidaData())
            {
                var newNameVirtualBidder = txbNameVirtualBidder.Text;
                var newDescriptionVirtualBidder = txbDescriptionVirtuaBidder.Text;
                var newWalletVirtualBidder = txbWalletVirtualBidder.Text;
                var newIdRoleVirtualBidder = ((Role)cboRole.SelectedItem).IdRole;

                if (!_edit) 
                {
                    var query =
                        $"SELECT insert_virtual_bidder(" +
                        $"'{newNameVirtualBidder}', " +
                        $"'{newDescriptionVirtualBidder}', " +
                        $"{newWalletVirtualBidder}, " +
                        $"{newIdRoleVirtualBidder})";
                    var idVirtualBidderDt = DbConnection.consultar_datos(query);
                    if (idVirtualBidderDt != null) 
                    {
                        _virtualBidder = VirtualBidder.GetVirtualBidderById(int.Parse(idVirtualBidderDt.Rows[0][0].ToString()));
                        _father?.UpdateVirtualBidders(null);
                        if (Question(@"¡Se ha registrado el jugador virtual exitosamente! ¿Desea agregar otro?", @"Jugador Virtual Agregado"))
                        {
                            txbDescriptionVirtuaBidder.Clear();
                            txbNameVirtualBidder.Clear();
                            txbWalletVirtualBidder.Clear();
                        }
                        else
                        {
                            _edit = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Ocurrió un problema al registrar el jugador virtual.");
                    }
                }
                else if (_edit) //Si va a editar un producto ya existente
                {
                    var query =
                        $"CALL update_virtual_bidder (" +
                        $"{_virtualBidder.IdVirtualBidder}, " +
                        $"'{newNameVirtualBidder}', " +
                        $"'{newDescriptionVirtualBidder}', " +
                        $"{newWalletVirtualBidder}, " +
                        $"{newIdRoleVirtualBidder})";
                    if (DbConnection.ejecutar(query)) //Si se ejecuta la consulta en la base de datos correctamente
                    {
                        _father?.UpdateVirtualBidders(null);
                        if (Question($"¡Se ha modificado el jugador virtual exitosamente! ¿Desea Salir?",
                            @"Jugador Virtual Modificado")) this.Close();
                    }
                    else
                    {
                        MessageBox.Show(@"Ocurrió un problema modificando el jugador virtual.");
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
            DataControl.PlaceHolder_Enter((TextBox)sender);
        }

        private void Txb_Leave(object sender, EventArgs e)
        {
            DataControl.placeHolder_Leave((TextBox)sender);
        }

        private void Txb_Validated(object sender, EventArgs e)
        {
            DataControl.Validar((TextBox)sender);
        }
    }
}
