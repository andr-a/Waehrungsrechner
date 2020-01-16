using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Währungsrechner
{
    public partial class DatabaseForm : Form
    {
        XML_Adapter xml;
        Database db;

        public DatabaseForm()
        {
            InitializeComponent();
            xml = new XML_Adapter();
            db = new Database();
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            db.DeleteData();
            db.WriteHistoric(xml);
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            db.CreateDB();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            db.DeleteData();
        }

        private void btn_drop_Click(object sender, EventArgs e)
        {
            db.DropDB();
        }
    }
}
