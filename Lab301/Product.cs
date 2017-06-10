using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab301
{
    class Product
    {
        public int Id;
        public string Name;
        public int Price;
        public string Description;
        private static string TableName = "products";


        public bool save()
        {
            Database db = new Database();
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["name"] = Name;
            data["price"] = Price.ToString();
            data["description"] = Description;

            return db.Insert(TableName, data);
           
        }

        public bool update()
        {
            Database db = new Database();
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["name"] = Name;
            data["price"] = Price.ToString();
            data["description"] = Description;

            return db.Update(TableName, data, Id);

        }

        public static DataTable getAll()
        {
            Database db = new Database();
            return db.Select(TableName);

        }

        public static Product getById(int id)
        {
            MessageBox.Show(id.ToString());
            Database db = new Database();
         
            
            DataTable dt = db.Select(TableName, "*", "id="+id);

            var row = dt.Rows[0];
            Product product = new Product();
            product.Id = Convert.ToInt32(row["id"]);
            product.Name = row["name"].ToString();
            product.Price = Convert.ToInt32(row["price"]);
            product.Description = row["description"].ToString();
            return product;
        }

        public static DataTable find(string columns, string query) {
            Database db = new Database();
            return db.Select(TableName, columns, query);
        }

        public bool Delete()
        {
            Database db = new Database();
            return db.Delete(TableName,Id);
            return true;
        }

    }
}
