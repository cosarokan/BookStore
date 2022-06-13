using System;
using System.Windows.Forms;
using BusinessLogicLayer;
using EntityLayer.Entities;

namespace UserInterface
{
    public partial class FrmTypeProcess : Form
    {
        public FrmTypeProcess()
        {
            InitializeComponent();
        }
        BookTypeManager bookTypeManager = new BookTypeManager();
        private void FrmTypeProcess_Load(object sender, EventArgs e)
        {
            GetAllBookTypeToGridView();
        }
        private void btnSaveBookType_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBookTypeName.Text))
                {
                    MessageBox.Show("Book type name must not be empty!");
                    return;
                }
                BookType bookType = new BookType()
                {
                    TypeName = txtBookTypeName.Text,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                };
                bookTypeManager.AddNewBookType(bookType);
                MessageBox.Show("Added new book type");
                GetAllBookTypeToGridView();
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ClearTextBox()
        {
            txtBookTypeName.Clear();
        }
        void GetAllBookTypeToGridView()
        {
            try
            {
                dataGridViewBookType.DataSource = bookTypeManager.GetAllTheBookTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
