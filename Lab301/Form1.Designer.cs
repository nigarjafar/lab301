namespace Lab301
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.desc_textbox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.Label();
            this.query = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(231, 85);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_textbox.TabIndex = 0;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(231, 130);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(100, 20);
            this.price_textbox.TabIndex = 1;
            // 
            // desc_textbox
            // 
            this.desc_textbox.Location = new System.Drawing.Point(231, 183);
            this.desc_textbox.Name = "desc_textbox";
            this.desc_textbox.Size = new System.Drawing.Size(100, 20);
            this.desc_textbox.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(116, 85);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 3;
            this.name.Text = "Name";
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Location = new System.Drawing.Point(116, 190);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(60, 13);
            this.Desc.TabIndex = 4;
            this.Desc.Text = "Description";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(116, 137);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 5;
            this.Price.Text = "Price";
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Location = new System.Drawing.Point(228, 30);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(44, 13);
            this.Product.TabIndex = 6;
            this.Product.Text = "Product";
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(437, 319);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(75, 23);
            this.query.TabIndex = 7;
            this.query.Text = "query";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(231, 261);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 399);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.query);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.name);
            this.Controls.Add(this.desc_textbox);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.name_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox desc_textbox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.Button Submit;
    }
}

