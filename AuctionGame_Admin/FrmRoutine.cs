using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public partial class FrmRoutine : Form
    {
        private readonly Routine _routine;
        private readonly Color _enableColor = Color.FromArgb(26, 82, 118);


        private bool _edit;
        private readonly ChildMainRoutines _father;
        public FrmRoutine(Routine routine, ChildMainRoutines father)
        {
            InitializeComponent();
            _routine = routine;
            _father = father;
            _edit = true;

    }
        public FrmRoutine(ChildMainRoutines father)
        {
            InitializeComponent();
            _father = father;
            _edit = false;
        }

        private void FrmRoutine_Load(object sender, EventArgs e)
        {
            if (_routine == null) return;
            LoadRoutine();
            gboxFamilies.Enabled = true;
            pboxEditFamiliesPerRoutine.Image = Properties.Resources.Edit;
            dgvFamilies.ColumnHeadersDefaultCellStyle.BackColor = _enableColor;
            gboxProducts.Enabled = true;
            pboxEditProductsPerRoutine.Image = Properties.Resources.Edit;
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = _enableColor;
            gboxVirtualBidders.Enabled = true;
            pboxEditVirtualBiddersPerRoutine.Image = Properties.Resources.Edit;
            dgvVirtualBidders.ColumnHeadersDefaultCellStyle.BackColor = _enableColor;


        }
        private void LoadRoutine()
        {
            DataControl.Text(txbNameRoutine, _routine.NameRoutine);
            DataControl.Text(txbDescriptionRoutine, _routine.DescriptionRoutine);
            UpdateFamilies();
            UpdateProducts();
            UpdateVirtualBidders();
        }
        public void UpdateFamilies()
        {
            dgvFamilies.Rows.Clear();
            foreach (var family in _routine.Families)
            {
                dgvFamilies.Rows.Add(family.IdFamily, family.NameFamily, family.Points, family.Products.Count());
            }
        }
        public void UpdateProducts()
        { 
            dgvProducts.Rows.Clear();
            foreach (var product in _routine.AllProducts)
            {
                dgvProducts.Rows.Add(product.IdProduct,
                    product.Name, product.Price,
                    product.Points,
                    _routine.SingleProducts.Contains(product),
                    _routine.ProductsByFamily.Contains(product));
            }
        }
        public void UpdateVirtualBidders()
        {
            dgvVirtualBidders.Rows.Clear();
            foreach (var virtualBidder in _routine.VirtualBidders)
            {
                dgvVirtualBidders.Rows.Add(virtualBidder.IdVirtualBidder, virtualBidder.NameBidder, virtualBidder.Wallet, virtualBidder.Role.NameRole);
            }
        }

        private void pboxEditProductsPerRoutine_Click(object sender, EventArgs e)
        {
            var form = new FrmProductsForRoutine(_routine, this);
            form.Show();
        }

        private void pboxEditFamiliesPerRoutine_Click(object sender, EventArgs e)
        {
            var form = new FrmFamiliesForRoutine(_routine, this);
            form.Show();
        }
        private void pboxEditVirtualBiddersPerRoutine_Click(object sender, EventArgs e)
        {
            var form = new FrmVurtualBiddersForRoutine(_routine, this);
            form.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
