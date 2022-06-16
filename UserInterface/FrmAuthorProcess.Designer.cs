namespace UserInterface
{
    partial class FrmAuthorProcess
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
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtAuthorSurname = new System.Windows.Forms.TextBox();
            this.lblAuthorSurname = new System.Windows.Forms.Label();
            this.dataGridViewAuthor = new System.Windows.Forms.DataGridView();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnUpdateAuthor = new System.Windows.Forms.Button();
            this.lblAuthorId = new System.Windows.Forms.Label();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Location = new System.Drawing.Point(59, 89);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(35, 13);
            this.lblAuthorName.TabIndex = 0;
            this.lblAuthorName.Text = "Name";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(148, 82);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(151, 20);
            this.txtAuthorName.TabIndex = 1;
            // 
            // txtAuthorSurname
            // 
            this.txtAuthorSurname.Location = new System.Drawing.Point(148, 121);
            this.txtAuthorSurname.Name = "txtAuthorSurname";
            this.txtAuthorSurname.Size = new System.Drawing.Size(151, 20);
            this.txtAuthorSurname.TabIndex = 2;
            // 
            // lblAuthorSurname
            // 
            this.lblAuthorSurname.AutoSize = true;
            this.lblAuthorSurname.Location = new System.Drawing.Point(59, 124);
            this.lblAuthorSurname.Name = "lblAuthorSurname";
            this.lblAuthorSurname.Size = new System.Drawing.Size(49, 13);
            this.lblAuthorSurname.TabIndex = 3;
            this.lblAuthorSurname.Text = "Surname";
            // 
            // dataGridViewAuthor
            // 
            this.dataGridViewAuthor.AllowUserToAddRows = false;
            this.dataGridViewAuthor.AllowUserToDeleteRows = false;
            this.dataGridViewAuthor.AllowUserToOrderColumns = true;
            this.dataGridViewAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthor.Location = new System.Drawing.Point(12, 179);
            this.dataGridViewAuthor.Name = "dataGridViewAuthor";
            this.dataGridViewAuthor.ReadOnly = true;
            this.dataGridViewAuthor.Size = new System.Drawing.Size(600, 150);
            this.dataGridViewAuthor.TabIndex = 6;
            this.dataGridViewAuthor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAuthor_CellDoubleClick);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAuthor.Location = new System.Drawing.Point(407, 48);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(104, 44);
            this.btnAddAuthor.TabIndex = 7;
            this.btnAddAuthor.Text = "Add";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnUpdateAuthor
            // 
            this.btnUpdateAuthor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateAuthor.Location = new System.Drawing.Point(407, 102);
            this.btnUpdateAuthor.Name = "btnUpdateAuthor";
            this.btnUpdateAuthor.Size = new System.Drawing.Size(104, 44);
            this.btnUpdateAuthor.TabIndex = 8;
            this.btnUpdateAuthor.Text = "Update";
            this.btnUpdateAuthor.UseVisualStyleBackColor = false;
            this.btnUpdateAuthor.Click += new System.EventHandler(this.btnUpdateAuthor_Click);
            // 
            // lblAuthorId
            // 
            this.lblAuthorId.AutoSize = true;
            this.lblAuthorId.Location = new System.Drawing.Point(62, 48);
            this.lblAuthorId.Name = "lblAuthorId";
            this.lblAuthorId.Size = new System.Drawing.Size(18, 13);
            this.lblAuthorId.TabIndex = 9;
            this.lblAuthorId.Text = "ID";
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(148, 48);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(35, 20);
            this.txtAuthorId.TabIndex = 10;
            // 
            // FrmAuthorProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.txtAuthorId);
            this.Controls.Add(this.lblAuthorId);
            this.Controls.Add(this.btnUpdateAuthor);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.dataGridViewAuthor);
            this.Controls.Add(this.lblAuthorSurname);
            this.Controls.Add(this.txtAuthorSurname);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.lblAuthorName);
            this.Name = "FrmAuthorProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Author Process";
            this.Load += new System.EventHandler(this.FrmAuthorProcess_Load);
            this.Click += new System.EventHandler(this.FrmAuthorProcess_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtAuthorSurname;
        private System.Windows.Forms.Label lblAuthorSurname;
        private System.Windows.Forms.DataGridView dataGridViewAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnUpdateAuthor;
        private System.Windows.Forms.Label lblAuthorId;
        private System.Windows.Forms.TextBox txtAuthorId;
    }
}