using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class MainForm: Form
    {
        private PasswordGenerator passwordGenerator = new PasswordGenerator();
        private PasswordStrengthEvaluator passwordEvaluator = new PasswordStrengthEvaluator();
        private CaesarCipher caesarCipher = new CaesarCipher();
        private CaesarAnimation caesarAnimation = new CaesarAnimation();
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            int length = (int)LengthPasswordNumericUpDown.Value;

            bool useRussian = RussianSymbolCheckBox.Checked;
            bool useEnglish = EnglishSymbolCheckBox.Checked;
            bool useNumbers = NumbersCheckBox.Checked;
            bool useSpecials = SpecialSymbolCheckBox.Checked;

            string password = passwordGenerator.GeneratePassword(length, useRussian, useEnglish, useNumbers, useSpecials);

            GeneratePasswordRichTextBox.Text = password;

            if (password != "")
            {
                GeneratePasswordRichTextBox.Text = password;

                EvaluationResult result = passwordEvaluator.Evaluate(password);
                ResultRichTextBox.Text = $"Оценка: {result.ScoreValue} баллов ({result.ScoreLevel})\n\n{result.Details}";
            }

        }

        private void StrengthEvaluatorButton_Click(object sender, EventArgs e)
        {
            string password = PasswordUser.Text;

            EvaluationResult result = passwordEvaluator.Evaluate(password);
            ResultRichTextBox.Text = $"Оценка: {result.ScoreValue} баллов ({result.ScoreLevel})\n\n{result.Details}";

        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string text = CipherTextTextBox.Text;
            int shift = (int)numericUpDown1.Value;

            if (text == null || text == "")
            {
                MessageBox.Show("Ошибка: нечего дешифровать", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string decrypted = caesarCipher.Decrypt(text, shift);

            if (shift <= 20 && text.Length <= 50)
            {
                caesarAnimation.StartAnimation(text, decrypted, ResultRichTextBox2);
            }
            else
            {
                ResultRichTextBox2.Text = decrypted;
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string text = plainTextTextBox.Text;
            int shift = (int)numericUpDown1.Value;

            if (text == null || text == "")
            {
                MessageBox.Show("Ошибка: нечего шифровать", "Ошибка",
                    MessageBoxButtons.OK);
                return;
            }

            string encrypted = caesarCipher.Encrypt(text, shift);

            if (shift <= 20 && text.Length <= 50)
            {
                caesarAnimation.StartAnimation(text, encrypted, ResultRichTextBox2);
            }
            else
            {
                ResultRichTextBox2.Text = encrypted;
            }
        }
    }
}
