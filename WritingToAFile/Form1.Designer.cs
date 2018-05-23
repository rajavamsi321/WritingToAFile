namespace WritingToAFile
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
            this.sfdRandomNumber = new System.Windows.Forms.SaveFileDialog();
            this.lblHowManyNum = new System.Windows.Forms.Label();
            this.tBoxHowManyNum = new System.Windows.Forms.TextBox();
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHowManyNum
            // 
            this.lblHowManyNum.AutoSize = true;
            this.lblHowManyNum.Location = new System.Drawing.Point(178, 74);
            this.lblHowManyNum.Name = "lblHowManyNum";
            this.lblHowManyNum.Size = new System.Drawing.Size(229, 17);
            this.lblHowManyNum.TabIndex = 0;
            this.lblHowManyNum.Text = "Enter How Many Random Numbers";
            // 
            // tBoxHowManyNum
            // 
            this.tBoxHowManyNum.Location = new System.Drawing.Point(473, 69);
            this.tBoxHowManyNum.Name = "tBoxHowManyNum";
            this.tBoxHowManyNum.Size = new System.Drawing.Size(100, 22);
            this.tBoxHowManyNum.TabIndex = 1;
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.Location = new System.Drawing.Point(473, 140);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(100, 55);
            this.btnWriteToFile.TabIndex = 2;
            this.btnWriteToFile.Text = "Write To A File";
            this.btnWriteToFile.UseVisualStyleBackColor = true;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWriteToFile);
            this.Controls.Add(this.tBoxHowManyNum);
            this.Controls.Add(this.lblHowManyNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog sfdRandomNumber;
        private System.Windows.Forms.Label lblHowManyNum;
        private System.Windows.Forms.TextBox tBoxHowManyNum;
        private System.Windows.Forms.Button btnWriteToFile;
    }
}

