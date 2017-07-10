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
            this.introduction.SuspendLayout();
            this.intro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.reading.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // introduction
            // 
            this.introduction.Controls.Add(this.intro);
            this.introduction.Controls.Add(this.reading);
            this.introduction.Controls.Add(this.writing);
            this.introduction.Controls.Add(this.listening);
            this.introduction.Controls.Add(this.speaking);
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
            this.speaking.Location = new System.Drawing.Point(4, 22);
            this.speaking.Name = "speaking";
            this.speaking.Padding = new System.Windows.Forms.Padding(3);
            this.speaking.Size = new System.Drawing.Size(1343, 569);
            this.speaking.TabIndex = 4;
            this.speaking.Text = "Speaking";
            this.speaking.UseVisualStyleBackColor = true;
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
    }
}