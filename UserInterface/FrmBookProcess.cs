using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
namespace UserInterface
{
    public partial class FrmBookProcess : Form
    {
        MyContext myContext = new MyContext();
        BookTypeManager bookTypeManager = new BookTypeManager();
        AuthorManager authorManager = new AuthorManager();
        BookManager bookManager = new BookManager();
        public FrmBookProcess()
        {
            InitializeComponent();

        }
        private void FrmBookProcess_Load(object sender, EventArgs e)
        {
            GetAllBooks();
            VisibleProcess();
            GetBookTypeIdAndNameToComboBox();
            GetAuthorIdAndNameToComboBox();
            ColumnVisibleProcess();
            SelectFullRow();
        }
        void GetBookTypeIdAndNameToComboBox()
        {
            cBoxProcessBookType.DisplayMember = "TypeName";
            cBoxProcessBookType.ValueMember = "Id";
            cBoxProcessBookType.DataSource = bookTypeManager.GetAllBookTypeName();
        }
        void GetAuthorIdAndNameToComboBox()
        {
            cBoxProcessAuthor.DisplayMember = "Name Surname";
            cBoxProcessAuthor.ValueMember = "Id";
            cBoxProcessAuthor.DataSource = authorManager.GetAllAuthors();
        }
        private void btnProcessAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book()
                {
                    BookName = txtProcessBookName.Text,
                    ISBN = txtProcessISBN.Text,
                    Page = Convert.ToInt32(txtProcessPage.Text),
                    YearOfPublication = Convert.ToInt32(txtProcessYearOfPublication.Text),
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    AuthorId = Convert.ToInt32(cBoxProcessAuthor.SelectedValue),
                    BookTypeId = Convert.ToByte(cBoxProcessBookType.SelectedValue)
                };
                bookManager.AddNewBook(book);
                GetAllBooks();
                MessageBox.Show("Added");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void GetAllBooks()
        {
            try
            {
                dataGridViewBook.DataSource = bookManager.GetAllBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void VisibleProcess()
        {

        }
        void ColumnVisibleProcess()
        {
            dataGridViewBook.Columns[1].Visible = false;
            dataGridViewBook.Columns[8].Visible = false;
            dataGridViewBook.Columns[2].Visible = false;
            dataGridViewBook.Columns[3].Visible = false;
        }
        void Clear()
        {
            txtProcessBookName.Clear();
            txtProcessISBN.Clear();
            txtProcessPage.Clear();
            txtProcessYearOfPublication.Clear();
        }
        void SelectFullRow()
        {
            dataGridViewBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _isbn = dataGridViewBook.SelectedRows[0].Cells["ISBN"].Value.ToString();
            var query = myContext.Books.FirstOrDefault(x => x.ISBN == _isbn);

            query.IsDeleted = true;

            myContext.SaveChanges();

            MessageBox.Show("Test");
            GetAllBooks();
        }
        private void dataGridViewBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProcessISBN.Text = dataGridViewBook.CurrentRow.Cells[1].Value.ToString();
        }
        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _isbn = dataGridViewBook.SelectedRows[0].Cells["ISBN"].Value.ToString();
            var query = myContext.Books.FirstOrDefault(x => x.ISBN == _isbn);

            query.IsDeleted = false;

            myContext.SaveChanges();

            MessageBox.Show("Test");
            GetAllBooks();
        }
    }
}
