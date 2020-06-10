namespace QuizApp_1._0
{
    partial class QuizForm
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
            this.radioOption1 = new System.Windows.Forms.RadioButton();
            this.radioOption3 = new System.Windows.Forms.RadioButton();
            this.radioOption2 = new System.Windows.Forms.RadioButton();
            this.radioOption4 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.QuestCount = new System.Windows.Forms.Label();
            this.btnCleanAll = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblQRemaining = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioOption1
            // 
            this.radioOption1.AutoSize = true;
            this.radioOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOption1.Location = new System.Drawing.Point(8, 31);
            this.radioOption1.Margin = new System.Windows.Forms.Padding(4);
            this.radioOption1.Name = "radioOption1";
            this.radioOption1.Size = new System.Drawing.Size(113, 22);
            this.radioOption1.TabIndex = 0;
            this.radioOption1.Text = "radioButton1";
            this.radioOption1.UseVisualStyleBackColor = true;
            // 
            // radioOption3
            // 
            this.radioOption3.AutoSize = true;
            this.radioOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOption3.Location = new System.Drawing.Point(8, 95);
            this.radioOption3.Margin = new System.Windows.Forms.Padding(4);
            this.radioOption3.Name = "radioOption3";
            this.radioOption3.Size = new System.Drawing.Size(113, 22);
            this.radioOption3.TabIndex = 1;
            this.radioOption3.Text = "radioButton3";
            this.radioOption3.UseVisualStyleBackColor = true;
            // 
            // radioOption2
            // 
            this.radioOption2.AutoSize = true;
            this.radioOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOption2.Location = new System.Drawing.Point(8, 63);
            this.radioOption2.Margin = new System.Windows.Forms.Padding(4);
            this.radioOption2.Name = "radioOption2";
            this.radioOption2.Size = new System.Drawing.Size(113, 22);
            this.radioOption2.TabIndex = 2;
            this.radioOption2.Text = "radioButton2";
            this.radioOption2.UseVisualStyleBackColor = true;
            // 
            // radioOption4
            // 
            this.radioOption4.AutoSize = true;
            this.radioOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOption4.Location = new System.Drawing.Point(8, 127);
            this.radioOption4.Margin = new System.Windows.Forms.Padding(4);
            this.radioOption4.Name = "radioOption4";
            this.radioOption4.Size = new System.Drawing.Size(113, 22);
            this.radioOption4.TabIndex = 3;
            this.radioOption4.Text = "radioButton4";
            this.radioOption4.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 58);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(750, 123);
            this.lblQuestion.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNext.Location = new System.Drawing.Point(40, 74);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(193, 28);
            this.btnNext.TabIndex = 5;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(40, 119);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(193, 28);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "<= Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // QuestCount
            // 
            this.QuestCount.Location = new System.Drawing.Point(393, 23);
            this.QuestCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestCount.Name = "QuestCount";
            this.QuestCount.Size = new System.Drawing.Size(40, 28);
            this.QuestCount.TabIndex = 7;
            this.QuestCount.Text = "0";
            this.QuestCount.Visible = false;
            // 
            // btnCleanAll
            // 
            this.btnCleanAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCleanAll.Location = new System.Drawing.Point(40, 28);
            this.btnCleanAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnCleanAll.Name = "btnCleanAll";
            this.btnCleanAll.Size = new System.Drawing.Size(193, 28);
            this.btnCleanAll.TabIndex = 8;
            this.btnCleanAll.TabStop = false;
            this.btnCleanAll.Text = "Clear Response";
            this.btnCleanAll.UseVisualStyleBackColor = true;
            this.btnCleanAll.Click += new System.EventHandler(this.btnCleanAll_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(563, 378);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(157, 34);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblQRemaining
            // 
            this.lblQRemaining.Location = new System.Drawing.Point(468, 17);
            this.lblQRemaining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQRemaining.Name = "lblQRemaining";
            this.lblQRemaining.Size = new System.Drawing.Size(205, 28);
            this.lblQRemaining.TabIndex = 12;
            this.lblQRemaining.Text = "popo";
            this.lblQRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(316, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "You Got :";
            this.label2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCleanAll);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(487, 187);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(276, 162);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioOption1);
            this.groupBox2.Controls.Add(this.radioOption3);
            this.groupBox2.Controls.Add(this.radioOption2);
            this.groupBox2.Controls.Add(this.radioOption4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(467, 171);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 22);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.QuestCount);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.lblQRemaining);
            this.panel2.Controls.Add(this.lblQuestion);
            this.panel2.Location = new System.Drawing.Point(16, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 432);
            this.panel2.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 17);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 34);
            this.btnExit.TabIndex = 21;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 633);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(810, 22);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 633);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.OrangeRed;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1, 654);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(809, 1);
            this.panel5.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(17, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 37);
            this.label3.TabIndex = 28;
            this.label3.Text = "Quiz 1.0";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(811, 655);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuizForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioOption1;
        private System.Windows.Forms.RadioButton radioOption3;
        private System.Windows.Forms.RadioButton radioOption2;
        private System.Windows.Forms.RadioButton radioOption4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label QuestCount;
        public System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnCleanAll;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblQRemaining;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
    }
}

