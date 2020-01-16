using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Währungsrechner
{
    class RatesDate
    {
        int date_id;
        DateTime date_value;

        public RatesDate(int date_id, DateTime date_value)
        {
            this.Date_id = date_id;
            this.Date_value = date_value;
        }

        public int Date_id { get => date_id; set => date_id = value; }
        public DateTime Date_value { get => date_value; set => date_value = value; }

        public override string ToString() => String.Format("date_id: {0}, date_value: {1}", date_id, date_value);
    }
}
