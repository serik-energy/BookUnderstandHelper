using System;
using System.Windows.Forms;

namespace BookUnderstandHelper.Forms
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// constructor for main form
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// get current user name from comboBoxLogin
        /// </summary>
        public string user
        {
            get
            {
                return comboBoxLogin.SelectedItem as string;
            }
        }

        /// <summary>
        /// get current language from comboBoxLanguage
        /// </summary>
        public string language
        {
            get
            {
                return comboBoxLanguage.SelectedItem as string;
            }
        }

        /// <summary>
        /// browse book
        /// </summary>
        /// <param name="sender">this</param>
        /// <param name="e">event arguments</param>
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialogDocument.ShowDialog() == DialogResult.OK)
                textBoxScanFile.Text = openFileDialogDocument.FileName;
        }
    }
}
