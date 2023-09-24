namespace Account_Registration {
    partial class FrmRegistration {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnNext = new Button();
            cbprogram = new ComboBox();
            tbstnum = new TextBox();
            tblname = new TextBox();
            tbfname = new TextBox();
            tbmname = new TextBox();
            tbage = new TextBox();
            tbcontact = new TextBox();
            rtbaddress = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 25);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 1;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 96);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 96);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 3;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(543, 96);
            label5.Name = "label5";
            label5.Size = new Size(131, 28);
            label5.TabIndex = 4;
            label5.Text = "Middle Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 164);
            label6.Name = "label6";
            label6.Size = new Size(51, 28);
            label6.TabIndex = 5;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(302, 164);
            label7.Name = "label7";
            label7.Size = new Size(120, 28);
            label7.TabIndex = 6;
            label7.Text = "Contact No.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 264);
            label8.Name = "label8";
            label8.Size = new Size(82, 28);
            label8.TabIndex = 7;
            label8.Text = "Address";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(344, 465);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(134, 45);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // cbprogram
            // 
            cbprogram.FormattingEnabled = true;
            cbprogram.Items.AddRange(new object[] { "BS in Information Technology", "BS in Multimedia Arts", "BS in Computer Science", "BS in Computer Engineering", "BS in Tourism Management" });
            cbprogram.Location = new Point(289, 56);
            cbprogram.Name = "cbprogram";
            cbprogram.Size = new Size(502, 36);
            cbprogram.TabIndex = 9;
            // 
            // tbstnum
            // 
            tbstnum.Location = new Point(35, 56);
            tbstnum.Name = "tbstnum";
            tbstnum.Size = new Size(248, 34);
            tbstnum.TabIndex = 10;
            // 
            // tblname
            // 
            tblname.Location = new Point(35, 127);
            tblname.Name = "tblname";
            tblname.Size = new Size(248, 34);
            tblname.TabIndex = 11;
            // 
            // tbfname
            // 
            tbfname.Location = new Point(289, 127);
            tbfname.Name = "tbfname";
            tbfname.Size = new Size(248, 34);
            tbfname.TabIndex = 12;
            // 
            // tbmname
            // 
            tbmname.Location = new Point(543, 127);
            tbmname.Name = "tbmname";
            tbmname.Size = new Size(248, 34);
            tbmname.TabIndex = 13;
            // 
            // tbage
            // 
            tbage.Location = new Point(35, 195);
            tbage.Name = "tbage";
            tbage.Size = new Size(248, 34);
            tbage.TabIndex = 14;
            // 
            // tbcontact
            // 
            tbcontact.Location = new Point(302, 195);
            tbcontact.Name = "tbcontact";
            tbcontact.Size = new Size(235, 34);
            tbcontact.TabIndex = 16;
            // 
            // rtbaddress
            // 
            rtbaddress.Location = new Point(35, 295);
            rtbaddress.Name = "rtbaddress";
            rtbaddress.Size = new Size(756, 152);
            rtbaddress.TabIndex = 17;
            rtbaddress.Text = "";
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(818, 529);
            Controls.Add(rtbaddress);
            Controls.Add(tbcontact);
            Controls.Add(tbage);
            Controls.Add(tbmname);
            Controls.Add(tbfname);
            Controls.Add(tblname);
            Controls.Add(tbstnum);
            Controls.Add(cbprogram);
            Controls.Add(btnNext);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnNext;
        private ComboBox cbprogram;
        private TextBox tbstnum;
        private TextBox tblname;
        private TextBox tbfname;
        private TextBox tbmname;
        private TextBox tbage;
        private TextBox tbcontact;
        private RichTextBox rtbaddress;
    }
}