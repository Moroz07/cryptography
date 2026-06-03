using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public class CaesarCipher
    {
        private string russianAlphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
        private string englishAlphabet = "abcdefghijklmnopqrstuvwxyz";
        private string numbers = "0123456789";

        private char ShiftChar(char c, int shift, string alphabet)
        {
            int index = alphabet.IndexOf(c);
            if (index == -1)
            {
                return c;
            }

            int newIndex = (index + shift) % alphabet.Length;
            if (newIndex < 0)
            {
                newIndex += alphabet.Length;
            }

            return alphabet[newIndex];
        }

        public string Encrypt(string plainText, int shift)
        {
            if (plainText == null || plainText == "")
            {
                return "Ошибка: нечего шифровать";
            }

            char[] result = new char[plainText.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                char symbol = plainText[i];

                char newChar = ShiftChar(symbol, shift, russianAlphabet);
                if (newChar != symbol)
                {
                    result[i] = newChar;
                    continue;
                }

                newChar = ShiftChar(symbol, shift, englishAlphabet);
                if (newChar != symbol)
                {
                    result[i] = newChar;
                    continue;
                }

                newChar = ShiftChar(symbol, shift, numbers);
                if (newChar != symbol)
                {
                    result[i] = newChar;
                    continue;
                }

                result[i] = symbol;
            }

            return new string(result);
        }

        public string Decrypt(string cipherText, int shift)
        {
            if (cipherText == null || cipherText == "")
            {
                return "Ошибка: нечего дешифровать";
            }

            return Encrypt(cipherText, -shift);
        }
    }
}
