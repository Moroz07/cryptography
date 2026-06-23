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
        private TextBox UrlTextBox;
        private Button OpenUrlButton;

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
            ChoiceThemasListBox.Dock = DockStyle.Left;
            ChoiceThemasListBox.Font = new Font("Times New Roman", 12F);
            ChoiceThemasListBox.Size = new Size(278, 530);
            ChoiceThemasListBox.SelectedIndexChanged += ChoiceThemasListBox_SelectedIndexChanged;
            this.Controls.Add(ChoiceThemasListBox);

            UrlTextBox = new TextBox();
            UrlTextBox.Font = new Font("Times New Roman", 13.8F);
            UrlTextBox.Location = new Point(325, 39);
            UrlTextBox.Size = new Size(587, 37);
            UrlTextBox.Multiline = true;
            UrlTextBox.Enabled = false;
            this.Controls.Add(UrlTextBox);

            OpenUrlButton = new Button();
            OpenUrlButton.Text = "Открыть";
            OpenUrlButton.Font = new Font("Times New Roman", 13.8F);
            OpenUrlButton.Location = new Point(479, 372);
            OpenUrlButton.Size = new Size(211, 52);
            OpenUrlButton.Click += OpenUrlButton_Click;
            this.Controls.Add(OpenUrlButton);
        }

        private void LoadHelpData()
        {
            helpItems = helpDataLoader.LoadHelpData();
            ChoiceThemasListBox.Items.Clear();

            if (helpItems == null || helpItems.Count == 0)
            {
                ChoiceThemasListBox.Items.Add("Нет данных. Проверьте Базу Данных.");
                return;
            }

            foreach (HelpItem item in helpItems)
            {
                ChoiceThemasListBox.Items.Add(item.Title);
            }
        }

        private void ChoiceThemasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ChoiceThemasListBox.SelectedIndex;
            if (index >= 0 && index < helpItems.Count)
            {
                UrlTextBox.Text = helpItems[index].Url;
            }
        }

        private void OpenUrlButton_Click(object sender, EventArgs e)
        {
            if (UrlTextBox.Text != null && UrlTextBox.Text != "")
            {
                Process.Start(new ProcessStartInfo(UrlTextBox.Text) { UseShellExecute = true });
            }
        }
    }
}
