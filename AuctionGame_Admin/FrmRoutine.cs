using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AuctionGame_Admin
{
    public partial class FrmRoutine : Form
    {
        private readonly DataControl _dataControl = new DataControl(Fonts.FontPlaceHolder, Fonts.FontRegular, Color.Silver, Color.Black, Color.Red);

        private Routine _routine;
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
            UpdateControls();
        }

        private void UpdateControls()
        {
            gboxFamilies.Enabled = true;
            pboxEditFamiliesPerRoutine.Image = Properties.Resources.Edit;
            dgvFamilies.ColumnHeadersDefaultCellStyle.BackColor = _enableColor;
            gboxProducts.Enabled = true;
            pboxEditProductsPerRoutine.Image = Properties.Resources.Edit;
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = _enableColor;
            gboxvirtualPlayers.Enabled = true;
            pboxEditvirtualPlayersPerRoutine.Image = Properties.Resources.Edit;
            dgvvirtualPlayers.ColumnHeadersDefaultCellStyle.BackColor = _enableColor;
        }
        private void LoadRoutine()
        {
            _dataControl.Text(txbNameRoutine, _routine.NameRoutine);
            _dataControl.Text(txbDescriptionRoutine, _routine.DescriptionRoutine);
            UpdateFamilies();
            UpdateProducts();
            UpdatevirtualPlayers();
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
        private bool ValidData()
        {
            var textboxes = new object[]
            {
                txbNameRoutine,
                txbDescriptionRoutine
            };
            return _dataControl.Validar(textboxes);
        }
        public void UpdateFamilies()
        {
            dgvFamilies.Rows.Clear();
            foreach (var family in _routine.Families)
            {
                dgvFamilies.Rows.Add(family.IdFamily, family.NameFamily, family.Points, family.Products.Count());
            }
            _father?.UpdateRoutines(null);
        }
        public void UpdateProducts()
        { 
            dgvProducts.Rows.Clear();
            foreach (var product in _routine.AllProducts)
            {
                dgvProducts.Rows.Add(product.IdProduct,
                    product.Name, product.StartingPrice,
                    product.Points,
                    _routine.SingleProducts.Contains(product),
                    _routine.ProductsByFamily.Contains(product));
            }
            _father?.UpdateRoutines(null);
        }
        public void UpdatevirtualPlayers()
        {
            dgvvirtualPlayers.Rows.Clear();
            foreach (var virtualPlayer in _routine.virtualPlayers)
            {
                dgvvirtualPlayers.Rows.Add(virtualPlayer.IdvirtualPlayer, virtualPlayer.NameVirtualPlayer, virtualPlayer.Wallet, virtualPlayer.Role.NameRole);
            }
            _father?.UpdateRoutines(null);
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
        private void pboxEditvirtualPlayersPerRoutine_Click(object sender, EventArgs e)
        {
            var form = new FrmVirtualPlayersForRoutine(_routine, this);
            form.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pboxSaveRoutine_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {


                var nameRoutine = txbNameRoutine.Text;
                var descriptionRoutine = txbDescriptionRoutine.Text;
                if (!_edit)
                {
                    var query = $"SELECT insert_routine " +
                                   $"('{nameRoutine}', " +
                                   $"'{descriptionRoutine}')";
                    var rolId = DbConnection.consultar_datos(query);
                    if (rolId != null)
                    {
                        _routine = Routine.GetRoutineById(int.Parse(rolId.Rows[0][0].ToString()));
                        _father?.UpdateRoutines(null);
                        if (Question(@"¡Se ha registrado la rutina exitosamente! ¿Desea agregar otra?", @"Rutina agregada"))
                        {
                            txbNameRoutine.Clear();
                            txbDescriptionRoutine.Clear();
                        }
                        else
                        {
                            _edit = true;
                            UpdateControls();
                        }
                    }
                }
                else if (_edit)
                {
                    var query = $"UPDATE `routine` SET " +
                                   $"`nameRoutine` = '{nameRoutine}', " +
                                   $"`descriptionRoutine` = '{descriptionRoutine}' " +
                                   $"WHERE idRoutine = {_routine.IdRoutine}";
                    if (DbConnection.ejecutar(query))
                    {
                        _father?.UpdateRoutines("");
                        if (!Question($"¡Se ha modificado la rutina exitosamente! ¿Desea Salir?",
                            @"Rutina Guardada")) return;
                        this.Close();
                    }
                }
            }
        }
    }
}
