namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblNow = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.TextBox();
            this.lblTimeOfDay = new System.Windows.Forms.TextBox();
            this.lblTodayLong = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.TextBox();
            this.lblTodayShort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optInvariant = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFormat = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdFormat1 = new System.Windows.Forms.Button();
            this.cboStyle1 = new System.Windows.Forms.ComboBox();
            this.lblDisplay1 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "คำนวณพื้นที่";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(60, 18);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(210, 20);
            this.txtRadius.TabIndex = 1;
            // 
            // lblNow
            // 
            this.lblNow.Location = new System.Drawing.Point(60, 20);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(160, 20);
            this.lblNow.TabIndex = 2;
            // 
            // lblMonth
            // 
            this.lblMonth.Location = new System.Drawing.Point(226, 20);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(160, 20);
            this.lblMonth.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(60, 46);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(160, 20);
            this.lblDate.TabIndex = 4;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(226, 46);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(160, 20);
            this.lblYear.TabIndex = 5;
            // 
            // lblTimeOfDay
            // 
            this.lblTimeOfDay.Location = new System.Drawing.Point(60, 72);
            this.lblTimeOfDay.Name = "lblTimeOfDay";
            this.lblTimeOfDay.Size = new System.Drawing.Size(160, 20);
            this.lblTimeOfDay.TabIndex = 6;
            // 
            // lblTodayLong
            // 
            this.lblTodayLong.Location = new System.Drawing.Point(226, 72);
            this.lblTodayLong.Name = "lblTodayLong";
            this.lblTodayLong.Size = new System.Drawing.Size(160, 20);
            this.lblTodayLong.TabIndex = 7;
            // 
            // lblDay
            // 
            this.lblDay.Location = new System.Drawing.Point(60, 98);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(160, 20);
            this.lblDay.TabIndex = 8;
            // 
            // lblTodayShort
            // 
            this.lblTodayShort.Location = new System.Drawing.Point(226, 98);
            this.lblTodayShort.Name = "lblTodayShort";
            this.lblTodayShort.Size = new System.Drawing.Size(160, 20);
            this.lblTodayShort.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optInvariant);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(8, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 65);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "กำหนดลักษณะ";
            // 
            // optInvariant
            // 
            this.optInvariant.AutoSize = true;
            this.optInvariant.Location = new System.Drawing.Point(6, 42);
            this.optInvariant.Name = "optInvariant";
            this.optInvariant.Size = new System.Drawing.Size(211, 17);
            this.optInvariant.TabIndex = 1;
            this.optInvariant.TabStop = true;
            this.optInvariant.Text = "แบบ Date TimeFormatInfo.InvariantInfo";
            this.optInvariant.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(197, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "แบบ DatetimeFormatInfo.CurrentInfo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // cboStyle
            // 
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(113, 94);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(121, 21);
            this.cboStyle.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "กำหนดรูปแบบ";
            // 
            // cmdFormat
            // 
            this.cmdFormat.Location = new System.Drawing.Point(342, 68);
            this.cmdFormat.Name = "cmdFormat";
            this.cmdFormat.Size = new System.Drawing.Size(75, 23);
            this.cmdFormat.TabIndex = 14;
            this.cmdFormat.Text = "จัดรูปแบบ";
            this.cmdFormat.UseVisualStyleBackColor = true;
            this.cmdFormat.Click += new System.EventHandler(this.cmdFormat_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.Location = new System.Drawing.Point(244, 41);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(177, 20);
            this.lblDisplay.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ผลที่ได้:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmdFormat);
            this.groupBox2.Controls.Add(this.lblDisplay);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboStyle);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(43, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 140);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "การจัดรูปแบบวันที่และเวลา";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTodayShort);
            this.groupBox3.Controls.Add(this.lblDay);
            this.groupBox3.Controls.Add(this.lblTodayLong);
            this.groupBox3.Controls.Add(this.lblTimeOfDay);
            this.groupBox3.Controls.Add(this.lblYear);
            this.groupBox3.Controls.Add(this.lblDate);
            this.groupBox3.Controls.Add(this.lblMonth);
            this.groupBox3.Controls.Add(this.lblNow);
            this.groupBox3.Location = new System.Drawing.Point(43, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 132);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ทำงานกับข้อมูลชนิดวันที่และเวลาด้วยคลาส DateTime";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtRadius);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(43, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(436, 50);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "การใช้งานค่าคงที่";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.cmdFormat1);
            this.groupBox5.Controls.Add(this.cboStyle1);
            this.groupBox5.Controls.Add(this.lblDisplay1);
            this.groupBox5.Location = new System.Drawing.Point(43, 353);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(436, 91);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "การใช้งานวันที่ในรูปแบบภาษาไทย";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "รูปแบบ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ผลการทำงาน :";
            // 
            // cmdFormat1
            // 
            this.cmdFormat1.Location = new System.Drawing.Point(295, 27);
            this.cmdFormat1.Name = "cmdFormat1";
            this.cmdFormat1.Size = new System.Drawing.Size(103, 23);
            this.cmdFormat1.TabIndex = 2;
            this.cmdFormat1.Text = "จัดรูปแบบ";
            this.cmdFormat1.UseVisualStyleBackColor = true;
            this.cmdFormat1.Click += new System.EventHandler(this.cmdFormat1_Click);
            // 
            // cboStyle1
            // 
            this.cboStyle1.FormattingEnabled = true;
            this.cboStyle1.Location = new System.Drawing.Point(120, 55);
            this.cboStyle1.Name = "cboStyle1";
            this.cboStyle1.Size = new System.Drawing.Size(169, 21);
            this.cboStyle1.TabIndex = 1;
            // 
            // lblDisplay1
            // 
            this.lblDisplay1.Location = new System.Drawing.Point(120, 29);
            this.lblDisplay1.Name = "lblDisplay1";
            this.lblDisplay1.Size = new System.Drawing.Size(169, 20);
            this.lblDisplay1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.cmdConvert);
            this.groupBox6.Controls.Add(this.lblResult);
            this.groupBox6.Controls.Add(this.txtInput);
            this.groupBox6.Location = new System.Drawing.Point(43, 450);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(436, 82);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "พื้นฐานการแปลงข้อมูลแบบ Explicit";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(120, 19);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(169, 20);
            this.txtInput.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(120, 42);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(169, 23);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "\r\n";
            // 
            // cmdConvert
            // 
            this.cmdConvert.Location = new System.Drawing.Point(295, 42);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(75, 23);
            this.cmdConvert.TabIndex = 2;
            this.cmdConvert.Text = "แปลงข้อมูล";
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.cmdConvert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "ป้อนตัวเลข :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "ผลลัพธ์ :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 546);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรเจคแรกของกูใน Windows Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox lblNow;
        private System.Windows.Forms.TextBox lblMonth;
        private System.Windows.Forms.TextBox lblDate;
        private System.Windows.Forms.TextBox lblYear;
        private System.Windows.Forms.TextBox lblTimeOfDay;
        private System.Windows.Forms.TextBox lblTodayLong;
        private System.Windows.Forms.TextBox lblDay;
        private System.Windows.Forms.TextBox lblTodayShort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optInvariant;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdFormat;
        private System.Windows.Forms.TextBox lblDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button cmdFormat1;
        private System.Windows.Forms.ComboBox cboStyle1;
        private System.Windows.Forms.TextBox lblDisplay1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtInput;
    }
}

