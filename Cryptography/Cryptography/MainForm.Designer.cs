namespace Cryptography
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.PasswordGeneratePage = new System.Windows.Forms.TabPage();
            this.LengthPasswordNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GeneratePasswordRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SpecialSymbolCheckBox = new System.Windows.Forms.CheckBox();
            this.NumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.EnglishSymbolCheckBox = new System.Windows.Forms.CheckBox();
            this.RussianSymbolCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordStrengthEvaluatorPage = new System.Windows.Forms.TabPage();
            this.ResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PasswordUser = new System.Windows.Forms.TextBox();
            this.StrengthEvaluatorButton = new System.Windows.Forms.Button();
            this.CipherPage = new System.Windows.Forms.TabPage();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.ResultRichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CipherTextTextBox = new System.Windows.Forms.TextBox();
            this.plainTextTextBox = new System.Windows.Forms.TextBox();
            this.HelpPage = new System.Windows.Forms.TabPage();
            this.OpenUrlButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ChoiceThemasListBox = new System.Windows.Forms.ListBox();
            this.mainTabControl.SuspendLayout();
            this.PasswordGeneratePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthPasswordNumericUpDown)).BeginInit();
            this.PasswordStrengthEvaluatorPage.SuspendLayout();
            this.CipherPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.HelpPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.PasswordGeneratePage);
            this.mainTabControl.Controls.Add(this.PasswordStrengthEvaluatorPage);
            this.mainTabControl.Controls.Add(this.CipherPage);
            this.mainTabControl.Controls.Add(this.HelpPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(943, 565);
            this.mainTabControl.TabIndex = 0;
            // 
            // PasswordGeneratePage
            // 
            this.PasswordGeneratePage.Controls.Add(this.LengthPasswordNumericUpDown);
            this.PasswordGeneratePage.Controls.Add(this.GeneratePasswordRichTextBox);
            this.PasswordGeneratePage.Controls.Add(this.GenerateButton);
            this.PasswordGeneratePage.Controls.Add(this.SpecialSymbolCheckBox);
            this.PasswordGeneratePage.Controls.Add(this.NumbersCheckBox);
            this.PasswordGeneratePage.Controls.Add(this.EnglishSymbolCheckBox);
            this.PasswordGeneratePage.Controls.Add(this.RussianSymbolCheckBox);
            this.PasswordGeneratePage.Location = new System.Drawing.Point(4, 25);
            this.PasswordGeneratePage.Name = "PasswordGeneratePage";
            this.PasswordGeneratePage.Padding = new System.Windows.Forms.Padding(3);
            this.PasswordGeneratePage.Size = new System.Drawing.Size(935, 536);
            this.PasswordGeneratePage.TabIndex = 2;
            this.PasswordGeneratePage.Text = "Генерация пароля";
            this.PasswordGeneratePage.UseVisualStyleBackColor = true;
            // 
            // LengthPasswordNumericUpDown
            // 
            this.LengthPasswordNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthPasswordNumericUpDown.Location = new System.Drawing.Point(598, 100);
            this.LengthPasswordNumericUpDown.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.LengthPasswordNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthPasswordNumericUpDown.Name = "LengthPasswordNumericUpDown";
            this.LengthPasswordNumericUpDown.Size = new System.Drawing.Size(167, 34);
            this.LengthPasswordNumericUpDown.TabIndex = 6;
            this.LengthPasswordNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GeneratePasswordRichTextBox
            // 
            this.GeneratePasswordRichTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneratePasswordRichTextBox.Location = new System.Drawing.Point(405, 322);
            this.GeneratePasswordRichTextBox.Name = "GeneratePasswordRichTextBox";
            this.GeneratePasswordRichTextBox.Size = new System.Drawing.Size(534, 214);
            this.GeneratePasswordRichTextBox.TabIndex = 5;
            this.GeneratePasswordRichTextBox.Text = "";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(134, 380);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(225, 44);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Сгенерировать";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // SpecialSymbolCheckBox
            // 
            this.SpecialSymbolCheckBox.AutoSize = true;
            this.SpecialSymbolCheckBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecialSymbolCheckBox.Location = new System.Drawing.Point(60, 199);
            this.SpecialSymbolCheckBox.Name = "SpecialSymbolCheckBox";
            this.SpecialSymbolCheckBox.Size = new System.Drawing.Size(321, 30);
            this.SpecialSymbolCheckBox.TabIndex = 3;
            this.SpecialSymbolCheckBox.Text = "Специальные символы ASCII";
            this.SpecialSymbolCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumbersCheckBox
            // 
            this.NumbersCheckBox.AutoSize = true;
            this.NumbersCheckBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumbersCheckBox.Location = new System.Drawing.Point(60, 147);
            this.NumbersCheckBox.Name = "NumbersCheckBox";
            this.NumbersCheckBox.Size = new System.Drawing.Size(155, 30);
            this.NumbersCheckBox.TabIndex = 2;
            this.NumbersCheckBox.Text = "Цифры (0-9)";
            this.NumbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnglishSymbolCheckBox
            // 
            this.EnglishSymbolCheckBox.AutoSize = true;
            this.EnglishSymbolCheckBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnglishSymbolCheckBox.Location = new System.Drawing.Point(60, 96);
            this.EnglishSymbolCheckBox.Name = "EnglishSymbolCheckBox";
            this.EnglishSymbolCheckBox.Size = new System.Drawing.Size(240, 30);
            this.EnglishSymbolCheckBox.TabIndex = 1;
            this.EnglishSymbolCheckBox.Text = "Английские символы";
            this.EnglishSymbolCheckBox.UseVisualStyleBackColor = true;
            // 
            // RussianSymbolCheckBox
            // 
            this.RussianSymbolCheckBox.AutoSize = true;
            this.RussianSymbolCheckBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RussianSymbolCheckBox.Location = new System.Drawing.Point(60, 44);
            this.RussianSymbolCheckBox.Name = "RussianSymbolCheckBox";
            this.RussianSymbolCheckBox.Size = new System.Drawing.Size(203, 30);
            this.RussianSymbolCheckBox.TabIndex = 0;
            this.RussianSymbolCheckBox.Text = "Русские символы";
            this.RussianSymbolCheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordStrengthEvaluatorPage
            // 
            this.PasswordStrengthEvaluatorPage.Controls.Add(this.ResultRichTextBox);
            this.PasswordStrengthEvaluatorPage.Controls.Add(this.PasswordUser);
            this.PasswordStrengthEvaluatorPage.Controls.Add(this.StrengthEvaluatorButton);
            this.PasswordStrengthEvaluatorPage.Location = new System.Drawing.Point(4, 25);
            this.PasswordStrengthEvaluatorPage.Name = "PasswordStrengthEvaluatorPage";
            this.PasswordStrengthEvaluatorPage.Padding = new System.Windows.Forms.Padding(3);
            this.PasswordStrengthEvaluatorPage.Size = new System.Drawing.Size(935, 536);
            this.PasswordStrengthEvaluatorPage.TabIndex = 3;
            this.PasswordStrengthEvaluatorPage.Text = "Оценка пароля";
            this.PasswordStrengthEvaluatorPage.UseVisualStyleBackColor = true;
            // 
            // ResultRichTextBox
            // 
            this.ResultRichTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultRichTextBox.Location = new System.Drawing.Point(324, 255);
            this.ResultRichTextBox.Name = "ResultRichTextBox";
            this.ResultRichTextBox.Size = new System.Drawing.Size(608, 278);
            this.ResultRichTextBox.TabIndex = 2;
            this.ResultRichTextBox.Text = "";
            // 
            // PasswordUser
            // 
            this.PasswordUser.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordUser.Location = new System.Drawing.Point(8, 31);
            this.PasswordUser.Multiline = true;
            this.PasswordUser.Name = "PasswordUser";
            this.PasswordUser.Size = new System.Drawing.Size(572, 39);
            this.PasswordUser.TabIndex = 1;
            // 
            // StrengthEvaluatorButton
            // 
            this.StrengthEvaluatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StrengthEvaluatorButton.Location = new System.Drawing.Point(47, 375);
            this.StrengthEvaluatorButton.Name = "StrengthEvaluatorButton";
            this.StrengthEvaluatorButton.Size = new System.Drawing.Size(193, 44);
            this.StrengthEvaluatorButton.TabIndex = 0;
            this.StrengthEvaluatorButton.Text = "Оценить";
            this.StrengthEvaluatorButton.UseVisualStyleBackColor = true;
            this.StrengthEvaluatorButton.Click += new System.EventHandler(this.StrengthEvaluatorButton_Click);
            // 
            // CipherPage
            // 
            this.CipherPage.Controls.Add(this.DecryptButton);
            this.CipherPage.Controls.Add(this.EncryptButton);
            this.CipherPage.Controls.Add(this.ResultRichTextBox2);
            this.CipherPage.Controls.Add(this.numericUpDown1);
            this.CipherPage.Controls.Add(this.CipherTextTextBox);
            this.CipherPage.Controls.Add(this.plainTextTextBox);
            this.CipherPage.Location = new System.Drawing.Point(4, 25);
            this.CipherPage.Name = "CipherPage";
            this.CipherPage.Padding = new System.Windows.Forms.Padding(3);
            this.CipherPage.Size = new System.Drawing.Size(935, 536);
            this.CipherPage.TabIndex = 4;
            this.CipherPage.Text = "Шифр Цезаря";
            this.CipherPage.UseVisualStyleBackColor = true;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecryptButton.Location = new System.Drawing.Point(343, 302);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(192, 43);
            this.DecryptButton.TabIndex = 5;
            this.DecryptButton.Text = "Расшифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptButton.Location = new System.Drawing.Point(46, 302);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(192, 43);
            this.EncryptButton.TabIndex = 4;
            this.EncryptButton.Text = "Зашифровать";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // ResultRichTextBox2
            // 
            this.ResultRichTextBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResultRichTextBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultRichTextBox2.Location = new System.Drawing.Point(3, 377);
            this.ResultRichTextBox2.Name = "ResultRichTextBox2";
            this.ResultRichTextBox2.Size = new System.Drawing.Size(929, 156);
            this.ResultRichTextBox2.TabIndex = 3;
            this.ResultRichTextBox2.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(31, 189);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(167, 34);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CipherTextTextBox
            // 
            this.CipherTextTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CipherTextTextBox.Location = new System.Drawing.Point(472, 81);
            this.CipherTextTextBox.Multiline = true;
            this.CipherTextTextBox.Name = "CipherTextTextBox";
            this.CipherTextTextBox.Size = new System.Drawing.Size(421, 44);
            this.CipherTextTextBox.TabIndex = 1;
            // 
            // plainTextTextBox
            // 
            this.plainTextTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plainTextTextBox.Location = new System.Drawing.Point(31, 81);
            this.plainTextTextBox.Multiline = true;
            this.plainTextTextBox.Name = "plainTextTextBox";
            this.plainTextTextBox.Size = new System.Drawing.Size(358, 44);
            this.plainTextTextBox.TabIndex = 0;
            // 
            // HelpPage
            // 
            this.HelpPage.Controls.Add(this.OpenUrlButton);
            this.HelpPage.Controls.Add(this.textBox1);
            this.HelpPage.Controls.Add(this.ChoiceThemasListBox);
            this.HelpPage.Location = new System.Drawing.Point(4, 25);
            this.HelpPage.Name = "HelpPage";
            this.HelpPage.Padding = new System.Windows.Forms.Padding(3);
            this.HelpPage.Size = new System.Drawing.Size(935, 536);
            this.HelpPage.TabIndex = 5;
            this.HelpPage.Text = "Справка";
            this.HelpPage.UseVisualStyleBackColor = true;
            // 
            // OpenUrlButton
            // 
            this.OpenUrlButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenUrlButton.Location = new System.Drawing.Point(428, 372);
            this.OpenUrlButton.Name = "OpenUrlButton";
            this.OpenUrlButton.Size = new System.Drawing.Size(211, 52);
            this.OpenUrlButton.TabIndex = 2;
            this.OpenUrlButton.Text = "Открыть";
            this.OpenUrlButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(205, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(707, 37);
            this.textBox1.TabIndex = 1;
            // 
            // ChoiceThemasListBox
            // 
            this.ChoiceThemasListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChoiceThemasListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceThemasListBox.FormattingEnabled = true;
            this.ChoiceThemasListBox.ItemHeight = 22;
            this.ChoiceThemasListBox.Items.AddRange(new object[] {
            "Ссылки"});
            this.ChoiceThemasListBox.Location = new System.Drawing.Point(3, 3);
            this.ChoiceThemasListBox.Name = "ChoiceThemasListBox";
            this.ChoiceThemasListBox.Size = new System.Drawing.Size(196, 530);
            this.ChoiceThemasListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 565);
            this.Controls.Add(this.mainTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Генератор случайных паролей";
            this.mainTabControl.ResumeLayout(false);
            this.PasswordGeneratePage.ResumeLayout(false);
            this.PasswordGeneratePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthPasswordNumericUpDown)).EndInit();
            this.PasswordStrengthEvaluatorPage.ResumeLayout(false);
            this.PasswordStrengthEvaluatorPage.PerformLayout();
            this.CipherPage.ResumeLayout(false);
            this.CipherPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.HelpPage.ResumeLayout(false);
            this.HelpPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage PasswordGeneratePage;
        private System.Windows.Forms.TabPage PasswordStrengthEvaluatorPage;
        private System.Windows.Forms.TabPage CipherPage;
        private System.Windows.Forms.TabPage HelpPage;
        private System.Windows.Forms.RichTextBox GeneratePasswordRichTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox SpecialSymbolCheckBox;
        private System.Windows.Forms.CheckBox NumbersCheckBox;
        private System.Windows.Forms.CheckBox EnglishSymbolCheckBox;
        private System.Windows.Forms.CheckBox RussianSymbolCheckBox;
        private System.Windows.Forms.RichTextBox ResultRichTextBox;
        private System.Windows.Forms.TextBox PasswordUser;
        private System.Windows.Forms.Button StrengthEvaluatorButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox CipherTextTextBox;
        private System.Windows.Forms.TextBox plainTextTextBox;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.RichTextBox ResultRichTextBox2;
        private System.Windows.Forms.ListBox ChoiceThemasListBox;
        private System.Windows.Forms.Button OpenUrlButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown LengthPasswordNumericUpDown;
    }
}

