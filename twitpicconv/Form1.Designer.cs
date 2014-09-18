namespace twitpicconv
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialogTwit = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogPic = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelKeywords = new System.Windows.Forms.Label();
            this.textBoxKeywords = new System.Windows.Forms.TextBox();
            this.labelTweetCSVfile = new System.Windows.Forms.Label();
            this.labelPictureFolder = new System.Windows.Forms.Label();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchname = new System.Windows.Forms.TextBox();
            this.labelSearchDomain = new System.Windows.Forms.Label();
            this.textBoxSearchdomain = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.labelAllowPings = new System.Windows.Forms.Label();
            this.textBoxAllowPings = new System.Windows.Forms.TextBox();
            this.labelConvertBreaks = new System.Windows.Forms.Label();
            this.textBoxConvertBreaks = new System.Windows.Forms.TextBox();
            this.labelAllowComments = new System.Windows.Forms.Label();
            this.textBoxAllowComments = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelTwilogURL = new System.Windows.Forms.Label();
            this.textBoxTwilogurl = new System.Windows.Forms.TextBox();
            this.labelTwitterURL = new System.Windows.Forms.Label();
            this.textBoxTwitterurl = new System.Windows.Forms.TextBox();
            this.textBoxTwitlog = new System.Windows.Forms.TextBox();
            this.textBoxPicFolder = new System.Windows.Forms.TextBox();
            this.buttonPicFolder = new System.Windows.Forms.Button();
            this.labelPictureURL = new System.Windows.Forms.Label();
            this.textBoxpicurl = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonTwetopen = new System.Windows.Forms.Button();
            this.labelline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialogTwit
            // 
            this.openFileDialogTwit.FileName = "openFileDialog1";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(556, 184);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(121, 23);
            this.buttonStart.TabIndex = 68;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelKeywords
            // 
            this.labelKeywords.AutoSize = true;
            this.labelKeywords.Location = new System.Drawing.Point(11, 189);
            this.labelKeywords.Name = "labelKeywords";
            this.labelKeywords.Size = new System.Drawing.Size(54, 12);
            this.labelKeywords.TabIndex = 67;
            this.labelKeywords.Text = "Keywords";
            // 
            // textBoxKeywords
            // 
            this.textBoxKeywords.Location = new System.Drawing.Point(103, 186);
            this.textBoxKeywords.Name = "textBoxKeywords";
            this.textBoxKeywords.Size = new System.Drawing.Size(106, 19);
            this.textBoxKeywords.TabIndex = 66;
            this.textBoxKeywords.Text = "twitpic";
            // 
            // labelTweetCSVfile
            // 
            this.labelTweetCSVfile.AutoSize = true;
            this.labelTweetCSVfile.Location = new System.Drawing.Point(215, 164);
            this.labelTweetCSVfile.Name = "labelTweetCSVfile";
            this.labelTweetCSVfile.Size = new System.Drawing.Size(75, 12);
            this.labelTweetCSVfile.TabIndex = 65;
            this.labelTweetCSVfile.Text = "tweet csv file";
            // 
            // labelPictureFolder
            // 
            this.labelPictureFolder.AutoSize = true;
            this.labelPictureFolder.Location = new System.Drawing.Point(216, 139);
            this.labelPictureFolder.Name = "labelPictureFolder";
            this.labelPictureFolder.Size = new System.Drawing.Size(74, 12);
            this.labelPictureFolder.TabIndex = 64;
            this.labelPictureFolder.Text = "Picture folder";
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Location = new System.Drawing.Point(216, 114);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(71, 12);
            this.labelSearchName.TabIndex = 63;
            this.labelSearchName.Text = "Search name";
            // 
            // textBoxSearchname
            // 
            this.textBoxSearchname.Location = new System.Drawing.Point(300, 111);
            this.textBoxSearchname.Name = "textBoxSearchname";
            this.textBoxSearchname.Size = new System.Drawing.Size(250, 19);
            this.textBoxSearchname.TabIndex = 62;
            this.textBoxSearchname.Text = "google search";
            // 
            // labelSearchDomain
            // 
            this.labelSearchDomain.AutoSize = true;
            this.labelSearchDomain.Location = new System.Drawing.Point(216, 89);
            this.labelSearchDomain.Name = "labelSearchDomain";
            this.labelSearchDomain.Size = new System.Drawing.Size(80, 12);
            this.labelSearchDomain.TabIndex = 61;
            this.labelSearchDomain.Text = "Search domain";
            // 
            // textBoxSearchdomain
            // 
            this.textBoxSearchdomain.Location = new System.Drawing.Point(300, 86);
            this.textBoxSearchdomain.Name = "textBoxSearchdomain";
            this.textBoxSearchdomain.Size = new System.Drawing.Size(250, 19);
            this.textBoxSearchdomain.TabIndex = 60;
            this.textBoxSearchdomain.Text = "author.cocolog-nifty.com";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(11, 164);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(51, 12);
            this.labelCategory.TabIndex = 59;
            this.labelCategory.Text = "Category";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(103, 161);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(106, 19);
            this.textBoxCategory.TabIndex = 58;
            this.textBoxCategory.Text = "twitpic";
            // 
            // labelAllowPings
            // 
            this.labelAllowPings.AutoSize = true;
            this.labelAllowPings.Location = new System.Drawing.Point(11, 139);
            this.labelAllowPings.Name = "labelAllowPings";
            this.labelAllowPings.Size = new System.Drawing.Size(64, 12);
            this.labelAllowPings.TabIndex = 57;
            this.labelAllowPings.Text = "Allow pings";
            // 
            // textBoxAllowPings
            // 
            this.textBoxAllowPings.Location = new System.Drawing.Point(103, 136);
            this.textBoxAllowPings.Name = "textBoxAllowPings";
            this.textBoxAllowPings.Size = new System.Drawing.Size(106, 19);
            this.textBoxAllowPings.TabIndex = 56;
            this.textBoxAllowPings.Text = "1";
            // 
            // labelConvertBreaks
            // 
            this.labelConvertBreaks.AutoSize = true;
            this.labelConvertBreaks.Location = new System.Drawing.Point(11, 114);
            this.labelConvertBreaks.Name = "labelConvertBreaks";
            this.labelConvertBreaks.Size = new System.Drawing.Size(83, 12);
            this.labelConvertBreaks.TabIndex = 55;
            this.labelConvertBreaks.Text = "Convert breaks";
            // 
            // textBoxConvertBreaks
            // 
            this.textBoxConvertBreaks.Location = new System.Drawing.Point(103, 111);
            this.textBoxConvertBreaks.Name = "textBoxConvertBreaks";
            this.textBoxConvertBreaks.Size = new System.Drawing.Size(106, 19);
            this.textBoxConvertBreaks.TabIndex = 54;
            this.textBoxConvertBreaks.Text = "0";
            // 
            // labelAllowComments
            // 
            this.labelAllowComments.AutoSize = true;
            this.labelAllowComments.Location = new System.Drawing.Point(11, 89);
            this.labelAllowComments.Name = "labelAllowComments";
            this.labelAllowComments.Size = new System.Drawing.Size(89, 12);
            this.labelAllowComments.TabIndex = 53;
            this.labelAllowComments.Text = "Allow comments";
            // 
            // textBoxAllowComments
            // 
            this.textBoxAllowComments.Location = new System.Drawing.Point(103, 86);
            this.textBoxAllowComments.Name = "textBoxAllowComments";
            this.textBoxAllowComments.Size = new System.Drawing.Size(106, 19);
            this.textBoxAllowComments.TabIndex = 52;
            this.textBoxAllowComments.Text = "1";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(11, 64);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(38, 12);
            this.labelStatus.TabIndex = 51;
            this.labelStatus.Text = "Status";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(103, 61);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(106, 19);
            this.textBoxStatus.TabIndex = 50;
            this.textBoxStatus.Text = "Publish";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(11, 39);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(28, 12);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(103, 36);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(106, 19);
            this.textBoxTitle.TabIndex = 48;
            this.textBoxTitle.Text = "twitpic";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(11, 14);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(39, 12);
            this.labelAuthor.TabIndex = 47;
            this.labelAuthor.Text = "Author";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(103, 11);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(106, 19);
            this.textBoxAuthor.TabIndex = 46;
            this.textBoxAuthor.Text = "author";
            // 
            // labelTwilogURL
            // 
            this.labelTwilogURL.AutoSize = true;
            this.labelTwilogURL.Location = new System.Drawing.Point(216, 64);
            this.labelTwilogURL.Name = "labelTwilogURL";
            this.labelTwilogURL.Size = new System.Drawing.Size(64, 12);
            this.labelTwilogURL.TabIndex = 45;
            this.labelTwilogURL.Text = "Twilog URL";
            // 
            // textBoxTwilogurl
            // 
            this.textBoxTwilogurl.Location = new System.Drawing.Point(300, 61);
            this.textBoxTwilogurl.Name = "textBoxTwilogurl";
            this.textBoxTwilogurl.Size = new System.Drawing.Size(250, 19);
            this.textBoxTwilogurl.TabIndex = 44;
            this.textBoxTwilogurl.Text = "http://twilog.org/twitterid/";
            // 
            // labelTwitterURL
            // 
            this.labelTwitterURL.AutoSize = true;
            this.labelTwitterURL.Location = new System.Drawing.Point(216, 39);
            this.labelTwitterURL.Name = "labelTwitterURL";
            this.labelTwitterURL.Size = new System.Drawing.Size(67, 12);
            this.labelTwitterURL.TabIndex = 43;
            this.labelTwitterURL.Text = "Twitter URL";
            // 
            // textBoxTwitterurl
            // 
            this.textBoxTwitterurl.Location = new System.Drawing.Point(300, 36);
            this.textBoxTwitterurl.Name = "textBoxTwitterurl";
            this.textBoxTwitterurl.Size = new System.Drawing.Size(250, 19);
            this.textBoxTwitterurl.TabIndex = 42;
            this.textBoxTwitterurl.Text = "http://twitter.com/twitterid/status/";
            // 
            // textBoxTwitlog
            // 
            this.textBoxTwitlog.Location = new System.Drawing.Point(300, 161);
            this.textBoxTwitlog.Name = "textBoxTwitlog";
            this.textBoxTwitlog.Size = new System.Drawing.Size(250, 19);
            this.textBoxTwitlog.TabIndex = 41;
            // 
            // textBoxPicFolder
            // 
            this.textBoxPicFolder.Location = new System.Drawing.Point(300, 136);
            this.textBoxPicFolder.Name = "textBoxPicFolder";
            this.textBoxPicFolder.Size = new System.Drawing.Size(250, 19);
            this.textBoxPicFolder.TabIndex = 40;
            // 
            // buttonPicFolder
            // 
            this.buttonPicFolder.Location = new System.Drawing.Point(556, 134);
            this.buttonPicFolder.Name = "buttonPicFolder";
            this.buttonPicFolder.Size = new System.Drawing.Size(121, 23);
            this.buttonPicFolder.TabIndex = 39;
            this.buttonPicFolder.Text = "Select Picture Folder";
            this.buttonPicFolder.UseVisualStyleBackColor = true;
            this.buttonPicFolder.Click += new System.EventHandler(this.buttonPicFolder_Click);
            // 
            // labelPictureURL
            // 
            this.labelPictureURL.AutoSize = true;
            this.labelPictureURL.Location = new System.Drawing.Point(216, 14);
            this.labelPictureURL.Name = "labelPictureURL";
            this.labelPictureURL.Size = new System.Drawing.Size(67, 12);
            this.labelPictureURL.TabIndex = 38;
            this.labelPictureURL.Text = "Picture URL";
            // 
            // textBoxpicurl
            // 
            this.textBoxpicurl.Location = new System.Drawing.Point(300, 11);
            this.textBoxpicurl.Name = "textBoxpicurl";
            this.textBoxpicurl.Size = new System.Drawing.Size(250, 19);
            this.textBoxpicurl.TabIndex = 37;
            this.textBoxpicurl.Text = "http://author.cocolog-nifty.com/blog/twitpic/";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(12, 211);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(538, 208);
            this.textBoxLog.TabIndex = 36;
            // 
            // buttonTwetopen
            // 
            this.buttonTwetopen.Location = new System.Drawing.Point(556, 159);
            this.buttonTwetopen.Name = "buttonTwetopen";
            this.buttonTwetopen.Size = new System.Drawing.Size(121, 23);
            this.buttonTwetopen.TabIndex = 35;
            this.buttonTwetopen.Text = "Select Twitlog csv";
            this.buttonTwetopen.UseVisualStyleBackColor = true;
            this.buttonTwetopen.Click += new System.EventHandler(this.buttonTwetopen_Click);
            // 
            // labelline
            // 
            this.labelline.AutoSize = true;
            this.labelline.Location = new System.Drawing.Point(300, 189);
            this.labelline.Name = "labelline";
            this.labelline.Size = new System.Drawing.Size(79, 12);
            this.labelline.TabIndex = 69;
            this.labelline.Text = "0 lines 0 texts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.labelline);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelKeywords);
            this.Controls.Add(this.textBoxKeywords);
            this.Controls.Add(this.labelTweetCSVfile);
            this.Controls.Add(this.labelPictureFolder);
            this.Controls.Add(this.labelSearchName);
            this.Controls.Add(this.textBoxSearchname);
            this.Controls.Add(this.labelSearchDomain);
            this.Controls.Add(this.textBoxSearchdomain);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.labelAllowPings);
            this.Controls.Add(this.textBoxAllowPings);
            this.Controls.Add(this.labelConvertBreaks);
            this.Controls.Add(this.textBoxConvertBreaks);
            this.Controls.Add(this.labelAllowComments);
            this.Controls.Add(this.textBoxAllowComments);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelTwilogURL);
            this.Controls.Add(this.textBoxTwilogurl);
            this.Controls.Add(this.labelTwitterURL);
            this.Controls.Add(this.textBoxTwitterurl);
            this.Controls.Add(this.textBoxTwitlog);
            this.Controls.Add(this.textBoxPicFolder);
            this.Controls.Add(this.buttonPicFolder);
            this.Controls.Add(this.labelPictureURL);
            this.Controls.Add(this.textBoxpicurl);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonTwetopen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Twitpic converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogTwit;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPic;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelKeywords;
        private System.Windows.Forms.TextBox textBoxKeywords;
        private System.Windows.Forms.Label labelTweetCSVfile;
        private System.Windows.Forms.Label labelPictureFolder;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxSearchname;
        private System.Windows.Forms.Label labelSearchDomain;
        private System.Windows.Forms.TextBox textBoxSearchdomain;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label labelAllowPings;
        private System.Windows.Forms.TextBox textBoxAllowPings;
        private System.Windows.Forms.Label labelConvertBreaks;
        private System.Windows.Forms.TextBox textBoxConvertBreaks;
        private System.Windows.Forms.Label labelAllowComments;
        private System.Windows.Forms.TextBox textBoxAllowComments;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelTwilogURL;
        private System.Windows.Forms.TextBox textBoxTwilogurl;
        private System.Windows.Forms.Label labelTwitterURL;
        private System.Windows.Forms.TextBox textBoxTwitterurl;
        private System.Windows.Forms.TextBox textBoxTwitlog;
        private System.Windows.Forms.TextBox textBoxPicFolder;
        private System.Windows.Forms.Button buttonPicFolder;
        private System.Windows.Forms.Label labelPictureURL;
        private System.Windows.Forms.TextBox textBoxpicurl;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonTwetopen;
        private System.Windows.Forms.Label labelline;
    }
}

