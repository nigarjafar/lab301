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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void query_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name ="Sony";
            product.Price = 342;
            product.Description ="jshdz";
            product.Id = 1;
            product.update();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = name_textbox.Text;
            product.Price = Convert.ToInt32(price_textbox.Text);
            product.Description = desc_textbox.Text;
            product.save();
        }
    }
}
