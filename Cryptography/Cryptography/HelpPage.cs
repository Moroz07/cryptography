using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public class HelpPage : TabPage
    {
        private HelpDataLoader helpDataLoader = new HelpDataLoader();
        private List<HelpItem> helpItems;

        private ListBox ChoiceThemasListBox;
        private RichTextBox ContentRichTextBox; // Заменяем TextBox на RichTextBox
        

        public HelpPage()
        {
            this.Text = "Справка";
            this.Padding = new Padding(3);
            InitializeComponents();
            LoadHelpData();
        }

        private void InitializeComponents()
        {
            
            ChoiceThemasListBox = new ListBox();
            ChoiceThemasListBox.Location = new Point(10, 10);
            ChoiceThemasListBox.Size = new Size(280, this.Height - 40);
            ChoiceThemasListBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            ChoiceThemasListBox.Font = new Font("Times New Roman", 12F);
            ChoiceThemasListBox.SelectedIndexChanged += ChoiceThemasListBox_SelectedIndexChanged;
            this.Controls.Add(ChoiceThemasListBox);

            
            ContentRichTextBox = new RichTextBox();
            ContentRichTextBox.Location = new Point(300, 10);
            ContentRichTextBox.Size = new Size(this.Width - 320, this.Height - 40);
            ContentRichTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            ContentRichTextBox.Font = new Font("Times New Roman", 14F);
            ContentRichTextBox.BackColor = Color.White;
            ContentRichTextBox.ReadOnly = true;
            ContentRichTextBox.WordWrap = true;
            ContentRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            ContentRichTextBox.Text = "Выберите тему из списка слева";
            this.Controls.Add(ContentRichTextBox);

        }

        private void LoadHelpData()
        {
            helpItems = helpDataLoader.LoadHelpData();
            ChoiceThemasListBox.Items.Clear();

            if (helpItems == null || helpItems.Count == 0)
            {
                ChoiceThemasListBox.Items.Add("Нет данных. Проверьте БД.");
                ContentRichTextBox.Text = "Справка временно недоступна. Проверьте подключение к базе данных.";
                return;
            }

            foreach (HelpItem item in helpItems)
            {
                ChoiceThemasListBox.Items.Add(item.Title);
            }

            if (helpItems.Count > 0)
            {
                ChoiceThemasListBox.SelectedIndex = 0;
            }
        }

        private void ChoiceThemasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ChoiceThemasListBox.SelectedIndex;
            if (index >= 0 && index < helpItems.Count)
            {
                HelpItem selectedItem = helpItems[index];

                
                ContentRichTextBox.Text = selectedItem.Title.ToUpper() + "\n\n" + selectedItem.Content;
                
                // Возвращаем ползунок в начало
                ContentRichTextBox.SelectionStart = 0;
                ContentRichTextBox.SelectionLength = 0;
                ContentRichTextBox.ScrollToCaret();
            }
        }

        
    }
}
