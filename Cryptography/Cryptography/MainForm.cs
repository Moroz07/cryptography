using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class MainForm : Form
    {

        private PasswordGeneratePage passwordGeneratePage;
        private PasswordStrengthEvaluatorPage passwordStrengthEvaluatorPage;
        private CipherPage cipherPage;
        private HelpPage helpPage;

        public MainForm()
        {
            InitializeComponent();

            passwordGeneratePage = new PasswordGeneratePage();
            passwordStrengthEvaluatorPage = new PasswordStrengthEvaluatorPage();
            cipherPage = new CipherPage();
            helpPage = new HelpPage();

            mainTabControl.TabPages.Clear();
            mainTabControl.TabPages.Add(passwordGeneratePage);
            mainTabControl.TabPages.Add(passwordStrengthEvaluatorPage);
            mainTabControl.TabPages.Add(cipherPage);
            mainTabControl.TabPages.Add(helpPage);

            passwordGeneratePage.PasswordGenerated += OnPasswordGenerated;
        }

        private void OnPasswordGenerated(string password)
        {
            passwordStrengthEvaluatorPage.UpdateResult(password);
        }
    }
}