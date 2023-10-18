namespace Anket_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mailTxtbox = new System.Windows.Forms.TextBox();
            this.surnameTxtbox = new System.Windows.Forms.TextBox();
            this.nameTxtbox = new System.Windows.Forms.TextBox();
            this.birthdayLbr = new System.Windows.Forms.Label();
            this.telLbr = new System.Windows.Forms.Label();
            this.mailLbr = new System.Windows.Forms.Label();
            this.surnamelbr = new System.Windows.Forms.Label();
            this.nameLbr = new System.Windows.Forms.Label();
            this.userSaverLog = new System.Windows.Forms.ListBox();
            this.fileSaveTxtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loadBtr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.telTxtbox = new System.Windows.Forms.MaskedTextBox();
            this.birthdayTxtbox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBtr = new System.Windows.Forms.Button();
            this.changeBtr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.birthdayTxtbox);
            this.groupBox1.Controls.Add(this.telTxtbox);
            this.groupBox1.Controls.Add(this.changeBtr);
            this.groupBox1.Controls.Add(this.saveBtr);
            this.groupBox1.Controls.Add(this.mailTxtbox);
            this.groupBox1.Controls.Add(this.surnameTxtbox);
            this.groupBox1.Controls.Add(this.nameTxtbox);
            this.groupBox1.Controls.Add(this.birthdayLbr);
            this.groupBox1.Controls.Add(this.telLbr);
            this.groupBox1.Controls.Add(this.mailLbr);
            this.groupBox1.Controls.Add(this.surnamelbr);
            this.groupBox1.Controls.Add(this.nameLbr);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // mailTxtbox
            // 
            this.mailTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTxtbox.Location = new System.Drawing.Point(102, 135);
            this.mailTxtbox.Multiline = true;
            this.mailTxtbox.Name = "mailTxtbox";
            this.mailTxtbox.Size = new System.Drawing.Size(175, 25);
            this.mailTxtbox.TabIndex = 9;
            this.mailTxtbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // surnameTxtbox
            // 
            this.surnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTxtbox.Location = new System.Drawing.Point(102, 83);
            this.surnameTxtbox.Multiline = true;
            this.surnameTxtbox.Name = "surnameTxtbox";
            this.surnameTxtbox.Size = new System.Drawing.Size(175, 25);
            this.surnameTxtbox.TabIndex = 8;
            // 
            // nameTxtbox
            // 
            this.nameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtbox.Location = new System.Drawing.Point(102, 31);
            this.nameTxtbox.Multiline = true;
            this.nameTxtbox.Name = "nameTxtbox";
            this.nameTxtbox.Size = new System.Drawing.Size(175, 25);
            this.nameTxtbox.TabIndex = 7;
            // 
            // birthdayLbr
            // 
            this.birthdayLbr.AutoSize = true;
            this.birthdayLbr.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLbr.Location = new System.Drawing.Point(19, 247);
            this.birthdayLbr.Name = "birthdayLbr";
            this.birthdayLbr.Size = new System.Drawing.Size(71, 18);
            this.birthdayLbr.TabIndex = 6;
            this.birthdayLbr.Text = "Birthday";
            // 
            // telLbr
            // 
            this.telLbr.AutoSize = true;
            this.telLbr.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telLbr.Location = new System.Drawing.Point(38, 190);
            this.telLbr.Name = "telLbr";
            this.telLbr.Size = new System.Drawing.Size(30, 18);
            this.telLbr.TabIndex = 5;
            this.telLbr.Text = "Tel";
            // 
            // mailLbr
            // 
            this.mailLbr.AutoSize = true;
            this.mailLbr.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailLbr.Location = new System.Drawing.Point(35, 139);
            this.mailLbr.Name = "mailLbr";
            this.mailLbr.Size = new System.Drawing.Size(39, 18);
            this.mailLbr.TabIndex = 4;
            this.mailLbr.Text = "Mail";
            // 
            // surnamelbr
            // 
            this.surnamelbr.AutoSize = true;
            this.surnamelbr.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnamelbr.Location = new System.Drawing.Point(16, 86);
            this.surnamelbr.Name = "surnamelbr";
            this.surnamelbr.Size = new System.Drawing.Size(77, 18);
            this.surnamelbr.TabIndex = 3;
            this.surnamelbr.Text = "Surname";
            this.surnamelbr.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameLbr
            // 
            this.nameLbr.AutoSize = true;
            this.nameLbr.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbr.Location = new System.Drawing.Point(30, 35);
            this.nameLbr.Name = "nameLbr";
            this.nameLbr.Size = new System.Drawing.Size(52, 18);
            this.nameLbr.TabIndex = 2;
            this.nameLbr.Text = "Name";
            // 
            // userSaverLog
            // 
            this.userSaverLog.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSaverLog.FormattingEnabled = true;
            this.userSaverLog.ItemHeight = 29;
            this.userSaverLog.Location = new System.Drawing.Point(322, 68);
            this.userSaverLog.Name = "userSaverLog";
            this.userSaverLog.Size = new System.Drawing.Size(194, 236);
            this.userSaverLog.TabIndex = 1;
            // 
            // fileSaveTxtbox
            // 
            this.fileSaveTxtbox.Location = new System.Drawing.Point(392, 317);
            this.fileSaveTxtbox.Multiline = true;
            this.fileSaveTxtbox.Name = "fileSaveTxtbox";
            this.fileSaveTxtbox.Size = new System.Drawing.Size(122, 25);
            this.fileSaveTxtbox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(431, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // loadBtr
            // 
            this.loadBtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtr.Location = new System.Drawing.Point(319, 357);
            this.loadBtr.Name = "loadBtr";
            this.loadBtr.Size = new System.Drawing.Size(90, 35);
            this.loadBtr.TabIndex = 14;
            this.loadBtr.Text = "Load";
            this.loadBtr.UseVisualStyleBackColor = true;
            this.loadBtr.Click += new System.EventHandler(this.loadBtr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Save:";
            // 
            // telTxtbox
            // 
            this.telTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telTxtbox.Location = new System.Drawing.Point(102, 191);
            this.telTxtbox.Mask = "(000) - 000-00-00";
            this.telTxtbox.Name = "telTxtbox";
            this.telTxtbox.Size = new System.Drawing.Size(175, 26);
            this.telTxtbox.TabIndex = 13;
            // 
            // birthdayTxtbox
            // 
            this.birthdayTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayTxtbox.Location = new System.Drawing.Point(102, 247);
            this.birthdayTxtbox.Mask = "00/00/0000";
            this.birthdayTxtbox.Name = "birthdayTxtbox";
            this.birthdayTxtbox.Size = new System.Drawing.Size(175, 26);
            this.birthdayTxtbox.TabIndex = 14;
            this.birthdayTxtbox.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "User Log";
            // 
            // saveBtr
            // 
            this.saveBtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtr.Location = new System.Drawing.Point(178, 314);
            this.saveBtr.Name = "saveBtr";
            this.saveBtr.Size = new System.Drawing.Size(99, 35);
            this.saveBtr.TabIndex = 2;
            this.saveBtr.Text = "SAVE";
            this.saveBtr.UseVisualStyleBackColor = true;
            this.saveBtr.Click += new System.EventHandler(this.button1_Click);
            // 
            // changeBtr
            // 
            this.changeBtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBtr.Location = new System.Drawing.Point(22, 314);
            this.changeBtr.Name = "changeBtr";
            this.changeBtr.Size = new System.Drawing.Size(99, 35);
            this.changeBtr.TabIndex = 12;
            this.changeBtr.Text = "CHANGE";
            this.changeBtr.UseVisualStyleBackColor = true;
            this.changeBtr.Click += new System.EventHandler(this.changeBtr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadBtr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileSaveTxtbox);
            this.Controls.Add(this.userSaverLog);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "User İnformation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label surnamelbr;
        private System.Windows.Forms.Label nameLbr;
        private System.Windows.Forms.ListBox userSaverLog;
        private System.Windows.Forms.TextBox mailTxtbox;
        private System.Windows.Forms.TextBox surnameTxtbox;
        private System.Windows.Forms.TextBox nameTxtbox;
        private System.Windows.Forms.Label birthdayLbr;
        private System.Windows.Forms.Label telLbr;
        private System.Windows.Forms.Label mailLbr;
        private System.Windows.Forms.TextBox fileSaveTxtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loadBtr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox birthdayTxtbox;
        private System.Windows.Forms.MaskedTextBox telTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBtr;
        private System.Windows.Forms.Button changeBtr;
    }
}

