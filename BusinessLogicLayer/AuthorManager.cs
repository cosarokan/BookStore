using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer
{
    public class AuthorManager
    {
        private MyContext AuthorContext = new MyContext();
        public List<Author> GetAllAuthors()
        {
            try
            {
                List<Author> list = new List<Author>();
                list = AuthorContext.Authors.ToList();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddNewAuthor(Author author)
        {
            try
            {
                AuthorContext.Authors.Add(author);
                AuthorContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdateAuthor(Author author)
        {
            try
            {

                AuthorContext.SaveChanges(); 
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
