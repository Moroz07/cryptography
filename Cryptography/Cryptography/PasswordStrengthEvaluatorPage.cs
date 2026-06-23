using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public class PasswordStrengthEvaluatorPage : TabPage
    {
        private PasswordStrengthEvaluator evaluator = new PasswordStrengthEvaluator();

        private TextBox PasswordUser;
        private Button StrengthEvaluatorButton;
        private RichTextBox ResultRichTextBox;

        public PasswordStrengthEvaluatorPage()
        {
            this.Text = "Оценка пароля";
            this.Padding = new Padding(3);
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Label PasswordLabel = new Label();
            PasswordLabel.Text = "Введите свой пароль";
            PasswordLabel.Font = new Font("Times New Roman", 13.8F);
            PasswordLabel.Location = new Point(60, 41);
            PasswordLabel.Size = new Size(215, 26);
            this.Controls.Add(PasswordLabel);

            PasswordUser = new TextBox();
            PasswordUser.Font = new Font("Times New Roman", 13.8F);
            PasswordUser.Location = new Point(324, 38);
            PasswordUser.Size = new Size(592, 39);
            PasswordUser.Multiline = true;
            this.Controls.Add(PasswordUser);

            StrengthEvaluatorButton = new Button();
            StrengthEvaluatorButton.Text = "Оценить";
            StrengthEvaluatorButton.Font = new Font("Microsoft Sans Serif", 13.8F);
            StrengthEvaluatorButton.Location = new Point(47, 375);
            StrengthEvaluatorButton.Size = new Size(193, 44);
            StrengthEvaluatorButton.Click += StrengthEvaluatorButton_Click;
            this.Controls.Add(StrengthEvaluatorButton);

            ResultRichTextBox = new RichTextBox();
            ResultRichTextBox.Font = new Font("Times New Roman", 13.8F);
            ResultRichTextBox.Location = new Point(324, 255);
            ResultRichTextBox.Size = new Size(608, 278);
            ResultRichTextBox.Enabled = false;
            this.Controls.Add(ResultRichTextBox);
        }

        private void StrengthEvaluatorButton_Click(object sender, EventArgs e)
        {
            string password = PasswordUser.Text;

            if (password == null || password == "")
            {
                MessageBox.Show("Ошибка: нечего оценивать. Введите пароль", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            EvaluationResult result = evaluator.Evaluate(password);
            ResultRichTextBox.Text = $"Оценка: {result.ScoreValue} баллов ({result.ScoreLevel})\n\n{result.Details}";
        }

        public void UpdateResult(string password)
        {
            if (password == null || password == "")
                return;

            EvaluationResult result = evaluator.Evaluate(password);
            ResultRichTextBox.Text = $"Оценка: {result.ScoreValue} баллов ({result.ScoreLevel})\n\n{result.Details}";
        }
    }
}

