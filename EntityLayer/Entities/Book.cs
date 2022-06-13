using EntityLayer.AbstractEntities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
    [Table("Books")]
    public class Book : Base<int>
    {
        [Required(ErrorMessage = "The book name must not be empty!")] // boş geçilemez.
        [StringLength(100, ErrorMessage = "The book name must be a maximum of 100 characters!")]
        public string BookName { get; set; }

        public string ISBN { get; set; }
        public byte BookTypeId { get; set; }
        public int AuthorId { get; set; }
        public int YearOfPublication { get; set; }
        public int Page { get; set; }
        

        [ForeignKey("BookTypeId")]
        public virtual BookType BookType { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }
    }
}
