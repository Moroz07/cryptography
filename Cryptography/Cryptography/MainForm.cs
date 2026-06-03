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
    }
}
