using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab301
{
    public partial class Form2 : Form
    {
        private int product_id;
        private int row;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            products.DataSource = Product.getAll();
        }

        private void products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.row = e.RowIndex;
            this.product_id = Convert.ToInt32(products[0, e.RowIndex].Value);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Product product = Product.getById(product_id);
            MessageBox.Show(product.Id.ToString());
            product.Delete();

            products.DataSource = Product.getAll();
            products.Update();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Product product = Product.getById(product_id);
            product.Name = products.Rows[row].Cells["name"].Value.ToString();
            product.Description = products.Rows[row].Cells["description"].Value.ToString();
            product.Price = Convert.ToInt32(products.Rows[row].Cells["price"].Value);

            product.update();

            products.DataSource = Product.getAll();
            products.Update();

        }
    }
}
