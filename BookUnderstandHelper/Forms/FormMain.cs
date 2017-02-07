using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookUnderstandHelper.Forms
{
    /// <summary>
    /// main window
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// get <see cref="UserData"/> from singleton
        /// </summary>
        public UserData userData
        {
            get { return UserData.getUserData(); }
        }
        /// <summary>
        /// constructor
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
        /// <summary>
        /// add new username
        /// </summary>
        /// <param name="sender">this</param>
        /// <param name="e">event arguments</param>
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                comboBoxLogin.Items.Add(loginForm.path);
                userData.users.Add(loginForm.path, new Dictionary<string, Dictionary<string, ulong>>());
                userData.myVocabulary.Add(loginForm.path, new Dictionary<string, Dictionary<string, ulong>>());
                userData.library.Add(loginForm.path, new Dictionary<string, Dictionary<string, List<string>>>());
                comboBoxLogin.SelectedItem = loginForm.path;
            }
        }
        /// <summary>
        /// add new language for current user
        /// </summary>
        /// <param name="sender">this</param>
        /// <param name="e">event arguments</param>
        private void buttonAddLang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(user) && !userData.users.ContainsKey(user))
            {
                MessageBox.Show("Incorrect user");
                return;
            }
            FormLang langForm = new FormLang(user);
            if (langForm.ShowDialog() == DialogResult.OK)
            {
                comboBoxLanguage.Items.Add(langForm.name);
                comboBoxLanguage.SelectedItem = langForm.name;
                userData.users[user].Add(langForm.name, new Dictionary<string, ulong>());
                userData.myVocabulary[user].Add(langForm.name, new Dictionary<string, ulong>());
                userData.library[user].Add(langForm.name, new Dictionary<string, List<string>>());
            }
        }
    }
}
