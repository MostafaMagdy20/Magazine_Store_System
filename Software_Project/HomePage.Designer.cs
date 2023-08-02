
namespace Software_Project
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.report = new System.Windows.Forms.Button();
            this.magazine_name = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.search_author = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.buy = new System.Windows.Forms.Button();
            this.searchmagazine = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.authorname = new System.Windows.Forms.RichTextBox();
            this.magName = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.report);
            this.panel1.Controls.Add(this.magazine_name);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.search_author);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.buy);
            this.panel1.Controls.Add(this.searchmagazine);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.authorname);
            this.panel1.Controls.Add(this.magName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 584);
            this.panel1.TabIndex = 0;
            // 
            // report
            // 
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.SystemColors.ControlText;
            this.report.Location = new System.Drawing.Point(419, 523);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(300, 39);
            this.report.TabIndex = 14;
            this.report.Text = "to view report click here";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // magazine_name
            // 
            this.magazine_name.Location = new System.Drawing.Point(344, 457);
            this.magazine_name.Name = "magazine_name";
            this.magazine_name.Size = new System.Drawing.Size(284, 38);
            this.magazine_name.TabIndex = 12;
            this.magazine_name.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(901, 387);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // search_author
            // 
            this.search_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_author.ForeColor = System.Drawing.SystemColors.ControlText;
            this.search_author.Location = new System.Drawing.Point(669, 380);
            this.search_author.Name = "search_author";
            this.search_author.Size = new System.Drawing.Size(206, 33);
            this.search_author.TabIndex = 10;
            this.search_author.Text = "search by author";
            this.search_author.UseVisualStyleBackColor = true;
            this.search_author.Click += new System.EventHandler(this.search_author_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(23, 468);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(194, 29);
            this.label.TabIndex = 9;
            this.label.Text = "Magazine Name:";
            // 
            // buy
            // 
            this.buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buy.Location = new System.Drawing.Point(669, 458);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(157, 39);
            this.buy.TabIndex = 8;
            this.buy.Text = "buy";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // searchmagazine
            // 
            this.searchmagazine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchmagazine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchmagazine.Location = new System.Drawing.Point(669, 275);
            this.searchmagazine.Name = "searchmagazine";
            this.searchmagazine.Size = new System.Drawing.Size(206, 33);
            this.searchmagazine.TabIndex = 7;
            this.searchmagazine.Text = "search magazine";
            this.searchmagazine.UseVisualStyleBackColor = true;
            this.searchmagazine.Click += new System.EventHandler(this.searchmagazine_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(633, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "UserInfo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(808, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 42);
            this.label4.TabIndex = 5;
            this.label4.Text = "here";
            // 
            // authorname
            // 
            this.authorname.Location = new System.Drawing.Point(344, 372);
            this.authorname.Name = "authorname";
            this.authorname.Size = new System.Drawing.Size(284, 36);
            this.authorname.TabIndex = 4;
            this.authorname.Text = "";
            // 
            // magName
            // 
            this.magName.Location = new System.Drawing.Point(344, 270);
            this.magName.Name = "magName";
            this.magName.Size = new System.Drawing.Size(284, 38);
            this.magName.TabIndex = 3;
            this.magName.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search By Author Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search By Magazine Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Home Page";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 585);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox authorname;
        private System.Windows.Forms.RichTextBox magName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        User user;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Button searchmagazine;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button search_author;
        private System.Windows.Forms.RichTextBox magazine_name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button report;
    }
}