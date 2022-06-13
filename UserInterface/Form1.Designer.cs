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
            this.SuspendLayout();
            // 
            // btnTypeProcess
            // 
            this.btnTypeProcess.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTypeProcess.Location = new System.Drawing.Point(88, 70);
            this.btnTypeProcess.Name = "btnTypeProcess";
            this.btnTypeProcess.Size = new System.Drawing.Size(219, 113);
            this.btnTypeProcess.TabIndex = 0;
            this.btnTypeProcess.Text = "Type Process";
            this.btnTypeProcess.UseVisualStyleBackColor = false;
            this.btnTypeProcess.Click += new System.EventHandler(this.btnTypeProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 391);
            this.Controls.Add(this.btnTypeProcess);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Book Store";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTypeProcess;
    }
}

