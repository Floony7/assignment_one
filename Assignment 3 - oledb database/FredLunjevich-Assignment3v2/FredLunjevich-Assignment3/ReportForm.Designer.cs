namespace FredLunjevich_Assignment3
{
    partial class ReportForm
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
            this.mainWindowButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.AppHeader = new System.Windows.Forms.Label();
            this.idInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gradeLevel = new System.Windows.Forms.TextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.marksAllCourses = new System.Windows.Forms.TextBox();
            this.MaxMarksTextBox = new System.Windows.Forms.TextBox();
            this.MinMarksTextBox = new System.Windows.Forms.TextBox();
            this.avgTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWindowButton
            // 
            this.mainWindowButton.BackColor = System.Drawing.Color.Navy;
            this.mainWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainWindowButton.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainWindowButton.ForeColor = System.Drawing.Color.White;
            this.mainWindowButton.Location = new System.Drawing.Point(604, 622);
            this.mainWindowButton.Margin = new System.Windows.Forms.Padding(4);
            this.mainWindowButton.Name = "mainWindowButton";
            this.mainWindowButton.Padding = new System.Windows.Forms.Padding(9);
            this.mainWindowButton.Size = new System.Drawing.Size(213, 57);
            this.mainWindowButton.TabIndex = 4;
            this.mainWindowButton.Text = "Main Window";
            this.mainWindowButton.UseVisualStyleBackColor = false;
            this.mainWindowButton.Click += new System.EventHandler(this.mainWindowButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(838, 620);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(9);
            this.button3.Size = new System.Drawing.Size(203, 58);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit Application";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AppHeader
            // 
            this.AppHeader.AutoSize = true;
            this.AppHeader.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AppHeader.Location = new System.Drawing.Point(105, 9);
            this.AppHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AppHeader.Name = "AppHeader";
            this.AppHeader.Size = new System.Drawing.Size(277, 32);
            this.AppHeader.TabIndex = 7;
            this.AppHeader.Text = "Student Report";
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(104, 34);
            this.idInput.Margin = new System.Windows.Forms.Padding(4);
            this.idInput.MaxLength = 3;
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(132, 22);
            this.idInput.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IDTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.idInput);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(113, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 192);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Location = new System.Drawing.Point(218, 127);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(42, 22);
            this.IDTextBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Record Retrieved for Student: ";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Blue;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(39, 73);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.gradeLevel);
            this.groupBox2.Controls.Add(this.gradeLabel);
            this.groupBox2.Controls.Add(this.marksAllCourses);
            this.groupBox2.Controls.Add(this.MaxMarksTextBox);
            this.groupBox2.Controls.Add(this.MinMarksTextBox);
            this.groupBox2.Controls.Add(this.avgTextBox);
            this.groupBox2.Controls.Add(this.lastnameTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.firstnameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(428, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(623, 508);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details Found";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 461);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Grade Level";
            // 
            // gradeLevel
            // 
            this.gradeLevel.Enabled = false;
            this.gradeLevel.Location = new System.Drawing.Point(257, 457);
            this.gradeLevel.Margin = new System.Windows.Forms.Padding(4);
            this.gradeLevel.Name = "gradeLevel";
            this.gradeLevel.Size = new System.Drawing.Size(160, 22);
            this.gradeLevel.TabIndex = 13;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(144, 528);
            this.gradeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(0, 16);
            this.gradeLabel.TabIndex = 12;
            // 
            // marksAllCourses
            // 
            this.marksAllCourses.Enabled = false;
            this.marksAllCourses.Location = new System.Drawing.Point(257, 228);
            this.marksAllCourses.Margin = new System.Windows.Forms.Padding(4);
            this.marksAllCourses.Multiline = true;
            this.marksAllCourses.Name = "marksAllCourses";
            this.marksAllCourses.Size = new System.Drawing.Size(328, 202);
            this.marksAllCourses.TabIndex = 11;
            // 
            // MaxMarksTextBox
            // 
            this.MaxMarksTextBox.Enabled = false;
            this.MaxMarksTextBox.Location = new System.Drawing.Point(257, 180);
            this.MaxMarksTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MaxMarksTextBox.Name = "MaxMarksTextBox";
            this.MaxMarksTextBox.Size = new System.Drawing.Size(132, 22);
            this.MaxMarksTextBox.TabIndex = 10;
            // 
            // MinMarksTextBox
            // 
            this.MinMarksTextBox.Enabled = false;
            this.MinMarksTextBox.Location = new System.Drawing.Point(257, 144);
            this.MinMarksTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MinMarksTextBox.Name = "MinMarksTextBox";
            this.MinMarksTextBox.Size = new System.Drawing.Size(132, 22);
            this.MinMarksTextBox.TabIndex = 9;
            // 
            // avgTextBox
            // 
            this.avgTextBox.Enabled = false;
            this.avgTextBox.Location = new System.Drawing.Point(257, 108);
            this.avgTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.avgTextBox.Name = "avgTextBox";
            this.avgTextBox.Size = new System.Drawing.Size(132, 22);
            this.avgTextBox.TabIndex = 8;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Enabled = false;
            this.lastnameTextBox.Location = new System.Drawing.Point(257, 73);
            this.lastnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(328, 22);
            this.lastnameTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Highest Mark";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lowest Mark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Average Mark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lastname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Enabled = false;
            this.firstnameTextBox.Location = new System.Drawing.Point(257, 38);
            this.firstnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(328, 22);
            this.firstnameTextBox.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AppHeader);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mainWindowButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainWindowButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label AppHeader;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox marksAllCourses;
        private System.Windows.Forms.TextBox MaxMarksTextBox;
        private System.Windows.Forms.TextBox MinMarksTextBox;
        private System.Windows.Forms.TextBox avgTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox gradeLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label9;
    }
}