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
    public partial class FrmMainMenu : Form
    {
        ChildMainProducts _formProducts;
        ChildMainFamily _formFamily;
        ChildMainRole _formRole;
        ChildMainVirtualBidder _formVirtualBidder;
        ChildMainRoutines _formRoutine;

        public FrmMainMenu()
        {
            InitializeComponent();
            _formProducts = new ChildMainProducts();
            _formFamily = new ChildMainFamily();
            _formRole = new ChildMainRole();
            _formVirtualBidder = new ChildMainVirtualBidder();
            _formRoutine = new ChildMainRoutines();
        }
        private void HideSubMenus()
        {
            if (pnlSubMenuItem2.Visible)
                pnlSubMenuItem2.Visible = false;
            if (pnlSubMenuItem3.Visible)
                pnlSubMenuItem3.Visible = false;
            if (pnlSubMenuItem4.Visible)
                pnlSubMenuItem4.Visible = false;
            if (pnlSubMenuItem5.Visible)
                pnlSubMenuItem5.Visible = false;
            if (pnlSubMenuItem6.Visible)
                pnlSubMenuItem6.Visible = false;
            if (pnlSubMenuItem7.Visible)
                pnlSubMenuItem7.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            HideSubMenus();
            subMenu.Visible = true;
        }

        private void btnMenuItem1_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuItem1.Visible)
                pnlSubMenuItem1.Visible = false;
            else
                ShowSubMenu(pnlSubMenuItem1);
        }
        private void btnMenuItem2_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuItem2.Visible)
                pnlSubMenuItem2.Visible = false;
            else
                ShowSubMenu(pnlSubMenuItem2);
        }

        private void btnMenuItem3_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuItem3.Visible)
                pnlSubMenuItem3.Visible = false;
            else
                ShowSubMenu(pnlSubMenuItem3);
        }
        private void btnMenuItem4_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuItem4.Visible)
                pnlSubMenuItem4.Visible = false;
            else
                ShowSubMenu(pnlSubMenuItem4);
        }
        private void btnMenuItem5_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuItem5.Visible)
                pnlSubMenuItem5.Visible = false;
            else
                ShowSubMenu(pnlSubMenuItem5);
        }
        private void btnMenuItem6_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuItem6.Visible)
                pnlSubMenuItem6.Visible = false;
            else
                ShowSubMenu(pnlSubMenuItem6);
        }
        private void btnMenuItem7_Click(object sender, EventArgs e)
        {
            if (pnlSubMenuItem7.Visible)
                pnlSubMenuItem7.Visible = false;
            else
                ShowSubMenu(pnlSubMenuItem7);
        }
        private void OpenChildForm(Form child)
        {
            pnlDashboard.Controls.Clear();
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            pnlDashboard.Controls.Add(child);
            child.Show();
        }

        #region Productos

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(_formProducts);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var childProducts = _formProducts;
            if (pnlDashboard.Controls.Count > 0)//Si el panel principal contiene un Formulario hijo
            {

                if (pnlDashboard.Controls[0].GetType() != typeof(ChildMainProducts))//Si el tipo de formulario es diferente a ChildMenuProducts
                {
                    OpenChildForm(childProducts);//Agrega un nuevo formulario de childMenuProducts
                }
                else
                {
                    childProducts = (ChildMainProducts)pnlDashboard.Controls[0];
                }
            }
            else
            {
                OpenChildForm(childProducts);
            }
            var form = new FrmProduct(childProducts);
            form.Show();
        }
        #endregion

        private void btnFamilies_Click(object sender, EventArgs e)
        {
            OpenChildForm(_formFamily);
        }

        private void btnAddFamily_Click(object sender, EventArgs e)
        {
            var childFamilies = _formFamily;
            if (pnlDashboard.Controls.Count > 0)//Si el panel principal contiene un Formulario hijo
            {

                if (pnlDashboard.Controls[0].GetType() != typeof(ChildMainFamily))//Si el tipo de formulario es diferente a ChildMenuProducts
                {
                    OpenChildForm(childFamilies);//Agrega un nuevo formulario de childMenuProducts
                }
                else
                {
                    childFamilies = (ChildMainFamily)pnlDashboard.Controls[0];
                }
            }
            else
            {
                OpenChildForm(childFamilies);
            }
            var form = new FrmFamily(childFamilies);
            form.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            OpenChildForm(_formRole);

        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            var childRoles = _formRole;
            if (pnlDashboard.Controls.Count > 0)//Si el panel principal contiene un Formulario hijo
            {

                if (pnlDashboard.Controls[0].GetType() != typeof(ChildMainRole))//Si el tipo de formulario es diferente a ChildMenuProducts
                {
                    OpenChildForm(childRoles);//Agrega un nuevo formulario de childMenuProducts
                }
                else
                {
                    childRoles = (ChildMainRole)pnlDashboard.Controls[0];
                }
            }
            else
            {
                OpenChildForm(childRoles);
            }
            var form = new FrmRole(childRoles);
            form.Show();
        }
        private void btnVirtualPlayers_Click(object sender, EventArgs e)
        {
            OpenChildForm(_formVirtualBidder);

        }

        private void btnAddVirtualPlayer_Click(object sender, EventArgs e)
        {
            var childVirtualPlayers = _formVirtualBidder;
            if (pnlDashboard.Controls.Count > 0)//Si el panel principal contiene un Formulario hijo
            {

                if (pnlDashboard.Controls[0].GetType() != typeof(ChildMainVirtualBidder))//Si el tipo de formulario es diferente a ChildMenuProducts
                {
                    OpenChildForm(childVirtualPlayers);//Agrega un nuevo formulario de childMenuProducts
                }
                else
                {
                    childVirtualPlayers = (ChildMainVirtualBidder)pnlDashboard.Controls[0];
                }
            }
            else
            {
                OpenChildForm(childVirtualPlayers);
            }
            var form = new FrmVirtualBidder(childVirtualPlayers);
            form.Show();
        }

        private void btnRoutines_Click(object sender, EventArgs e)
        {
            OpenChildForm(_formRoutine);
        }

        private void btnAddRoutines_Click(object sender, EventArgs e)
        {
            var childRoutines = _formRoutine;
            if (pnlDashboard.Controls.Count > 0)//Si el panel principal contiene un Formulario hijo
            {

                if (pnlDashboard.Controls[0].GetType() != typeof(ChildMainRoutines))//Si el tipo de formulario es diferente a ChildMenuProducts
                {
                    OpenChildForm(childRoutines);//Agrega un nuevo formulario de childMenuProducts
                }
                else
                {
                    childRoutines = (ChildMainRoutines)pnlDashboard.Controls[0];
                }
            }
            else
            {
                OpenChildForm(childRoutines);
            }
            var form = new FrmRoutine(childRoutines);
            form.Show();
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildMainUsers());

        }

        private void btnUsersStatistics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmStatistics());

        }
        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnGameConfiguration_Click(object sender, EventArgs e)
        {

        }

        private void btnGame_Click(object sender, EventArgs e)
        {

        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            var form = new FrmConfiguration();
            form.ShowDialog();
        }
    }
}
