using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Währungsrechner
{
    class Currency
    {
        int currency_id;
        string currency_value;

        public Currency(int currency_id, string currency_value)
        {
            this.Currency_id = currency_id;
            this.Currency_value = currency_value;
        }

        public int Currency_id { get => currency_id; set => currency_id = value; }
        public string Currency_value { get => currency_value; set => currency_value = value; }

        public override string ToString() => String.Format("currency_id: {0}, currency_value: {1}", currency_id, currency_value);
    }
}
