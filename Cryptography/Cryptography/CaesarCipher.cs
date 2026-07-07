using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{

    // Класс реализует шифр Цезаря — метод шифрования, при котором каждый символ 
    // заменяется на другой, сдвинутый на фиксированное число позиций в алфавите.
    public class CaesarCipher
    {
        public static string russianAlphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
        public static string russianUpper = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public static string englishAlphabet = "abcdefghijklmnopqrstuvwxyz";
        public static string englishUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string numbers = "0123456789";
        public static string Specials = "`~!@#$%^&*()_+-= {}[]|\\:;\"'<>,.?/";
        
        // Сдвигает символ в пределах указанного алфавита
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

        // Шифрует текст методом Цезаря
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

                char newChar = ShiftChar(symbol, shift, russianUpper);
                if (newChar != symbol)
                {
                    result[i] = newChar;
                    continue;
                }

                newChar = ShiftChar(symbol, shift, russianAlphabet);
                if (newChar != symbol)
                {
                    result[i] = newChar;
                    continue;
                }

                newChar = ShiftChar(symbol, shift, englishUpper);
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


        // Дешифрует текст, зашифрованный шифром Цезаря
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