using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public class CaesarAnimation
    {
        private Timer animationTimer;
        private int currentCharIndex; 
        private int currentShiftStep;
        private string originalText;
        private string encryptedText;
        private RichTextBox targetTextBox;
        private int animationSpeed = 200;

        // Запускает анимацию пошагового вывода зашифрованного текста
        public void StartAnimation(string original, string encrypted, RichTextBox target)
        {
            originalText = original;
            encryptedText = encrypted;
            targetTextBox = target;
            currentCharIndex = 0;
            currentShiftStep = 0;


            animationTimer = new Timer();
            animationTimer.Interval = animationSpeed;
            animationTimer.Tick += OnTimerTick;
            animationTimer.Start();
        }

        // Останавливает анимацию
        public void StopAnimation()
        {
            if (animationTimer != null)
            {
                animationTimer.Stop();
                animationTimer.Dispose();
                animationTimer = null;
            }
        }


        private void OnTimerTick(object sender, EventArgs e)
        {
            if (currentCharIndex >= encryptedText.Length)
            {
                StopAnimation();
                return;
            }
            char originalChar = originalText[currentCharIndex];
            char finalChar = encryptedText[currentCharIndex];

            // Получаем все промежуточные буквы
            string steps = GetShiftSteps(originalChar, finalChar);

            if (currentShiftStep < steps.Length)
            {
                // Показываем промежуточную букву
                char currentChar = steps[currentShiftStep];
                string currentText = targetTextBox.Text;

                // Находим позицию текущего символа в тексте
                if (currentText.Length <= currentCharIndex)
                {
                    targetTextBox.Text += currentChar;
                }
                else
                {
                    targetTextBox.Text = currentText.Substring(0, currentCharIndex) + currentChar;
                }

                currentShiftStep++;
            }
            else
            {
                currentCharIndex++;
                currentShiftStep = 0;
            }
        }

            private string GetShiftSteps(char original, char final)
            {
            string alphabet = GetAlphabet(original);
            if (alphabet == "") return final.ToString();

            int startIndex = alphabet.IndexOf(original);
            int endIndex = alphabet.IndexOf(final);

            if (startIndex == -1 || endIndex == -1) return final.ToString();

            int stepsCount = Math.Abs(endIndex - startIndex);

            string result = "";

            if (endIndex > startIndex)
            {
                for (int i = startIndex + 1; i <= endIndex; i++)
                    result += alphabet[i];
            }
            else if (endIndex < startIndex)
            {
                for (int i = startIndex - 1; i >= endIndex; i--)
                    result += alphabet[i];
            }

            return result;
            }
        private string GetAlphabet(char c)
        {
            if (CaesarCipher.russianAlphabet.Contains(c)) return CaesarCipher.russianAlphabet;
            if (CaesarCipher.russianUpper.Contains(c)) return CaesarCipher.russianUpper;
            if (CaesarCipher.englishAlphabet.Contains(c)) return CaesarCipher.englishAlphabet;
            if (CaesarCipher.englishUpper.Contains(c)) return CaesarCipher.englishUpper;
            if (CaesarCipher.numbers.Contains(c)) return CaesarCipher.numbers;
            return "";
        }
    }
}