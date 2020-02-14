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
    public partial class FrmRoutine : Form
    {
        private readonly Routine _routine;
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
        }
        private void LoadRoutine()
        {
            txbNameRoutine.Text = _routine.NameRoutine;
            txbDescriptionRoutine.Text = _routine.DescriptionRoutine;
            var productPerFamilyByRoutine = Product.GetProductPerFamilyByRoutine(_routine.IdRoutine);
            foreach(var family in _routine.Families)
            {
                dgvFamilies.Rows.Add(family.IdFamily, family.NameFamily, family.Points, family.Products.Count());
                foreach(var product in family.Products)
                {
                    if (_routine.Products.Contains(product))
                        dgvProducts.Rows.Add(product.IdProduct, product.Name, product.Price, product.Points, true, true);
                    else
                        dgvProducts.Rows.Add(product.IdProduct, product.Name, product.Price, product.Points, false, true);

                }
            }
            foreach(var product in _routine.Products)
            {
                if(!productPerFamilyByRoutine.Contains(product))
                    dgvProducts.Rows.Add(product.IdProduct, product.Name, product.Price, product.Points, true, false);

            }
            foreach (var virtualBidder in _routine.VirtualBidders)
            {
                dgvVirtualBidders.Rows.Add(virtualBidder.IdVirtualBidder, virtualBidder.NameBidder, virtualBidder.Wallet, virtualBidder.Role.NameRole);
            }
        }
    }
}
