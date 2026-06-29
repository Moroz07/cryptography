using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public class PasswordGeneratePage : TabPage
    {
        private PasswordGenerator passwordGenerator = new PasswordGenerator();

        private CheckBox RussianSymbolCheckBox;
        private CheckBox EnglishSymbolCheckBox;
        private CheckBox NumbersCheckBox;
        private CheckBox SpecialSymbolCheckBox;
        private NumericUpDown LengthPasswordNumericUpDown;
        private Button GenerateButton;
        private RichTextBox GeneratePasswordRichTextBox;

        public event Action<string> PasswordGenerated;

        public PasswordGeneratePage()
        {
            this.Text = "Генерация пароля";
            this.Padding = new Padding(3);
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Label SymbolLabel = new Label();
            SymbolLabel.Text = "Выберите символы";
            SymbolLabel.Font = new Font("Times New Roman", 13.8F);
            SymbolLabel.Location = new Point(45, 38);
            SymbolLabel.Size = new Size(199, 26);
            this.Controls.Add(SymbolLabel);

            RussianSymbolCheckBox = new CheckBox();
            RussianSymbolCheckBox.Text = "Русские символы";
            RussianSymbolCheckBox.Font = new Font("Times New Roman", 13.8F);
            RussianSymbolCheckBox.Location = new Point(50, 86);
            RussianSymbolCheckBox.Size = new Size(203, 30);
            this.Controls.Add(RussianSymbolCheckBox);

            EnglishSymbolCheckBox = new CheckBox();
            EnglishSymbolCheckBox.Text = "Английские символы";
            EnglishSymbolCheckBox.Font = new Font("Times New Roman", 13.8F);
            EnglishSymbolCheckBox.Location = new Point(50, 138);
            EnglishSymbolCheckBox.Size = new Size(240, 30);
            this.Controls.Add(EnglishSymbolCheckBox);

            NumbersCheckBox = new CheckBox();
            NumbersCheckBox.Text = "Цифры (0-9)";
            NumbersCheckBox.Font = new Font("Times New Roman", 13.8F);
            NumbersCheckBox.Location = new Point(50, 189);
            NumbersCheckBox.Size = new Size(155, 30);
            this.Controls.Add(NumbersCheckBox);

            SpecialSymbolCheckBox = new CheckBox();
            SpecialSymbolCheckBox.Text = "Специальные символы ASCII";
            SpecialSymbolCheckBox.Font = new Font("Times New Roman", 13.8F);
            SpecialSymbolCheckBox.Location = new Point(50, 241);
            SpecialSymbolCheckBox.Size = new Size(321, 30);
            this.Controls.Add(SpecialSymbolCheckBox);

            Label LengthPasswordLabel = new Label();
            LengthPasswordLabel.Text = "Введите длину пароля";
            LengthPasswordLabel.Font = new Font("Times New Roman", 13.8F);
            LengthPasswordLabel.Location = new Point(50, 300);
            LengthPasswordLabel.Size = new Size(229, 26);
            this.Controls.Add(LengthPasswordLabel);

            LengthPasswordNumericUpDown = new NumericUpDown();
            LengthPasswordNumericUpDown.Font = new Font("Times New Roman", 13.8F);
            LengthPasswordNumericUpDown.Location = new Point(285, 300);
            LengthPasswordNumericUpDown.Minimum = 1;
            LengthPasswordNumericUpDown.Maximum = 80;
            LengthPasswordNumericUpDown.Size = new Size(100, 34);
            LengthPasswordNumericUpDown.Value = 1;
            this.Controls.Add(LengthPasswordNumericUpDown);

            GenerateButton = new Button();
            GenerateButton.Text = "Сгенерировать";
            GenerateButton.Font = new Font("Times New Roman", 13.8F);
            GenerateButton.Location = new Point(81, 376);
            GenerateButton.Size = new Size(225, 44);
            GenerateButton.Click += GenerateButton_Click;
            this.Controls.Add(GenerateButton);

            GeneratePasswordRichTextBox = new RichTextBox();
            GeneratePasswordRichTextBox.Font = new Font("Consolas", 18F);
            GeneratePasswordRichTextBox.Location = new Point(405, 200);
            GeneratePasswordRichTextBox.Size = new Size(534, 350);
            GeneratePasswordRichTextBox.ReadOnly = true;
            this.Controls.Add(GeneratePasswordRichTextBox);

            Label InfoLabel = new Label();
            InfoLabel.Text = "После генерации пароля вы можете посмотреть его надёжность во вкладке: Оценка пароля";
            InfoLabel.Font = new Font("Times New Roman", 7.8F);
            InfoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            InfoLabel.Location = new Point(56, 423);
            InfoLabel.Size = new Size(258, 52);
            this.Controls.Add(InfoLabel);
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

            if (password != null && password != "" && PasswordGenerated != null)
            {
                PasswordGenerated(password);
            }
        }
    }
}

