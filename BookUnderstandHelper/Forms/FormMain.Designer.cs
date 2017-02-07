namespace BookUnderstandHelper.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxScanFile = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonScan = new System.Windows.Forms.Button();
            this.openFileDialogDocument = new System.Windows.Forms.OpenFileDialog();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonFindInText = new System.Windows.Forms.Button();
            this.progressBarCurrentProgress = new System.Windows.Forms.ProgressBar();
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSaveToVocabulary = new System.Windows.Forms.Button();
            this.buttonVocabulary = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.buttonAddLang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxScanFile
            // 
            this.textBoxScanFile.Location = new System.Drawing.Point(12, 12);
            this.textBoxScanFile.Name = "textBoxScanFile";
            this.textBoxScanFile.ReadOnly = true;
            this.textBoxScanFile.Size = new System.Drawing.Size(171, 20);
            this.textBoxScanFile.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(189, 11);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(83, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(12, 226);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 23);
            this.buttonScan.TabIndex = 2;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            // 
            // openFileDialogDocument
            // 
            this.openFileDialogDocument.FileName = "book";
            this.openFileDialogDocument.Filter = "Text documents|*.txt|Word documents|*.doc?";
            // 
            // listBoxResult
            // 
            this.listBoxResult.ColumnWidth = 200;
            this.listBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 24;
            this.listBoxResult.Location = new System.Drawing.Point(12, 68);
            this.listBoxResult.MultiColumn = true;
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxResult.Size = new System.Drawing.Size(260, 124);
            this.listBoxResult.TabIndex = 4;
            // 
            // buttonFindInText
            // 
            this.buttonFindInText.Location = new System.Drawing.Point(197, 226);
            this.buttonFindInText.Name = "buttonFindInText";
            this.buttonFindInText.Size = new System.Drawing.Size(75, 23);
            this.buttonFindInText.TabIndex = 5;
            this.buttonFindInText.Text = "Find in text";
            this.buttonFindInText.UseVisualStyleBackColor = true;
            // 
            // progressBarCurrentProgress
            // 
            this.progressBarCurrentProgress.Location = new System.Drawing.Point(12, 39);
            this.progressBarCurrentProgress.Name = "progressBarCurrentProgress";
            this.progressBarCurrentProgress.Size = new System.Drawing.Size(260, 23);
            this.progressBarCurrentProgress.TabIndex = 6;
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.Location = new System.Drawing.Point(12, 198);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(98, 21);
            this.comboBoxLogin.Sorted = true;
            this.comboBoxLogin.TabIndex = 7;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(116, 198);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUser.TabIndex = 8;
            this.buttonAddUser.Text = "Add user";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(197, 198);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonSaveToVocabulary
            // 
            this.buttonSaveToVocabulary.Location = new System.Drawing.Point(94, 226);
            this.buttonSaveToVocabulary.Name = "buttonSaveToVocabulary";
            this.buttonSaveToVocabulary.Size = new System.Drawing.Size(97, 53);
            this.buttonSaveToVocabulary.TabIndex = 10;
            this.buttonSaveToVocabulary.Text = "Save to vocabulary";
            this.buttonSaveToVocabulary.UseVisualStyleBackColor = true;
            // 
            // buttonVocabulary
            // 
            this.buttonVocabulary.Location = new System.Drawing.Point(13, 256);
            this.buttonVocabulary.Name = "buttonVocabulary";
            this.buttonVocabulary.Size = new System.Drawing.Size(75, 23);
            this.buttonVocabulary.TabIndex = 11;
            this.buttonVocabulary.Text = "Vocabulary";
            this.buttonVocabulary.UseVisualStyleBackColor = true;
            // 
            // buttonBooks
            // 
            this.buttonBooks.Location = new System.Drawing.Point(197, 256);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(75, 23);
            this.buttonBooks.TabIndex = 12;
            this.buttonBooks.Text = "My library";
            this.buttonBooks.UseVisualStyleBackColor = true;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(13, 285);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(98, 21);
            this.comboBoxLanguage.TabIndex = 13;
            // 
            // buttonAddLang
            // 
            this.buttonAddLang.Location = new System.Drawing.Point(116, 285);
            this.buttonAddLang.Name = "buttonAddLang";
            this.buttonAddLang.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLang.TabIndex = 14;
            this.buttonAddLang.Text = "Add Lang";
            this.buttonAddLang.UseVisualStyleBackColor = true;
            this.buttonAddLang.Click += new System.EventHandler(this.buttonAddLang_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 318);
            this.Controls.Add(this.buttonAddLang);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.buttonVocabulary);
            this.Controls.Add(this.buttonSaveToVocabulary);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.comboBoxLogin);
            this.Controls.Add(this.progressBarCurrentProgress);
            this.Controls.Add(this.buttonFindInText);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxScanFile);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "FormMain";
            this.Text = "Book Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxScanFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocument;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonFindInText;
        private System.Windows.Forms.ProgressBar progressBarCurrentProgress;
        private System.Windows.Forms.ComboBox comboBoxLogin;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveToVocabulary;
        private System.Windows.Forms.Button buttonVocabulary;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Button buttonAddLang;
    }
}

