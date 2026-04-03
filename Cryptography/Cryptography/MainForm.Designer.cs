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
            this.GenerateButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxCapLetters = new System.Windows.Forms.CheckBox();
            this.CheckBoxNumbers = new System.Windows.Forms.CheckBox();
            this.CheckBoxSymbols = new System.Windows.Forms.CheckBox();
            this.ChechBoxLetters = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NewFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(337, 337);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(138, 38);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Сгенерировать";
            this.GenerateButton.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(344, 68);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 24);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // CheckBoxCapLetters
            // 
            this.CheckBoxCapLetters.AutoSize = true;
            this.CheckBoxCapLetters.Location = new System.Drawing.Point(344, 171);
            this.CheckBoxCapLetters.Name = "CheckBoxCapLetters";
            this.CheckBoxCapLetters.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxCapLetters.TabIndex = 2;
            this.CheckBoxCapLetters.UseVisualStyleBackColor = true;
            // 
            // CheckBoxNumbers
            // 
            this.CheckBoxNumbers.AutoSize = true;
            this.CheckBoxNumbers.Location = new System.Drawing.Point(344, 221);
            this.CheckBoxNumbers.Name = "CheckBoxNumbers";
            this.CheckBoxNumbers.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxNumbers.TabIndex = 3;
            this.CheckBoxNumbers.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSymbols
            // 
            this.CheckBoxSymbols.AutoSize = true;
            this.CheckBoxSymbols.Location = new System.Drawing.Point(344, 270);
            this.CheckBoxSymbols.Name = "CheckBoxSymbols";
            this.CheckBoxSymbols.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxSymbols.TabIndex = 4;
            this.CheckBoxSymbols.UseVisualStyleBackColor = true;
            // 
            // ChechBoxLetters
            // 
            this.ChechBoxLetters.AutoSize = true;
            this.ChechBoxLetters.Location = new System.Drawing.Point(344, 115);
            this.ChechBoxLetters.Name = "ChechBoxLetters";
            this.ChechBoxLetters.Size = new System.Drawing.Size(15, 14);
            this.ChechBoxLetters.TabIndex = 5;
            this.ChechBoxLetters.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите длину пароля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(51, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Использовать прописные буквы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Использовать заглавные буквы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(54, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Использовать цифры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(51, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Использовать специальные символы";
            // 
            // NewFormButton
            // 
            this.NewFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewFormButton.Location = new System.Drawing.Point(507, 337);
            this.NewFormButton.Name = "NewFormButton";
            this.NewFormButton.Size = new System.Drawing.Size(187, 38);
            this.NewFormButton.TabIndex = 11;
            this.NewFormButton.Text = "Оценить свой пароль";
            this.NewFormButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 474);
            this.Controls.Add(this.NewFormButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChechBoxLetters);
            this.Controls.Add(this.CheckBoxSymbols);
            this.Controls.Add(this.CheckBoxNumbers);
            this.Controls.Add(this.CheckBoxCapLetters);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.GenerateButton);
            this.Name = "MainForm";
            this.Text = "Генератор случайных паролей";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox CheckBoxCapLetters;
        private System.Windows.Forms.CheckBox CheckBoxNumbers;
        private System.Windows.Forms.CheckBox CheckBoxSymbols;
        private System.Windows.Forms.CheckBox ChechBoxLetters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NewFormButton;
    }
}

