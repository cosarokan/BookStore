using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer
{
    public class BookManager
    {
        MyContext BookContext = new MyContext();

        public List<Book> GetAllBooks()
        {
            try
            {
                List<Book> books = new List<Book>();
                books = BookContext.Books.ToList();
                return books;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddNewBook(Book book)
        {
            try
            {
                BookContext.Books.Add(book);
                BookContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdateBook(Book book)
        {
            try
            {
                BookContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
