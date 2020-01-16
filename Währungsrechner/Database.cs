using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Währungsrechner
{
    class Database
    {
        MySqlConnection con = new MySqlConnection("SERVER=localhost;UID=root;Password=root;DATABASE=waehrungsrechner;");
        MySqlCommand com;
        //List<RatesDate> datesList = new List<RatesDate>();
        //List<Currency> currenciesList = new List<Currency>();

        private void OpenDB()
        {
            con.Open();
        }

        private void CloseDB()
        {
            if (con != null)
                con.Close();
        }

        public void WriteHistoric(XML_Adapter xml)
        {
            List<ExchangeRate> ratesList = xml.loadXML();
            List<ExchangeRate> currRates = xml.GetCurrentRates();

            DateTime time = DateTime.MinValue;
            string currencyStr = "";
            string sql = "";

            try
            {
                OpenDB();
                com = con.CreateCommand();

                foreach (var rate in ratesList)
                {
                    if (time != rate.Time)
                    {
                        time = rate.Time;
                        sql = String.Format("INSERT INTO tbl_date VALUES (null, '{0}');", time.ToString("yyyy-MM-dd"));
                        com.CommandText = sql;
                        com.ExecuteNonQuery();
                    }
                }

                foreach (var rate in currRates)
                {
                    if (currencyStr != rate.Currency)
                    {
                        currencyStr = rate.Currency;
                        sql = String.Format("INSERT INTO tbl_currency VALUES (null, '{0}');", currencyStr);
                        com.CommandText = sql;
                        com.ExecuteNonQuery();
                    } 
                }
                //ratesList.Clear();
                //currRates.Clear();

                CloseDB();


                //GetDatesAndCurrencies();
                List<RatesDate> datesList = GetDates();
                List<Currency> currenciesList = GetCurrencies();

                OpenDB();
                foreach (var rate in ratesList)
                {
                    int fk_date_id = -1;
                    int fk_currency_id = -1;

                    foreach (RatesDate rateDate in datesList)
                        if (rate.Time == rateDate.Date_value)
                            fk_date_id = rateDate.Date_id;

                    foreach (Currency currency in currenciesList)
                        if (rate.Currency == currency.Currency_value)
                            fk_currency_id = currency.Currency_id;

                    sql = String.Format("INSERT INTO tbl_rate VALUES (null, {0}, {1}, {2});", fk_date_id.ToString(), fk_currency_id.ToString(), rate.Rate.ToString().Replace(',','.'));
                    com.CommandText = sql;
                    com.ExecuteNonQuery();

                    //datesList.Clear();
                    //currenciesList.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("WDB: " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
        }

        private int GetMaxDateId()
        {
            int maxDateId = 0;
            bool opened = false;
            try
            {
                if (con == null)
                {
                    OpenDB();
                    opened = true;
                }
                  
                com = con.CreateCommand();

                com.CommandText = "SELECT MAX(date_id) FROM tbl_date;";
                MySqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                    maxDateId = reader.GetInt32(0);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("GMDI: " + ex.Message);
            }
            finally
            {
                if (opened == true)
                    CloseDB();
            }
            return maxDateId;
        }

        private List<RatesDate> GetDates()
        {
            List<RatesDate> datesList = new List<RatesDate>();
            //bool opened = false;
            try
            {
                //if (con == null)
                //{
                    OpenDB();
                //    opened = true;
                //}

                com = con.CreateCommand();
                com.CommandText = "SELECT * FROM tbl_date;";

                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    RatesDate ratesDate = new RatesDate(
                        reader.GetInt32(0),
                        !reader.IsDBNull(1) ? reader.GetDateTime(1) : DateTime.MinValue
                        );
                    datesList.Add(ratesDate);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("GD: " + ex.Message);
            }
            finally
            {
                //if (opened == true)
                    CloseDB();
            }
            return datesList;
        }

        private int GetMaxCurrencyId()
        {
            int maxCurrencyId = 0;
            bool opened = false;
            try
            {
                if (con == null)
                {
                    OpenDB();
                    opened = true;
                }

                com = con.CreateCommand();

                com.CommandText = "SELECT MAX(currency_id) FROM tbl_currency;";
                MySqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                    maxCurrencyId = reader.GetInt32(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("GMCI: " + ex.Message);
            }
            finally
            {
                if (opened == true)
                    CloseDB();
            }
            return maxCurrencyId;
        }

        private List<Currency> GetCurrencies()
        {
            List<Currency> currenciesList = new List<Currency>();
            //bool opened = false;
            try
            {
                //if (con == null)
                //{
                    OpenDB();
                //    opened = true;
                //}

                com = con.CreateCommand();
                com.CommandText = "SELECT * FROM tbl_currency;";

                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Currency currency = new Currency(
                        reader.GetInt32(0),
                        !reader.IsDBNull(1) ? reader.GetString(1) :""
                        );
                    currenciesList.Add(currency);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("GC: " + ex.Message);
            }
            finally
            {
                //if (opened == true)
                    CloseDB();
            }
            return currenciesList;
        }

        /*private void GetDatesAndCurrencies()
        {

            bool opened = false;
            try
            {
                if (con == null)
                {
                    OpenDB();
                    opened = true;
                }

                com = con.CreateCommand();
                com.CommandText = "SELECT * FROM tbl_date;";

                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    RatesDate ratesDate = new RatesDate(
                        reader.GetInt32(0),
                        !reader.IsDBNull(1) ? reader.GetDateTime(1) : DateTime.MinValue
                        );
                    datesList.Add(ratesDate);
                }

                com.CommandText = "SELECT * FROM tbl_currency;";
                reader = com.ExecuteReader();

                while (reader.Read())
                {
                    Currency currency = new Currency(
                        reader.GetInt32(0),
                        !reader.IsDBNull(1) ? reader.GetString(1) : ""
                        );
                    currenciesList.Add(currency);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("GDaC: " + ex.Message);
            }
            finally
            {
                if (opened == true)
                    CloseDB();
            }
        }*/

        public void DropDB()
        {
            try
            {
                OpenDB();
                com = con.CreateCommand();
                com.CommandText = "DROP DATABASE waehrungsrechner;";
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("DDB: " + ex.Message);
            }
            finally
            {
                    CloseDB();
            }
        }

        public void CreateDB()
        {
            MySqlConnection create = new MySqlConnection("SERVER=localhost;UID=root;Password=root;");

            try
            {
                create.Open();
                MySqlCommand createCom = create.CreateCommand();
                createCom.CommandText = @"CREATE DATABASE IF NOT EXISTS Waehrungsrechner;
                    USE Waehrungsrechner;
                    CREATE TABLE IF NOT EXISTS tbl_date (date_id INT AUTO_INCREMENT PRIMARY KEY, date_value DATE);
                    CREATE TABLE IF NOT EXISTS tbl_currency (currency_id INT AUTO_INCREMENT PRIMARY KEY, currency_value VARCHAR(3));
                    CREATE TABLE IF NOT EXISTS tbl_rate (rate_id INT AUTO_INCREMENT PRIMARY KEY, fk_date_id INT, fk_currency_id INT, rate_value DOUBLE);
                    ALTER TABLE tbl_rate ADD FOREIGN KEY (fk_date_id) REFERENCES tbl_date (date_id);
                    ALTER TABLE tbl_rate ADD FOREIGN KEY (fk_currency_id) REFERENCES tbl_currency (currency_id);
                    CREATE VIEW v_rate AS
                    SELECT date_value, currency_value, rate_value
                    FROM tbl_rate
                    JOIN tbl_date ON fk_date_id = date_id
                    JOIN tbl_currency ON fk_currency_id = currency_id;";
                createCom.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("CDB: " + ex.Message);
            }
            finally
            {
                create.Close();
            }
        }

        public void DeleteData()
        {
            try
            {
                OpenDB();
                com = con.CreateCommand();
                //com.CommandText = @"DELETE FROM tbl_rate;
                //    DELETE FROM tbl_date;
                //    DELETE FROM tbl_currency;";

                com.CommandText = @"DROP TABLE tbl_rate;
                    TRUNCATE tbl_date;
                    TRUNCATE tbl_currency;
                    CREATE TABLE IF NOT EXISTS tbl_rate (rate_id INT AUTO_INCREMENT PRIMARY KEY, fk_date_id INT, fk_currency_id INT, rate_value DOUBLE);
                    ALTER TABLE tbl_rate ADD FOREIGN KEY (fk_date_id) REFERENCES tbl_date (date_id);
                    ALTER TABLE tbl_rate ADD FOREIGN KEY (fk_currency_id) REFERENCES tbl_currency (currency_id);";
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("DDB: " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
        }
    }
}
