using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public class CipherPage : TabPage
    {
        private CaesarCipher caesarCipher = new CaesarCipher();
        private CaesarAnimation caesarAnimation = new CaesarAnimation();

        private TextBox plainTextTextBox;
        private TextBox CipherTextTextBox;
        private NumericUpDown NumberShiftNumericUpDown;
        private Button EncryptButton;
        private Button DecryptButton;
        private RichTextBox ResultRichTextBox2;

        public CipherPage()
        {
            this.Text = "Шифр Цезаря";
            this.Padding = new Padding(3);
            InitializeComponents();
        }

        private void InitializeComponents()
        {

            Label EncryptLabel = new Label();
            EncryptLabel.Text = "Введите текст для шифрования";
            EncryptLabel.Font = new Font("Times New Roman", 13.8F);
            EncryptLabel.Location = new Point(26, 35);
            EncryptLabel.Size = new Size(318, 26);
            this.Controls.Add(EncryptLabel);

            plainTextTextBox = new TextBox();
            plainTextTextBox.Font = new Font("Times New Roman", 13.8F);
            plainTextTextBox.Location = new Point(31, 81);
            plainTextTextBox.Size = new Size(358, 44);
            plainTextTextBox.Multiline = true;
            this.Controls.Add(plainTextTextBox);

            Label DecryptLabel = new Label();
            DecryptLabel.Text = "Введите текст для расшифрования";
            DecryptLabel.Font = new Font("Times New Roman", 13.8F);
            DecryptLabel.Location = new Point(467, 35);
            DecryptLabel.Size = new Size(350, 26);
            this.Controls.Add(DecryptLabel);

            CipherTextTextBox = new TextBox();
            CipherTextTextBox.Font = new Font("Times New Roman", 13.8F);
            CipherTextTextBox.Location = new Point(472, 81);
            CipherTextTextBox.Size = new Size(421, 44);
            CipherTextTextBox.Multiline = true;
            this.Controls.Add(CipherTextTextBox);

            // Сдвиг
            Label ShiftLabel = new Label();
            ShiftLabel.Text = "Введите длину шага";
            ShiftLabel.Font = new Font("Times New Roman", 13.8F);
            ShiftLabel.Location = new Point(41, 190);
            ShiftLabel.Size = new Size(208, 26);
            this.Controls.Add(ShiftLabel);

            NumberShiftNumericUpDown = new NumericUpDown();
            NumberShiftNumericUpDown.Font = new Font("Times New Roman", 13.8F);
            NumberShiftNumericUpDown.Location = new Point(274, 190);
            NumberShiftNumericUpDown.Minimum = 1;
            NumberShiftNumericUpDown.Maximum = 10000;
            NumberShiftNumericUpDown.Size = new Size(167, 34);
            NumberShiftNumericUpDown.Value = 1;
            this.Controls.Add(NumberShiftNumericUpDown);

            EncryptButton = new Button();
            EncryptButton.Text = "Зашифровать";
            EncryptButton.Font = new Font("Times New Roman", 13.8F);
            EncryptButton.Location = new Point(46, 302);
            EncryptButton.Size = new Size(192, 43);
            EncryptButton.Click += EncryptButton_Click;
            this.Controls.Add(EncryptButton);

            DecryptButton = new Button();
            DecryptButton.Text = "Расшифровать";
            DecryptButton.Font = new Font("Times New Roman", 13.8F);
            DecryptButton.Location = new Point(249, 302);
            DecryptButton.Size = new Size(192, 43);
            DecryptButton.Click += DecryptButton_Click;
            this.Controls.Add(DecryptButton);

            ResultRichTextBox2 = new RichTextBox();
            ResultRichTextBox2.Font = new Font("Times New Roman", 13.8F);
            ResultRichTextBox2.Location = new Point(3, 377);
            ResultRichTextBox2.Size = new Size(929, 156);
            ResultRichTextBox2.ReadOnly = true;
            this.Controls.Add(ResultRichTextBox2);
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string text = plainTextTextBox.Text;
            int shift = (int)NumberShiftNumericUpDown.Value;

            if (text == null || text == "")
            {
                MessageBox.Show("Ошибка: нечего шифровать", "Ошибка", MessageBoxButtons.OK);
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

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string text = CipherTextTextBox.Text;
            int shift = (int)NumberShiftNumericUpDown.Value;

            if (text == null || text == "")
            {
                MessageBox.Show("Ошибка: нечего дешифровать", "Ошибка", MessageBoxButtons.OK);
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
    }
}
