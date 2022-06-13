namespace UserInterface
{
    partial class FrmTypeProcess
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
            this.lblBookTypeName = new System.Windows.Forms.Label();
            this.txtBookTypeName = new System.Windows.Forms.TextBox();
            this.btnSaveBookType = new System.Windows.Forms.Button();
            this.dataGridViewBookType = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookTypeName
            // 
            this.lblBookTypeName.AutoSize = true;
            this.lblBookTypeName.Location = new System.Drawing.Point(111, 82);
            this.lblBookTypeName.Name = "lblBookTypeName";
            this.lblBookTypeName.Size = new System.Drawing.Size(90, 13);
            this.lblBookTypeName.TabIndex = 0;
            this.lblBookTypeName.Text = "Book Type Name";
            // 
            // txtBookTypeName
            // 
            this.txtBookTypeName.Location = new System.Drawing.Point(206, 79);
            this.txtBookTypeName.Name = "txtBookTypeName";
            this.txtBookTypeName.Size = new System.Drawing.Size(166, 20);
            this.txtBookTypeName.TabIndex = 1;
            // 
            // btnSaveBookType
            // 
            this.btnSaveBookType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveBookType.Location = new System.Drawing.Point(401, 77);
            this.btnSaveBookType.Name = "btnSaveBookType";
            this.btnSaveBookType.Size = new System.Drawing.Size(75, 22);
            this.btnSaveBookType.TabIndex = 2;
            this.btnSaveBookType.Text = "Save";
            this.btnSaveBookType.UseVisualStyleBackColor = false;
            this.btnSaveBookType.Click += new System.EventHandler(this.btnSaveBookType_Click);
            // 
            // dataGridViewBookType
            // 
            this.dataGridViewBookType.AllowUserToAddRows = false;
            this.dataGridViewBookType.AllowUserToDeleteRows = false;
            this.dataGridViewBookType.AllowUserToOrderColumns = true;
            this.dataGridViewBookType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookType.Location = new System.Drawing.Point(12, 159);
            this.dataGridViewBookType.Name = "dataGridViewBookType";
            this.dataGridViewBookType.ReadOnly = true;
            this.dataGridViewBookType.Size = new System.Drawing.Size(591, 177);
            this.dataGridViewBookType.TabIndex = 3;
            // 
            // FrmTypeProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 348);
            this.Controls.Add(this.dataGridViewBookType);
            this.Controls.Add(this.btnSaveBookType);
            this.Controls.Add(this.txtBookTypeName);
            this.Controls.Add(this.lblBookTypeName);
            this.Name = "FrmTypeProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTypeProcess";
            this.Load += new System.EventHandler(this.FrmTypeProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookTypeName;
        private System.Windows.Forms.TextBox txtBookTypeName;
        private System.Windows.Forms.Button btnSaveBookType;
        private System.Windows.Forms.DataGridView dataGridViewBookType;
    }
}