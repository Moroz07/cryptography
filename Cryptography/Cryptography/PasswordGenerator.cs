using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public class PasswordGenerator
    {
        private Random random = new Random();
        private string RussianSymbol = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
        private string EnglishSymbol = "abcdefghijklmnopqrstuvwxyz";
        private string numbers = "0123456789";
        private string SpecialSymbol = "`~!@#$%^&*()_+-= {}[]|\\:;\"'<>,.?/";

        public string GeneratePassword(int length, bool RussianSymbol, bool EnglishSymbol, bool Numbers, bool SpecialSymbol)
        {
            string selectedSymbols = "";
            if (RussianSymbol == true)
            {
                selectedSymbols += this.RussianSymbol;
            }
            if (EnglishSymbol == true)
            {
                selectedSymbols += this.EnglishSymbol;
            }
            if (Numbers == true)
            {
                selectedSymbols += this.numbers;
            }
            if (SpecialSymbol == true)
            {
                selectedSymbols += this.SpecialSymbol;
            }

            if (selectedSymbols.Length == 0)
            {
                MessageBox.Show("Ошибка: выберите хотя бы один тип символов", "Ошибка",
                    MessageBoxButtons.OK);
                return "";
            }

            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(selectedSymbols.Length);
                password[i] = selectedSymbols[index];
            }

            string result = new string(password);
            return result;

        }
    }
}