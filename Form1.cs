using System.Windows.Forms;
using Kliens_Hajnyirok.Models;

namespace Kliens_Hajnyirok
{
    public partial class Form1 : Form
    {
        private DnnContext _context;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _context = new DnnContext();
            TermekListazas();
            LoadCategories();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void TermekListazas()
        {
            var termekek = (from t in _context.HccProductTranslations
                            join i in _context.HccProductInventories on t.ProductId equals i.ProductBvin
                            join p in _context.HccProducts on t.ProductId equals p.Bvin
                            select new
                            {
                                t.ProductId,
                                t.ProductName,
                                i.QuantityOnHand,
                                p.SitePrice
                            }).ToList();

            dataGridView1.DataSource = termekek;

            dataGridView1.Columns["ProductId"].Visible = false;
            dataGridView1.Columns["ProductName"].HeaderText = "Terméknév";
            dataGridView1.Columns["QuantityOnHand"].HeaderText = "Készlet";
            dataGridView1.Columns["SitePrice"].HeaderText = "Termékár";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "QuantityOnHand")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int quantity))
                {
                    if (quantity < 10)
                        e.CellStyle.ForeColor = Color.Red;
                    else if (quantity <= 25)
                        e.CellStyle.ForeColor = Color.Orange;
                    else
                        e.CellStyle.ForeColor = Color.Black;

                    e.CellStyle.SelectionForeColor = e.CellStyle.ForeColor;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "SitePrice")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal price))
                {
                    e.Value = decimal.Truncate(price).ToString("0");
                    e.FormattingApplied = true;
                }
            }
        }



        private void LoadCategories()
        {
            var categories = _context.HccCategoryTranslations
                .Select(c => new
                {
                    c.CategoryId,
                    c.Name
                })
                .ToList();

            categories.Insert(0, new { CategoryId = Guid.Empty, Name = "Összes termék" });

            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "CategoryId";

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;

            Guid selectedCategoryId = (Guid)comboBox1.SelectedValue;

            var termekek = (from t in _context.HccProductTranslations
                            join x in _context.HccProductXcategories on t.ProductId equals x.ProductId
                            join i in _context.HccProductInventories on t.ProductId equals i.ProductBvin
                            where x.CategoryId == selectedCategoryId
                            select new
                            {
                                t.ProductId,
                                t.ProductName,
                                i.QuantityOnHand
                            }).ToList();

            dataGridView1.DataSource = termekek;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filter = textBox1.Text.ToLower();

            var filteredData = (from t in _context.HccProductTranslations
                                join i in _context.HccProductInventories on t.ProductId equals i.ProductBvin
                                join p in _context.HccProducts on t.ProductId equals p.Bvin
                                where t.ProductName.ToLower().Contains(filter)
                                select new
                                {
                                    t.ProductId,
                                    t.ProductName,
                                    i.QuantityOnHand,
                                    p.SitePrice
                                }).ToList();

            dataGridView1.DataSource = filteredData;

            dataGridView1.Columns["ProductId"].Visible = false;
            dataGridView1.Columns["ProductName"].HeaderText = "Terméknév";
            dataGridView1.Columns["QuantityOnHand"].HeaderText = "Készlet";
            dataGridView1.Columns["SitePrice"].HeaderText = "Termékár";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Nincs kijelölt termék.");
                return;
            }

            if (!int.TryParse(textBox2.Text, out int hozzaadottDarab) || hozzaadottDarab <= 0)
            {
                MessageBox.Show("Adj meg érvényes pozitív számot!");
                return;
            }

            var productId = (Guid)dataGridView1.CurrentRow.Cells["ProductId"].Value;

            var inventory = _context.HccProductInventories.FirstOrDefault(i => i.ProductBvin == productId);

            if (inventory == null)
            {
                MessageBox.Show("Nem található inventory adat ehhez a termékhez.");
                return;
            }

            inventory.QuantityOnHand += hozzaadottDarab;
            inventory.QuantityAvailableForSale += hozzaadottDarab;

            _context.SaveChanges();

            MessageBox.Show("Készlet frissítve!");

            TermekListazas();
        }
    }
}
