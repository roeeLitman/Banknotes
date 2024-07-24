namespace Banknotes
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
            this.combYear = new System.Windows.Forms.ComboBox();
            this.combManth = new System.Windows.Forms.ComboBox();
            this.combNumWeek = new System.Windows.Forms.ComboBox();
            this.txtDateWeek = new System.Windows.Forms.ComboBox();
            this.btmCreate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combYear
            // 
            this.combYear.FormattingEnabled = true;
            this.combYear.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.combYear.Items.AddRange(new object[] {
            "תשפד",
            "תשפה",
            "תשפו"});
            this.combYear.Location = new System.Drawing.Point(189, 50);
            this.combYear.Name = "combYear";
            this.combYear.Size = new System.Drawing.Size(121, 24);
            this.combYear.TabIndex = 0;
            // 
            // combManth
            // 
            this.combManth.FormattingEnabled = true;
            this.combManth.Items.AddRange(new object[] {
            "תשרי",
            "מרחשוון",
            "כסלו",
            "טבת",
            "שבט",
            "אדר",
            "ניסן",
            "אייר",
            "סיון",
            "תמוז",
            "אב",
            "אלול"});
            this.combManth.Location = new System.Drawing.Point(342, 50);
            this.combManth.Name = "combManth";
            this.combManth.Size = new System.Drawing.Size(121, 24);
            this.combManth.TabIndex = 1;
            // 
            // combNumWeek
            // 
            this.combNumWeek.FormattingEnabled = true;
            this.combNumWeek.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.combNumWeek.Location = new System.Drawing.Point(493, 50);
            this.combNumWeek.Name = "combNumWeek";
            this.combNumWeek.Size = new System.Drawing.Size(121, 24);
            this.combNumWeek.TabIndex = 2;
            // 
            // txtDateWeek
            // 
            this.txtDateWeek.FormattingEnabled = true;
            this.txtDateWeek.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "ששי"});
            this.txtDateWeek.Location = new System.Drawing.Point(635, 50);
            this.txtDateWeek.Name = "txtDateWeek";
            this.txtDateWeek.Size = new System.Drawing.Size(121, 24);
            this.txtDateWeek.TabIndex = 3;
            // 
            // btmCreate
            // 
            this.btmCreate.Location = new System.Drawing.Point(613, 153);
            this.btmCreate.Name = "btmCreate";
            this.btmCreate.Size = new System.Drawing.Size(75, 23);
            this.btmCreate.TabIndex = 4;
            this.btmCreate.Text = "יצירה";
            this.btmCreate.UseVisualStyleBackColor = true;
            this.btmCreate.Click += new System.EventHandler(this.btmCreate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 384);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(699, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "יום בשבוע";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "יוםב חודש ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "חודשים";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "שנה";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btmCreate);
            this.Controls.Add(this.txtDateWeek);
            this.Controls.Add(this.combNumWeek);
            this.Controls.Add(this.combManth);
            this.Controls.Add(this.combYear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combYear;
        private System.Windows.Forms.ComboBox combManth;
        private System.Windows.Forms.ComboBox combNumWeek;
        private System.Windows.Forms.ComboBox txtDateWeek;
        private System.Windows.Forms.Button btmCreate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

