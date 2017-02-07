using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookUnderstandHelper.Forms
{
    public partial class FormLang : Form
    {
        public string name, user;
        public FormLang(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxLanguage.Text == "")
            {
                MessageBox.Show("Enter language!");
            }
            else
            if (UserData.ifContainLanguage(textBoxLanguage.Text, user))
            {
                MessageBox.Show("Language is existing!");
            }
            else
            {
                name = textBoxLanguage.Text;
                DialogResult = DialogResult.OK;
            }

        }
    }
}
