using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Windows.Forms;
namespace UserInterface
{
    public partial class FrmAuthorProcess : Form
    {
        MyContext myContext = new MyContext();
        AuthorManager authorManager = new AuthorManager();
        public FrmAuthorProcess()
        {
            InitializeComponent();
        }
        private void FrmAuthorProcess_Load(object sender, EventArgs e)
        {
            GetAllAuthorsToGridView();
            ColumnVisibleProcess();
            SelectFullRow();
            DisableId();
        }
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAuthorName.Text))
                {
                    MessageBox.Show("Author name must not be empty!");
                    return;
                }
                Author author = new Author()
                {
                    Name = txtAuthorName.Text,
                    Surname = txtAuthorSurname.Text,
                    CreatedDate = DateTime.Now
                };
                authorManager.AddNewAuthor(author);
                MessageBox.Show("Added new author");
                GetAllAuthorsToGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridViewAuthor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableId();
            txtAuthorId.Text = dataGridViewAuthor.CurrentRow.Cells[3].Value.ToString();
            txtAuthorName.Text = dataGridViewAuthor.CurrentRow.Cells[0].Value.ToString();
            txtAuthorSurname.Text = dataGridViewAuthor.CurrentRow.Cells[1].Value.ToString();
        }
        private void FrmAuthorProcess_Click(object sender, EventArgs e)
        {
            Clear();
            DisableId();
        }
        void GetAllAuthorsToGridView()
        {
            try
            {
                dataGridViewAuthor.DataSource = authorManager.GetAllAuthors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void SelectFullRow()
        {
            dataGridViewAuthor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        void ColumnVisibleProcess()
        {
            dataGridViewAuthor.Columns[2].Visible = false;
            dataGridViewAuthor.Columns[3].Visible = false;
        }
        void DisableId()
        {
            lblAuthorId.Enabled = false;
            txtAuthorId.Enabled = false;
        }
        void EnableId()
        {
            lblAuthorId.Enabled = true;
            txtAuthorId.Enabled = true;
        }
        void Clear()
        {
            txtAuthorId.Clear();
            txtAuthorName.Clear();
            txtAuthorSurname.Clear();
        }
        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            if (txtAuthorId.Enabled == true)
            {
                int _id = Convert.ToInt32(txtAuthorId.Text);
                var query = myContext.Authors.Find(_id);

                query.Name = txtAuthorName.Text;
                query.Surname = txtAuthorSurname.Text;

                myContext.SaveChanges();

                MessageBox.Show("Test");
                GetAllAuthorsToGridView();
            }
        }
    }
}
