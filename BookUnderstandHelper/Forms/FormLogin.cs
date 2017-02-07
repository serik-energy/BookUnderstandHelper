using System;
using System.Windows.Forms;

namespace BookUnderstandHelper.Forms
{
    public partial class FormLogin : Form
    {
        /// <summary>
        /// path of book file
        /// </summary>
        public string path { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// confirm username
        /// </summary>
        /// <param name="sender">this</param>
        /// <param name="e">event arguments</param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text))
            {
                MessageBox.Show("Enter correct name!");
            }
            else
            if (UserData.ifContainUser(textBoxUserName.Text))
            {
                MessageBox.Show("user with same name is existing");
            }
            else
            {
                path = textBoxUserName.Text;
                DialogResult = DialogResult.OK;
            }

        }
    }
}
