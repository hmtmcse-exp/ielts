﻿namespace IELTS_Helper
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.vocabulary = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.englishWord = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.banglaMeaning = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.vocabularyListView = new System.Windows.Forms.ListView();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.searchVocabulary = new System.Windows.Forms.TextBox();
            this.startTalking = new System.Windows.Forms.Button();
            this.startLine = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.topicDetailsQuestionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.vocabularyTopicPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.showHideQuestion = new System.Windows.Forms.Button();
            this.ReadContents = new System.Windows.Forms.Button();
            this.showHideVocTop = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.introduction.SuspendLayout();
            this.intro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.reading.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.speaking.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.vocabulary.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.topicDetailsQuestionPanel.SuspendLayout();
            this.vocabularyTopicPanel.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
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
            this.reading.Controls.Add(this.tableLayoutPanel5);
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
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1057, 551);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reading Context";
            // 
            // readingWebview
            // 
            this.readingWebview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readingWebview.Location = new System.Drawing.Point(3, 16);
            this.readingWebview.MinimumSize = new System.Drawing.Size(20, 20);
            this.readingWebview.Name = "readingWebview";
            this.readingWebview.Size = new System.Drawing.Size(1051, 532);
            this.readingWebview.TabIndex = 1;
            this.readingWebview.Url = new System.Uri("", System.UriKind.Relative);
            this.readingWebview.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.readingWebview_DocumentCompleted);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 1);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reading Topics";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 0);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1337, 563);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel4);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(261, 557);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Word Details";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox12, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(255, 538);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.englishWord);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(249, 173);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "English Word";
            // 
            // englishWord
            // 
            this.englishWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.englishWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.englishWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishWord.Location = new System.Drawing.Point(3, 16);
            this.englishWord.Multiline = true;
            this.englishWord.Name = "englishWord";
            this.englishWord.ReadOnly = true;
            this.englishWord.Size = new System.Drawing.Size(243, 154);
            this.englishWord.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.banglaMeaning);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 182);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(249, 173);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Bangla Word";
            // 
            // banglaMeaning
            // 
            this.banglaMeaning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.banglaMeaning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banglaMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banglaMeaning.Location = new System.Drawing.Point(3, 16);
            this.banglaMeaning.Multiline = true;
            this.banglaMeaning.Name = "banglaMeaning";
            this.banglaMeaning.ReadOnly = true;
            this.banglaMeaning.Size = new System.Drawing.Size(243, 154);
            this.banglaMeaning.TabIndex = 12;
            // 
            // groupBox12
            // 
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(3, 361);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(249, 174);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Synonym";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox9, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(270, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1064, 557);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.vocabularyListView);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1058, 451);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Word Notes";
            // 
            // vocabularyListView
            // 
            this.vocabularyListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vocabularyListView.Location = new System.Drawing.Point(3, 16);
            this.vocabularyListView.Name = "vocabularyListView";
            this.vocabularyListView.Size = new System.Drawing.Size(1052, 432);
            this.vocabularyListView.TabIndex = 0;
            this.vocabularyListView.UseCompatibleStateImageBehavior = false;
            this.vocabularyListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.vocabularyListView_ItemSelectionChanged);
            this.vocabularyListView.SelectedIndexChanged += new System.EventHandler(this.vocabularyListView_SelectedIndexChanged);
            this.vocabularyListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vocabularyListView_KeyDown);
            this.vocabularyListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.vocabularyListView_MouseDoubleClick);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.searchVocabulary);
            this.groupBox9.Controls.Add(this.startTalking);
            this.groupBox9.Controls.Add(this.startLine);
            this.groupBox9.Controls.Add(this.button2);
            this.groupBox9.Controls.Add(this.comboBox1);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1058, 94);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Action Panel";
            // 
            // searchVocabulary
            // 
            this.searchVocabulary.Location = new System.Drawing.Point(398, 24);
            this.searchVocabulary.Name = "searchVocabulary";
            this.searchVocabulary.Size = new System.Drawing.Size(100, 20);
            this.searchVocabulary.TabIndex = 14;
            this.searchVocabulary.TextChanged += new System.EventHandler(this.searchVocabulary_TextChanged);
            // 
            // startTalking
            // 
            this.startTalking.Location = new System.Drawing.Point(6, 19);
            this.startTalking.Name = "startTalking";
            this.startTalking.Size = new System.Drawing.Size(75, 23);
            this.startTalking.TabIndex = 8;
            this.startTalking.Text = "Start Talking";
            this.startTalking.UseVisualStyleBackColor = true;
            this.startTalking.Click += new System.EventHandler(this.startTalking_Click);
            // 
            // startLine
            // 
            this.startLine.Location = new System.Drawing.Point(292, 24);
            this.startLine.Name = "startLine";
            this.startLine.Size = new System.Drawing.Size(100, 20);
            this.startLine.TabIndex = 13;
            this.startLine.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
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
            this.comboBox1.Location = new System.Drawing.Point(84, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.topicDetailsQuestionPanel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.vocabularyTopicPanel, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1337, 563);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // topicDetailsQuestionPanel
            // 
            this.topicDetailsQuestionPanel.ColumnCount = 2;
            this.topicDetailsQuestionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topicDetailsQuestionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.topicDetailsQuestionPanel.Controls.Add(this.groupBox3, 0, 0);
            this.topicDetailsQuestionPanel.Controls.Add(this.groupBox13, 1, 0);
            this.topicDetailsQuestionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicDetailsQuestionPanel.Location = new System.Drawing.Point(3, 3);
            this.topicDetailsQuestionPanel.Name = "topicDetailsQuestionPanel";
            this.topicDetailsQuestionPanel.RowCount = 1;
            this.topicDetailsQuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topicDetailsQuestionPanel.Size = new System.Drawing.Size(1063, 557);
            this.topicDetailsQuestionPanel.TabIndex = 0;
            // 
            // vocabularyTopicPanel
            // 
            this.vocabularyTopicPanel.ColumnCount = 1;
            this.vocabularyTopicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.vocabularyTopicPanel.Controls.Add(this.groupBox4, 0, 1);
            this.vocabularyTopicPanel.Controls.Add(this.groupBox14, 0, 0);
            this.vocabularyTopicPanel.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.vocabularyTopicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vocabularyTopicPanel.Location = new System.Drawing.Point(1072, 3);
            this.vocabularyTopicPanel.Name = "vocabularyTopicPanel";
            this.vocabularyTopicPanel.RowCount = 3;
            this.vocabularyTopicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.vocabularyTopicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.vocabularyTopicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.vocabularyTopicPanel.Size = new System.Drawing.Size(262, 557);
            this.vocabularyTopicPanel.TabIndex = 1;
            // 
            // groupBox13
            // 
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox13.Location = new System.Drawing.Point(1066, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(1, 551);
            this.groupBox13.TabIndex = 6;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Question Panel";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.showHideVocTop);
            this.groupBox14.Controls.Add(this.ReadContents);
            this.groupBox14.Controls.Add(this.showHideQuestion);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Location = new System.Drawing.Point(3, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(256, 74);
            this.groupBox14.TabIndex = 5;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Action";
            // 
            // showHideQuestion
            // 
            this.showHideQuestion.Location = new System.Drawing.Point(6, 16);
            this.showHideQuestion.Name = "showHideQuestion";
            this.showHideQuestion.Size = new System.Drawing.Size(121, 23);
            this.showHideQuestion.TabIndex = 3;
            this.showHideQuestion.Text = "Show Question";
            this.showHideQuestion.UseVisualStyleBackColor = true;
            this.showHideQuestion.Click += new System.EventHandler(this.showHideQuestion_Click);
            // 
            // ReadContents
            // 
            this.ReadContents.Location = new System.Drawing.Point(133, 16);
            this.ReadContents.Name = "ReadContents";
            this.ReadContents.Size = new System.Drawing.Size(117, 52);
            this.ReadContents.TabIndex = 4;
            this.ReadContents.Text = "Read Contens";
            this.ReadContents.UseVisualStyleBackColor = true;
            // 
            // showHideVocTop
            // 
            this.showHideVocTop.Location = new System.Drawing.Point(6, 45);
            this.showHideVocTop.Name = "showHideVocTop";
            this.showHideVocTop.Size = new System.Drawing.Size(121, 23);
            this.showHideVocTop.TabIndex = 5;
            this.showHideVocTop.Text = "Show Vocabulary";
            this.showHideVocTop.UseVisualStyleBackColor = true;
            this.showHideVocTop.Click += new System.EventHandler(this.showHideVocTop_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox15, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox16, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(256, 471);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.textBox3);
            this.groupBox15.Controls.Add(this.textBox2);
            this.groupBox15.Controls.Add(this.textBox1);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.Location = new System.Drawing.Point(3, 3);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(250, 300);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Word Details";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.listView1);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox16.Location = new System.Drawing.Point(3, 309);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(250, 159);
            this.groupBox16.TabIndex = 1;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Words";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 53);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 78);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 65);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 149);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 145);
            this.textBox3.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(244, 140);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // IELTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 595);
            this.Controls.Add(this.introduction);
            this.Name = "IELTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IELTS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.introduction.ResumeLayout(false);
            this.intro.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.reading.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.speaking.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.vocabulary.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.topicDetailsQuestionPanel.ResumeLayout(false);
            this.vocabularyTopicPanel.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl introduction;
        private System.Windows.Forms.TabPage intro;
        private System.Windows.Forms.TabPage writing;
        private System.Windows.Forms.TabPage listening;
        private System.Windows.Forms.TabPage speaking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser introWeb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage vocabulary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox banglaMeaning;
        private System.Windows.Forms.TextBox englishWord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView vocabularyListView;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox searchVocabulary;
        private System.Windows.Forms.Button startTalking;
        private System.Windows.Forms.TextBox startLine;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage reading;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.WebBrowser readingWebview;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel topicDetailsQuestionPanel;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TableLayoutPanel vocabularyTopicPanel;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button ReadContents;
        private System.Windows.Forms.Button showHideQuestion;
        private System.Windows.Forms.Button showHideVocTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listView1;
    }
}