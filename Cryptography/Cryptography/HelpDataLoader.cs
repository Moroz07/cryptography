using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Cryptography
{
    public class HelpDataLoader
    {

        private const string connectSetting = "Host=localhost;Username=postgres;Password=123;Database=CryptographyHelp";
        public List<string> helpNames = new List<string>();
        public List<string> helpUrls = new List<string>();

        public List<HelpItem> LoadHelpData()
        {
            List<HelpItem> items = new List<HelpItem>();

            try
            {
                using (var con = new NpgsqlConnection(connectSetting))
                {
                    con.Open();


                    string sql = "SELECT NameThemas, Url FROM help_contents ORDER BY NameThemas";

                    using (var cmd = new NpgsqlCommand(sql, con))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string title = reader.GetString(0);
                            string url = reader.GetString(1);
                            items.Add(new HelpItem(title, url));
                        }
                    }
                }

                return items;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка БД: {exception.Message}");
                return new List<HelpItem>();
            }
        }

        

    }
}