using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
        public string currrentUser
        {
            get
            {
                if (comboBoxLogin.Items.Count < 1)
                    buttonAddUser_Click(this, new EventArgs());
                return comboBoxLogin.SelectedItem as string;
            }
        }
        /// <summary>
        /// get current language from comboBoxLanguage
        /// </summary>
        public string currrentLanguage
        {
            get
            {
                if (comboBoxLanguage.Items.Count < 1)
                    buttonAddLang_Click(this, new EventArgs());
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
            if (!string.IsNullOrEmpty(currrentUser) && !userData.users.ContainsKey(currrentUser))
            {
                MessageBox.Show("Incorrect user");
                return;
            }
            FormLang langForm = new FormLang(currrentUser);
            if (langForm.ShowDialog() == DialogResult.OK)
            {
                comboBoxLanguage.Items.Add(langForm.name);
                comboBoxLanguage.SelectedItem = langForm.name;
                userData.users[currrentUser].Add(langForm.name, new Dictionary<string, ulong>());
                userData.myVocabulary[currrentUser].Add(langForm.name, new Dictionary<string, ulong>());
                userData.library[currrentUser].Add(langForm.name, new Dictionary<string, List<string>>());
            }
        }

        private async void buttonScan_Click(object sender, EventArgs e)
        {
            #region check path
            if (string.IsNullOrEmpty( textBoxScanFile.Text ))
            {
                MessageBox.Show("chose you file");
                return;
            }
            if (!userData.users.ContainsKey(currrentUser))
            {
                MessageBox.Show("Incorrect user name");
                return;
            }
            if (!userData.users[currrentUser].ContainsKey(currrentLanguage))
            {
                MessageBox.Show("Incorrect lang");
                return;
            }
            #endregion

            listBoxResult.Items.Clear();
            await Scan();
        }

        private void readTextAsDoc(string name)
        {
            throw new NotImplementedException();
        }

        private void readTextAsTxt(string name)
        {
            userData.book = File.ReadLines(name).ToList();
        }

        private async Task Scan()
        {
            await Task.Yield();

            //enableWait();

            string name = textBoxScanFile.Text;

            switch (name.Split('.').Last())
            {
                case "txt":
                    readTextAsTxt(name);
                    break;
                case "doc":
                    readTextAsDoc(name);
                    break;
                case "docx":
                    readTextAsDoc(name);
                    break;
                default:
                    break;
            }
            //save to lib
            string nameOfFile = name.Split('\\').Last();
            if (!userData.library.ContainsKey(currrentUser))
                userData.library.Add(currrentUser, new Dictionary<string, Dictionary<string, List<string>>>());
            if (!userData.library[currrentUser].ContainsKey(currrentLanguage))
                userData.library[currrentUser].Add(currrentLanguage, new Dictionary<string, List<string>>());
            if (!userData.library[currrentUser][currrentLanguage].ContainsKey(nameOfFile))
                userData.library[currrentUser][currrentLanguage].Add(nameOfFile, userData.book);
            else
            {
                if (MessageBox.Show("Book with the same name is already scanned.\n\nAre you still want to add this book?",
                    "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 1; ; i++)
                    {
                        string str = nameOfFile.Replace(
                            "." + nameOfFile.Split('.').Last(),
                            string.Format(" ({0}).{1}", i, nameOfFile.Split('.').Last()));
                        if (!userData.library[currrentUser][currrentLanguage].ContainsKey(str))
                        {
                            userData.library[currrentUser][currrentLanguage].Add(str, userData.book);
                            break;
                        }
                    }
                }
                else
                {
                    userData.book = new List<string>();
                }
            }
            searchWords();
            await showResult();
            //disableWait();
        }
        private void searchWords()
        {
            var words = userData.users[currrentUser][currrentLanguage];
            string[] splitedParagraph;
            foreach (string paragraph in userData.book)
            {
                splitedParagraph = paragraph.Split(Constants.separators);
                foreach (string word in splitedParagraph)
                {
                    string lowerWord = word.ToLower();
                    if (string.IsNullOrEmpty(lowerWord))
                        continue;

                    if (userData.myVocabulary[currrentUser][currrentLanguage].ContainsKey(lowerWord))
                    {
                        userData.myVocabulary[currrentUser][currrentLanguage][lowerWord]++;
                    }
                    else
                    {
                        if (!words.ContainsKey(lowerWord))
                        {
                            words.Add(lowerWord, 0);
                        }
                        words[lowerWord]++;
                    }
                }
            }
            words = sort(words);
            userData.users[currrentUser][currrentLanguage] = words;
        }

        private Dictionary<string, ulong> sort(Dictionary<string, ulong> words)
        {
            Dictionary<string, ulong> d = new Dictionary<string, ulong>();
            var v = words.OrderByDescending(word => word.Value);
            foreach (var item in v)
            {
                d.Add(item.Key, item.Value);
            }
            return d;
        }
        private async Task showResult()
        {
            //enableWait();
            await Task.Yield();

            string currrentUser = this.currrentUser;
            string currrentLanguage = this.currrentLanguage;

            var words = userData.users[currrentUser][currrentLanguage];

            foreach (var word in words)
            {
                string str = string.Format("\"{0}\" - {1}\r\n", word.Key, word.Value);
                listBoxResult.Items.Add(str);
            }
            if (words.Count > 0)
                MessageBox.Show("Well done!");
            //disableWait();
        }







    }
}
