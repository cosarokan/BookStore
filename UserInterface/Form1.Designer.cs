namespace UserInterface
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
            this.btnTypeProcess = new System.Windows.Forms.Button();
            this.btnBookProcess = new System.Windows.Forms.Button();
            this.btnAuthorProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTypeProcess
            // 
            this.btnTypeProcess.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTypeProcess.Location = new System.Drawing.Point(88, 70);
            this.btnTypeProcess.Name = "btnTypeProcess";
            this.btnTypeProcess.Size = new System.Drawing.Size(219, 67);
            this.btnTypeProcess.TabIndex = 0;
            this.btnTypeProcess.Text = "Type Process";
            this.btnTypeProcess.UseVisualStyleBackColor = false;
            this.btnTypeProcess.Click += new System.EventHandler(this.btnTypeProcess_Click);
            // 
            // btnBookProcess
            // 
            this.btnBookProcess.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBookProcess.Location = new System.Drawing.Point(88, 155);
            this.btnBookProcess.Name = "btnBookProcess";
            this.btnBookProcess.Size = new System.Drawing.Size(219, 67);
            this.btnBookProcess.TabIndex = 1;
            this.btnBookProcess.Text = "Book Process";
            this.btnBookProcess.UseVisualStyleBackColor = false;
            this.btnBookProcess.Click += new System.EventHandler(this.btnBookProcess_Click);
            // 
            // btnAuthorProcess
            // 
            this.btnAuthorProcess.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAuthorProcess.Location = new System.Drawing.Point(88, 240);
            this.btnAuthorProcess.Name = "btnAuthorProcess";
            this.btnAuthorProcess.Size = new System.Drawing.Size(219, 65);
            this.btnAuthorProcess.TabIndex = 2;
            this.btnAuthorProcess.Text = "Author Process";
            this.btnAuthorProcess.UseVisualStyleBackColor = false;
            this.btnAuthorProcess.Click += new System.EventHandler(this.btnAuthorProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 391);
            this.Controls.Add(this.btnAuthorProcess);
            this.Controls.Add(this.btnBookProcess);
            this.Controls.Add(this.btnTypeProcess);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Book Store";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTypeProcess;
        private System.Windows.Forms.Button btnBookProcess;
        private System.Windows.Forms.Button btnAuthorProcess;
    }
}

