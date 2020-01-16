using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Währungsrechner
{
    public partial class Form1 : Form
    {
        XML_Adapter xml;
        List<ExchangeRate> ratesList;

        public Form1()
        {
            InitializeComponent();

            xml = new XML_Adapter();
            ReadData();

            foreach (var rate in from y in ratesList where y.Currency == "USD" select y)
                MessageBox.Show(rate.Rate.ToString());

            foreach (var rate in ratesList.Where(n => n.Currency == "USD"))
                MessageBox.Show(rate.Rate.ToString());
        }

        private void ReadData()
        {
            ratesList = xml.GetCurrentRates();
            cbx_currency.Items.Clear();
            foreach (ExchangeRate r in ratesList)
                cbx_currency.Items.Add(r.Currency);
            cbx_currency.SelectedIndex = 0;
        }

        private void btn_from_Click(object sender, EventArgs e)
        {
            double.TryParse(tbx_input.Text, out double input);
            double rate = 0;
            foreach (ExchangeRate r in ratesList)
                if (r.Currency == cbx_currency.Text)
                    rate = r.Rate;
            tbx_output.Text = (input * rate).ToString("0.00");
            la_output.Text = cbx_currency.Text + ":";
        }

        private void btn_to_Click(object sender, EventArgs e)
        {
            double.TryParse(tbx_input.Text, out double input);
            double rate = 0;
            foreach (ExchangeRate r in ratesList)
                if (r.Currency == cbx_currency.Text)
                    rate = r.Rate;
            tbx_output.Text = (input / rate).ToString("0.00");
            la_output.Text = "EUR:";
        }

        private void btn_database_Click(object sender, EventArgs e)
        {
            DatabaseForm dbForm = new DatabaseForm();
            dbForm.ShowDialog();
        }
    }
}
