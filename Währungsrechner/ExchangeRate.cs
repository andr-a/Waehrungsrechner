using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Währungsrechner
{
    class ExchangeRate
    {
        string currency;
        double rate;
        DateTime time;

        public ExchangeRate(string currency, double rate, DateTime time)
        {
            this.Currency = currency;
            this.Rate = rate;
            this.Time = time;
        }

        public string Currency { get => currency; set => currency = value; }
        public double Rate { get => rate; set => rate = value; }
        public DateTime Time { get => time; set => time = value; }

        public override string ToString() => String.Format("Time: {0}, Currency: {1}, Rate: {2}", Time.ToString("yyyy-MM-dd"), Currency, Rate);
    }
}
