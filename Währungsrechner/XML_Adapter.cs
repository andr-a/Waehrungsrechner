using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Währungsrechner
{
    class XML_Adapter
    {
        XmlDocument doc = new XmlDocument();

        public List<ExchangeRate> loadXML()
        {
            //doc.Load("https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml?9d06615cceb9daeb83fde752b6d5732b"); // daily
            doc.Load("https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml?9d06615cceb9daeb83fde752b6d5732b"); // hist
            List <ExchangeRate> rates = new List<ExchangeRate>();

            foreach (XmlNode xmlNode in doc.DocumentElement.ChildNodes[2])
            {
                DateTime time = Convert.ToDateTime(xmlNode.Attributes["time"].Value);

                foreach (XmlNode xmlNode1 in xmlNode.ChildNodes)
                {
                    ExchangeRate rate = new ExchangeRate(
                        xmlNode1.Attributes["currency"].Value,
                        Convert.ToDouble(xmlNode1.Attributes["rate"].Value.Replace('.', ',')),
                        time
                        );
                    rates.Add(rate);
                    //MessageBox.Show(rate.ToString());

                }
            }

            return rates;
        }

        public List<ExchangeRate> GetCurrentRates()
        {
            //doc.Load("https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml?9d06615cceb9daeb83fde752b6d5732b"); // daily
            doc.Load("https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml?9d06615cceb9daeb83fde752b6d5732b"); // hist
            List<ExchangeRate> rates = new List<ExchangeRate>();

            DateTime time = Convert.ToDateTime(doc.DocumentElement.ChildNodes[2].ChildNodes[0].Attributes["time"].Value);

            foreach (XmlNode xmlNode1 in doc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
            {
                ExchangeRate rate = new ExchangeRate(
                    xmlNode1.Attributes["currency"].Value,
                    Convert.ToDouble(xmlNode1.Attributes["rate"].Value.Replace('.', ',')),
                    time
                    );
                rates.Add(rate);
                //MessageBox.Show(rate.ToString());

            }
            
            return rates;
        }
    }
}
