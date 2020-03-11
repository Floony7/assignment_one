namespace FredLunjevich_Assignment3
{
    partial class StudentPerformance
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
            this.AppHeader = new System.Windows.Forms.Label();
            this.showAllButton = new System.Windows.Forms.Button();
            this.gradStudentButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AppHeader
            // 
            this.AppHeader.AutoSize = true;
            this.AppHeader.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AppHeader.Location = new System.Drawing.Point(138, 26);
            this.AppHeader.Name = "AppHeader";
            this.AppHeader.Size = new System.Drawing.Size(503, 32);
            this.AppHeader.TabIndex = 0;
            this.AppHeader.Text = "Student Performance Portal";
            // 
            // showAllButton
            // 
            this.showAllButton.BackColor = System.Drawing.Color.Navy;
            this.showAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showAllButton.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllButton.ForeColor = System.Drawing.Color.White;
            this.showAllButton.Location = new System.Drawing.Point(129, 152);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Padding = new System.Windows.Forms.Padding(7);
            this.showAllButton.Size = new System.Drawing.Size(230, 37);
            this.showAllButton.TabIndex = 1;
            this.showAllButton.Text = "Show Marks of All Students";
            this.showAllButton.UseVisualStyleBackColor = false;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // gradStudentButton
            // 
            this.gradStudentButton.BackColor = System.Drawing.Color.Navy;
            this.gradStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gradStudentButton.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradStudentButton.ForeColor = System.Drawing.Color.White;
            this.gradStudentButton.Location = new System.Drawing.Point(447, 152);
            this.gradStudentButton.Name = "gradStudentButton";
            this.gradStudentButton.Padding = new System.Windows.Forms.Padding(7);
            this.gradStudentButton.Size = new System.Drawing.Size(230, 37);
            this.gradStudentButton.TabIndex = 2;
            this.gradStudentButton.Text = "Grade a Student";
            this.gradStudentButton.UseVisualStyleBackColor = false;
            this.gradStudentButton.Click += new System.EventHandler(this.gradStudentButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(636, 391);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(7);
            this.button3.Size = new System.Drawing.Size(152, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exit Application";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StudentPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gradStudentButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.AppHeader);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "StudentPerformance";
            this.Text = "Student Performance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppHeader;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button gradStudentButton;
        private System.Windows.Forms.Button button3;
    }
}

