namespace UserInterface
{
    partial class FrmBookProcess
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
            this.components = new System.ComponentModel.Container();
            this.lblProcessBookName = new System.Windows.Forms.Label();
            this.txtProcessBookName = new System.Windows.Forms.TextBox();
            this.lblProcessISBN = new System.Windows.Forms.Label();
            this.lblProcessYearOfPublication = new System.Windows.Forms.Label();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProcessAdd = new System.Windows.Forms.Button();
            this.txtProcessISBN = new System.Windows.Forms.TextBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.txtProcessPage = new System.Windows.Forms.TextBox();
            this.lblProcessBookType = new System.Windows.Forms.Label();
            this.cBoxProcessBookType = new System.Windows.Forms.ComboBox();
            this.lblProcessAuthor = new System.Windows.Forms.Label();
            this.cBoxProcessAuthor = new System.Windows.Forms.ComboBox();
            this.txtProcessYearOfPublication = new System.Windows.Forms.TextBox();
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProcessBookName
            // 
            this.lblProcessBookName.AutoSize = true;
            this.lblProcessBookName.Location = new System.Drawing.Point(159, 45);
            this.lblProcessBookName.Name = "lblProcessBookName";
            this.lblProcessBookName.Size = new System.Drawing.Size(63, 13);
            this.lblProcessBookName.TabIndex = 0;
            this.lblProcessBookName.Text = "Book Name";
            // 
            // txtProcessBookName
            // 
            this.txtProcessBookName.Location = new System.Drawing.Point(272, 42);
            this.txtProcessBookName.Name = "txtProcessBookName";
            this.txtProcessBookName.Size = new System.Drawing.Size(146, 20);
            this.txtProcessBookName.TabIndex = 0;
            // 
            // lblProcessISBN
            // 
            this.lblProcessISBN.AutoSize = true;
            this.lblProcessISBN.Location = new System.Drawing.Point(159, 88);
            this.lblProcessISBN.Name = "lblProcessISBN";
            this.lblProcessISBN.Size = new System.Drawing.Size(32, 13);
            this.lblProcessISBN.TabIndex = 2;
            this.lblProcessISBN.Text = "ISBN";
            // 
            // lblProcessYearOfPublication
            // 
            this.lblProcessYearOfPublication.AutoSize = true;
            this.lblProcessYearOfPublication.Location = new System.Drawing.Point(159, 131);
            this.lblProcessYearOfPublication.Name = "lblProcessYearOfPublication";
            this.lblProcessYearOfPublication.Size = new System.Drawing.Size(98, 13);
            this.lblProcessYearOfPublication.TabIndex = 4;
            this.lblProcessYearOfPublication.Text = "Year Of Publication";
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewBook.Location = new System.Drawing.Point(12, 215);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.Size = new System.Drawing.Size(913, 161);
            this.dataGridViewBook.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.activeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnProcessAdd
            // 
            this.btnProcessAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcessAdd.Location = new System.Drawing.Point(598, 142);
            this.btnProcessAdd.Name = "btnProcessAdd";
            this.btnProcessAdd.Size = new System.Drawing.Size(146, 49);
            this.btnProcessAdd.TabIndex = 6;
            this.btnProcessAdd.Text = "Add";
            this.btnProcessAdd.UseVisualStyleBackColor = false;
            this.btnProcessAdd.Click += new System.EventHandler(this.btnProcessAdd_Click);
            // 
            // txtProcessISBN
            // 
            this.txtProcessISBN.Location = new System.Drawing.Point(272, 86);
            this.txtProcessISBN.MaxLength = 10;
            this.txtProcessISBN.Name = "txtProcessISBN";
            this.txtProcessISBN.Size = new System.Drawing.Size(146, 20);
            this.txtProcessISBN.TabIndex = 1;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(159, 174);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(32, 13);
            this.lblPage.TabIndex = 9;
            this.lblPage.Text = "Page";
            // 
            // txtProcessPage
            // 
            this.txtProcessPage.Location = new System.Drawing.Point(272, 174);
            this.txtProcessPage.Name = "txtProcessPage";
            this.txtProcessPage.Size = new System.Drawing.Size(146, 20);
            this.txtProcessPage.TabIndex = 3;
            // 
            // lblProcessBookType
            // 
            this.lblProcessBookType.AutoSize = true;
            this.lblProcessBookType.Location = new System.Drawing.Point(512, 45);
            this.lblProcessBookType.Name = "lblProcessBookType";
            this.lblProcessBookType.Size = new System.Drawing.Size(59, 13);
            this.lblProcessBookType.TabIndex = 11;
            this.lblProcessBookType.Text = "Book Type";
            // 
            // cBoxProcessBookType
            // 
            this.cBoxProcessBookType.FormattingEnabled = true;
            this.cBoxProcessBookType.Location = new System.Drawing.Point(598, 45);
            this.cBoxProcessBookType.Name = "cBoxProcessBookType";
            this.cBoxProcessBookType.Size = new System.Drawing.Size(146, 21);
            this.cBoxProcessBookType.TabIndex = 4;
            // 
            // lblProcessAuthor
            // 
            this.lblProcessAuthor.AutoSize = true;
            this.lblProcessAuthor.Location = new System.Drawing.Point(512, 89);
            this.lblProcessAuthor.Name = "lblProcessAuthor";
            this.lblProcessAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblProcessAuthor.TabIndex = 13;
            this.lblProcessAuthor.Text = "Author";
            // 
            // cBoxProcessAuthor
            // 
            this.cBoxProcessAuthor.FormattingEnabled = true;
            this.cBoxProcessAuthor.Location = new System.Drawing.Point(598, 84);
            this.cBoxProcessAuthor.Name = "cBoxProcessAuthor";
            this.cBoxProcessAuthor.Size = new System.Drawing.Size(146, 21);
            this.cBoxProcessAuthor.TabIndex = 5;
            // 
            // txtProcessYearOfPublication
            // 
            this.txtProcessYearOfPublication.Location = new System.Drawing.Point(272, 130);
            this.txtProcessYearOfPublication.Name = "txtProcessYearOfPublication";
            this.txtProcessYearOfPublication.Size = new System.Drawing.Size(146, 20);
            this.txtProcessYearOfPublication.TabIndex = 2;
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activeToolStripMenuItem.Text = "Active";
            this.activeToolStripMenuItem.Click += new System.EventHandler(this.activeToolStripMenuItem_Click);
            // 
            // FrmBookProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 388);
            this.Controls.Add(this.txtProcessYearOfPublication);
            this.Controls.Add(this.cBoxProcessAuthor);
            this.Controls.Add(this.lblProcessAuthor);
            this.Controls.Add(this.cBoxProcessBookType);
            this.Controls.Add(this.lblProcessBookType);
            this.Controls.Add(this.txtProcessPage);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.txtProcessISBN);
            this.Controls.Add(this.btnProcessAdd);
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.lblProcessYearOfPublication);
            this.Controls.Add(this.lblProcessISBN);
            this.Controls.Add(this.txtProcessBookName);
            this.Controls.Add(this.lblProcessBookName);
            this.Name = "FrmBookProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBookProcess";
            this.Load += new System.EventHandler(this.FrmBookProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcessBookName;
        private System.Windows.Forms.TextBox txtProcessBookName;
        private System.Windows.Forms.Label lblProcessISBN;
        private System.Windows.Forms.Label lblProcessYearOfPublication;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.Button btnProcessAdd;
        private System.Windows.Forms.TextBox txtProcessISBN;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.TextBox txtProcessPage;
        private System.Windows.Forms.Label lblProcessBookType;
        private System.Windows.Forms.ComboBox cBoxProcessBookType;
        private System.Windows.Forms.Label lblProcessAuthor;
        private System.Windows.Forms.ComboBox cBoxProcessAuthor;
        private System.Windows.Forms.TextBox txtProcessYearOfPublication;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
    }
}