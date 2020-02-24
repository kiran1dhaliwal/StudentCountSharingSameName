namespace StudentsName
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
            this.addStudentNameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudentNameBtn
            // 
            this.addStudentNameBtn.Location = new System.Drawing.Point(549, 114);
            this.addStudentNameBtn.Name = "addStudentNameBtn";
            this.addStudentNameBtn.Size = new System.Drawing.Size(168, 35);
            this.addStudentNameBtn.TabIndex = 0;
            this.addStudentNameBtn.Text = "Add Student Name";
            this.addStudentNameBtn.UseVisualStyleBackColor = true;
            this.addStudentNameBtn.Click += new System.EventHandler(this.addStudentNameBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Student Name";
            // 
            // studentNameText
            // 
            this.studentNameText.Location = new System.Drawing.Point(351, 114);
            this.studentNameText.Name = "studentNameText";
            this.studentNameText.Size = new System.Drawing.Size(169, 26);
            this.studentNameText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter student name below you want to search for";
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(316, 256);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(161, 26);
            this.searchNameTextBox.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(351, 298);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(102, 41);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addStudentNameBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStudentNameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.Button searchBtn;
    }
}

