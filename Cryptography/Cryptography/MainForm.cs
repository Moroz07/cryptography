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
    public partial class MainForm: Form
    {
        private PasswordGenerator passwordGenerator = new PasswordGenerator();
        private PasswordStrengthEvaluator passwordEvaluator = new PasswordStrengthEvaluator();
        private CaesarCipher caesarCipher = new CaesarCipher();
        private CaesarAnimation caesarAnimation = new CaesarAnimation();

        private DatabaseLoader databaseLoader = new DatabaseLoader();

        public MainForm()
        {
            InitializeComponent();
        }
           
    }
}
