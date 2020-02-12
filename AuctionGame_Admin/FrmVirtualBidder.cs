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
        private readonly VirtualBidder _virtualBidder;
        private readonly ChildMainVirtualBidders _father;
        private readonly bool _edit;
        public FrmVirtualBidder(VirtualBidder role, Form father)
        {
            InitializeComponent();
            _father = (ChildMainVirtualBidders)father;
            this._virtualBidder = role;
            _edit = true;
        }
        public FrmVirtualBidder(Form father)
        {
            InitializeComponent();
            _father = (ChildMainVirtualBidders)father;
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
                DataControl.Text(txbWallet, _virtualBidder.Wallet.ToString(CultureInfo.CurrentCulture));
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
                txbWallet
            };
            return DataControl.Validar(textboxes);
        }
    private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidaData())
            {
                //var newName = txbNameVirtualBidder.Text;
                //var newDescription = txbDescriptionVirtuaBidder.Text;

                //if (!_edit) //Si no va a editar un producto ya existente
                //{
                //    var query =
                //        $"SELECT insert_family('{newNameFamily}', {newPointsValue})";
                //    var idFamilyDt = DbConnection.consultar_datos(query);
                //    if (idFamilyDt != null) //Si se ejecuta la consulta en la base de datos correctamente
                //    {
                //        //_family = Family.GetFamilyById(int.Parse(idFamilyDt.Rows[0][0].ToString()));
                //        _father?.UpdateVirtualBidders();
                //        if (Question(@"¡Se ha registrado la familia exitosamente! ¿Desea agregar otra?", @"Familia agregada"))
                //        {

                //            txbDescriptionVirtuaBidder.Clear();
                //            txbNameVirtualBidder.Clear();
                //        }
                //        else
                //        {
                //            _edit = true;
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show(@"Ocurrió un problema al registrar la familia.");
                //    }
                //}
                //else if (_edit) //Si va a editar un producto ya existente
                //{
                //    var query =
                //        $"UPDATE family set " +
                //        $"nameFamily = '{newNameFamily}', " +
                //        $"points = {newPointsValue} " +
                //        $"WHERE idFamily = {_family.IdFamily}";
                //    if (DbConnection.ejecutar(query)) //Si se ejecuta la consulta en la base de datos correctamente
                //    {
                //        var added = AddNewProducts();
                //        var removed = RemoveOldProduct();
                //        _father?.UpdateFamilies("");
                //        if (!Question($"¡Se ha modificado la familia exitosamente!\nProductos Agregados: {added}\nProductos Eliminados: {removed}\n¿Desea Salir?",
                //            @"Familia Modificada")) return;
                //        this.Close();
                //    }
                //    else
                //    {
                //        MessageBox.Show(@"Ocurrió un problema modificando la familia.");
                //    }
                //}
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
