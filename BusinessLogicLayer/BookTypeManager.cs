using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer
{
    public class BookTypeManager
    {
        private MyContext BookContext = new MyContext();

        public List<BookType> GetAllTheBookTypes()
        {
            try
            {
                List<BookType> list = new List<BookType>();
                list = BookContext.BookTypes.ToList();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddNewBookType(BookType bookType)
        {
            try
            {
                BookContext.BookTypes.Add(bookType);
                BookContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
