using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Cryptography
{
    public class DatabaseLoader
    {

        private const string connectSetting = "Host=localhost;Username=postgres;Password=123;Database=CryptographyHelp";
        public List<string> helpNames = new List<string>();
        public List<string> helpUrls = new List<string>();

        public (List<string> names, List<string> urls) LoadHelpData()
        {
            List<string> names = new List<string>();
            List<string> urls = new List<string>();

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
                            names.Add(reader.GetString(0));
                            urls.Add(reader.GetString(1));
                        }
                    }
                }

                return (names, urls);
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка БД: {exception.Message}");
                return (null, null);
            }
        }

        public void LoadHelpTopics(ListBox listBox)
        {
            listBox.Items.Clear();

            (helpNames, helpUrls) = LoadHelpData();

            if (helpNames == null || helpNames.Count == 0)
            {
                listBox.Items.Add("Нет данных. Проверьте Базу Данных.");
                return;
            }

            foreach (string name in helpNames)
            {
                listBox.Items.Add(name);
            }
        }

    }
}