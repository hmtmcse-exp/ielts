namespace IELTS_Helper
{
    partial class IELTS
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
            this.introduction = new System.Windows.Forms.TabControl();
            this.intro = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.introWeb = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reading = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.readingWebview = new System.Windows.Forms.WebBrowser();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.writing = new System.Windows.Forms.TabPage();
            this.listening = new System.Windows.Forms.TabPage();
            this.speaking = new System.Windows.Forms.TabPage();
            this.vocabulary = new System.Windows.Forms.TabPage();
            this.startLine = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.banglaMeaning = new System.Windows.Forms.Label();
            this.englishWord = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.startTalking = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.vocabularyListView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.introduction.SuspendLayout();
            this.intro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.reading.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.speaking.SuspendLayout();
            this.vocabulary.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // introduction
            // 
            this.introduction.Controls.Add(this.intro);
            this.introduction.Controls.Add(this.reading);
            this.introduction.Controls.Add(this.writing);
            this.introduction.Controls.Add(this.listening);
            this.introduction.Controls.Add(this.speaking);
            this.introduction.Controls.Add(this.vocabulary);
            this.introduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.introduction.Location = new System.Drawing.Point(0, 0);
            this.introduction.Name = "introduction";
            this.introduction.SelectedIndex = 0;
            this.introduction.Size = new System.Drawing.Size(1351, 595);
            this.introduction.TabIndex = 0;
            this.introduction.SelectedIndexChanged += new System.EventHandler(this.introduction_SelectedIndexChanged);
            this.introduction.Selected += new System.Windows.Forms.TabControlEventHandler(this.introduction_Selected);
            this.introduction.TabIndexChanged += new System.EventHandler(this.introduction_TabIndexChanged);
            this.introduction.Click += new System.EventHandler(this.introduction_Click);
            // 
            // intro
            // 
            this.intro.Controls.Add(this.groupBox2);
            this.intro.Controls.Add(this.groupBox1);
            this.intro.Location = new System.Drawing.Point(4, 22);
            this.intro.Name = "intro";
            this.intro.Padding = new System.Windows.Forms.Padding(3);
            this.intro.Size = new System.Drawing.Size(1343, 569);
            this.intro.TabIndex = 0;
            this.intro.Text = "Introduction";
            this.intro.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.introWeb);
            this.groupBox2.Location = new System.Drawing.Point(209, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1126, 555);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Content Viewer";
            // 
            // introWeb
            // 
            this.introWeb.Location = new System.Drawing.Point(13, 19);
            this.introWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.introWeb.Name = "introWeb";
            this.introWeb.Size = new System.Drawing.Size(1102, 521);
            this.introWeb.TabIndex = 1;
            this.introWeb.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 555);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Items";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reading
            // 
            this.reading.Controls.Add(this.groupBox3);
            this.reading.Controls.Add(this.groupBox4);
            this.reading.Location = new System.Drawing.Point(4, 22);
            this.reading.Name = "reading";
            this.reading.Padding = new System.Windows.Forms.Padding(3);
            this.reading.Size = new System.Drawing.Size(1343, 569);
            this.reading.TabIndex = 1;
            this.reading.Text = "Reading";
            this.reading.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.readingWebview);
            this.groupBox3.Location = new System.Drawing.Point(209, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1126, 555);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Content Viewer";
            // 
            // readingWebview
            // 
            this.readingWebview.Location = new System.Drawing.Point(13, 19);
            this.readingWebview.MinimumSize = new System.Drawing.Size(20, 20);
            this.readingWebview.Name = "readingWebview";
            this.readingWebview.Size = new System.Drawing.Size(1102, 521);
            this.readingWebview.TabIndex = 1;
            this.readingWebview.Url = new System.Uri("", System.UriKind.Relative);
            this.readingWebview.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.readingWebview_DocumentCompleted);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(8, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 555);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Menu Items";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 524);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // writing
            // 
            this.writing.Location = new System.Drawing.Point(4, 22);
            this.writing.Name = "writing";
            this.writing.Padding = new System.Windows.Forms.Padding(3);
            this.writing.Size = new System.Drawing.Size(1343, 569);
            this.writing.TabIndex = 2;
            this.writing.Text = "Writing";
            this.writing.UseVisualStyleBackColor = true;
            // 
            // listening
            // 
            this.listening.Location = new System.Drawing.Point(4, 22);
            this.listening.Name = "listening";
            this.listening.Padding = new System.Windows.Forms.Padding(3);
            this.listening.Size = new System.Drawing.Size(1343, 569);
            this.listening.TabIndex = 3;
            this.listening.Text = "Listening";
            this.listening.UseVisualStyleBackColor = true;
            // 
            // speaking
            // 
            this.speaking.Controls.Add(this.tableLayoutPanel1);
            this.speaking.Location = new System.Drawing.Point(4, 22);
            this.speaking.Name = "speaking";
            this.speaking.Padding = new System.Windows.Forms.Padding(3);
            this.speaking.Size = new System.Drawing.Size(1343, 569);
            this.speaking.TabIndex = 4;
            this.speaking.Text = "Speaking";
            this.speaking.UseVisualStyleBackColor = true;
            // 
            // vocabulary
            // 
            this.vocabulary.Controls.Add(this.tableLayoutPanel2);
            this.vocabulary.Location = new System.Drawing.Point(4, 22);
            this.vocabulary.Name = "vocabulary";
            this.vocabulary.Padding = new System.Windows.Forms.Padding(3);
            this.vocabulary.Size = new System.Drawing.Size(1343, 569);
            this.vocabulary.TabIndex = 5;
            this.vocabulary.Text = "Vocabulary";
            this.vocabulary.UseVisualStyleBackColor = true;
            // 
            // startLine
            // 
            this.startLine.Location = new System.Drawing.Point(130, 139);
            this.startLine.Name = "startLine";
            this.startLine.Size = new System.Drawing.Size(100, 20);
            this.startLine.TabIndex = 13;
            this.startLine.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(143, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // banglaMeaning
            // 
            this.banglaMeaning.AutoSize = true;
            this.banglaMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banglaMeaning.Location = new System.Drawing.Point(6, 128);
            this.banglaMeaning.Name = "banglaMeaning";
            this.banglaMeaning.Size = new System.Drawing.Size(307, 46);
            this.banglaMeaning.TabIndex = 11;
            this.banglaMeaning.Text = "Bangla Meaning";
            // 
            // englishWord
            // 
            this.englishWord.AutoSize = true;
            this.englishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishWord.Location = new System.Drawing.Point(4, 289);
            this.englishWord.Name = "englishWord";
            this.englishWord.Size = new System.Drawing.Size(258, 46);
            this.englishWord.TabIndex = 10;
            this.englishWord.Text = "English Word";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // startTalking
            // 
            this.startTalking.Location = new System.Drawing.Point(16, 40);
            this.startTalking.Name = "startTalking";
            this.startTalking.Size = new System.Drawing.Size(75, 23);
            this.startTalking.TabIndex = 8;
            this.startTalking.Text = "Start Talking";
            this.startTalking.UseVisualStyleBackColor = true;
            this.startTalking.Click += new System.EventHandler(this.startTalking_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.vocabularyListView);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 179);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1014, 375);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Word Notes";
            // 
            // vocabularyListView
            // 
            this.vocabularyListView.Location = new System.Drawing.Point(16, 19);
            this.vocabularyListView.Name = "vocabularyListView";
            this.vocabularyListView.Size = new System.Drawing.Size(715, 307);
            this.vocabularyListView.TabIndex = 0;
            this.vocabularyListView.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.1279F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.8721F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1337, 563);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(223, 557);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // groupBox7
            // 
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(232, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1102, 557);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1026F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.91954F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1337, 563);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.englishWord);
            this.groupBox8.Controls.Add(this.banglaMeaning);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(305, 557);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "groupBox8";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox9, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(314, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.77738F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.22262F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1020, 557);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.startTalking);
            this.groupBox9.Controls.Add(this.startLine);
            this.groupBox9.Controls.Add(this.button2);
            this.groupBox9.Controls.Add(this.comboBox1);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1014, 170);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "groupBox9";
            // 
            // IELTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 595);
            this.Controls.Add(this.introduction);
            this.Name = "IELTS";
            this.Text = "IELTS";
            this.introduction.ResumeLayout(false);
            this.intro.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.reading.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.speaking.ResumeLayout(false);
            this.vocabulary.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl introduction;
        private System.Windows.Forms.TabPage intro;
        private System.Windows.Forms.TabPage reading;
        private System.Windows.Forms.TabPage writing;
        private System.Windows.Forms.TabPage listening;
        private System.Windows.Forms.TabPage speaking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser introWeb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.WebBrowser readingWebview;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage vocabulary;
        private System.Windows.Forms.TextBox startLine;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label banglaMeaning;
        private System.Windows.Forms.Label englishWord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button startTalking;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView vocabularyListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox9;
    }
}